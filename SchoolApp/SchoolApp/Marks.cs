using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class Marks : Form
    {
        DataRow user_;
        Form prevForm_;
        SqlConnection connection_;
        string roleName_;

        string queryMarks_ = "";
        string queryClass_ = "";
        string querySupervisedClass_ = "";
        int comboBoxClass_ = -1;

        bool isQuarterMarkChecked = false;

        public Marks()
        {
            InitializeComponent();
        }

        public Marks(DataRow user, Form prevForm, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            user_ = user;
            prevForm_ = prevForm;
            connection_ = connection;
            roleName_ = roleName;

            initComboBox();
            initMarks();
        }

        private void initComboBox()
        {
            if(roleName_.Equals("Директор"))
            {
                queryClass_ = string.Format(@"SELECT idClass FROM Classes");
                querySupervisedClass_ = "";
            } else if(roleName_.Equals("Классный руководитель"))
            {

                int supervisedClass = (int)user_["idSupervisedClass"];
                querySupervisedClass_ = string.Format(@"SELECT DISTINCT c.idClass FROM Classes as c
                    JOIN Users as u ON u.idClass = c.idClass
                    WHERE c.idClass = {0}", supervisedClass);

                int idTeacher = (int)user_["idUser"];
                queryClass_ = queryClass_ = string.Format(@"SELECT DISTINCT s.idClass From Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacher = s.idTeacherDiscipline
                    JOIN Classes as c ON s.idClass = c.idClass 
                    WHERE t.idTeacher = {0}", idTeacher);
            } else if(roleName_.Equals("Учитель"))
            {

                int idTeacher = (int)user_["idUser"];
                queryClass_ = string.Format(@"SELECT DISTINCT s.idClass From Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacher = s.idTeacherDiscipline
                    JOIN Classes as c ON s.idClass = c.idClass 
                     WHERE t.idTeacher = {0}", idTeacher);
                querySupervisedClass_ = "";
            } else
            {
                return;
            }

            SqlDataAdapter classesAdapter = new SqlDataAdapter(queryClass_, connection_);
            DataTable classes = new DataTable();
            classesAdapter.Fill(classes);

            SqlDataAdapter supervisedAdapter = new SqlDataAdapter(querySupervisedClass_, connection_);    
            DataTable supervisedClasses = new DataTable();

            if(classes.Rows.Count > 0)
            {

                for (int i = 0; i < classes.Rows.Count; ++i)
                {
                    chooseClassComboBox.Items.Add(
                        "" + classes.Rows[i]["idClass"]
                        );
                }

                if(comboBoxClass_ == -1)
                {
                    comboBoxClass_ = (int)classes.Rows[1]["idClass"];

                }
            }


            if (querySupervisedClass_.Length > 0)
            {
                supervisedAdapter.Fill(supervisedClasses);
                chooseClassComboBox.Items.Add(
                    "" + supervisedClasses.Rows[0]["idClass"]
                    );

                if(comboBoxClass_ == -1)
                {
                    comboBoxClass_ = (int)supervisedClasses.Rows[0]["idClass"];
                }

            }

            
        }

        private void initMarks()
        {
            quarterMarksDataGridView.Visible = false;
            marksDataGridView.Visible = true;
            isQuarterMark.Checked = isQuarterMarkChecked;

            if (roleName_.Equals("Директор"))
            {
                DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                queryMarks_ = string.Format(@"SELECT mark, dateOfMark, title FROM Marks
                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
                     JOIN Users AS u ON u.idUser = Marks.idStudent
	                JOIN Classes AS c ON c.idClass = u.idClass
                    WHERE dateOfMark < '{0}' AND c.idClass = {1}
                    GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, comboBoxClass_);
            }
            else if (roleName_.Equals("Классный руководитель"))
            {
                DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                queryMarks_ = string.Format(@"SELECT mark, dateOfMark, title FROM Marks
                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
                    JOIN Users AS u ON u.idUser = Marks.idStudent
	                JOIN Classes AS c ON c.idClass = u.idClass
                    WHERE dateOfMark < '{0}' AND c.idClass = {1}
                    GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, comboBoxClass_);
            }
            else if (roleName_.Equals("Учитель"))
            {

                int idTeacher = (int)user_["idUser"];
                DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                queryMarks_ = string.Format(@"SELECT mark, dateOfMark, title FROM Marks
	                JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
	                JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
                    JOIN Users AS u ON u.idUser = Marks.idStudent
	                JOIN Classes AS c ON c.idClass = u.idClass
	                WHERE Marks.dateOfMark < '{0}' AND TeacherDisciplines.idTeacher = {1} AND c.idClass = {2}
	                GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, idTeacher, comboBoxClass_);
            }
            else if (roleName_.Equals("Ученик"))
            {
                chooseClassLabel.Visible = false;
                chooseClassComboBox.Visible = false;
                int idStudent = (int)user_["idUser"];
                DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                queryMarks_ = string.Format(@"SELECT mark, dateOfMark, title FROM Marks
                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
                    WHERE dateOfMark < '{0}' AND Marks.idStudent = {1}", dateOfMark, idStudent);
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryMarks_, connection_);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

          

            initMarksDataGridView(dataTable);
            
        }

        private void initMarksDataGridView(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                marksDataGridView.Visible = false;
            }
            string[][] marksArray = new string[dataTable.Rows.Count][];
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                string[] s = new string[]
              {
                       "" + dataTable.Rows[i]["mark"],
                       "" + dataTable.Rows[i]["dateOfMark"],
                       "" + dataTable.Rows[i]["title"]
             };
                marksArray[i] = s;
            };

            marksDataGridView.Rows.Clear();
            for (int i = 0; i < marksArray.Length; ++i)
            {
                marksDataGridView.Rows.Add(marksArray[i]);
            }
        }


        private void choosePeriodEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(isQuarterMark.Checked == true)
            {
                initMarkWithCheckQuarter();
            }
        }

        private void isQuarterMark_CheckedChanged(object sender, EventArgs e)
        {      
            isQuarterMark.Checked = !isQuarterMarkChecked; 
            isQuarterMarkChecked = isQuarterMark.Checked;

            initMarkWithCheckQuarter();
         
        }

        private void chooseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxClass_ = Int32.Parse(chooseClassComboBox.Text);
            initMarkWithCheckQuarter();
        }

        private void initMarkWithCheckQuarter()
        {
            if (isQuarterMarkChecked)
            {
                marksDataGridView.Visible = false;
                quarterMarksDataGridView.Visible = true;
                if (roleName_.Equals("Директор"))
                {

                    DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                    queryMarks_ = string.Format(@"SELECT ROUND (AVG(CAST(Marks.mark as float)), 1) as quarterMark, 
	                    Disciplines.title as titleQuarterDiscipline, Users.firstName,
	                    Users.secondName, Users.lastName FROM Marks
	                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
	                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
	                    JOIN Users ON Marks.idStudent = Users.idUser
                        JOIN Classes ON Classes.idClass = Users.idClass
	                    WHERE Marks.dateOfMark < '{0}' AND Classes.idClass = {1}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, comboBoxClass_);

                }
                else if (roleName_.Equals("Классный руководитель"))
                {
                    DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                    queryMarks_ = string.Format(@"SELECT ROUND (AVG(CAST(Marks.mark as float)), 1) as quarterMark, 
	                    Disciplines.title as titleQuarterDiscipline, Users.firstName,
	                    Users.secondName, Users.lastName FROM Marks
	                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
	                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
	                    JOIN Users ON Marks.idStudent = Users.idUser
                        JOIN Classes ON Classes.idClass = Users.idClass
	                    WHERE Marks.dateOfMark < '{0}' AND Classes.idClass = {1}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, comboBoxClass_);
                }
                else if (roleName_.Equals("Учитель"))
                {
                    DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;
                    int idTeacher = (int)user_["idUser"];

                    queryMarks_ = string.Format(@"SELECT ROUND (AVG(CAST(Marks.mark as float)), 1) as quarterMark, 
	                    Disciplines.title as titleQuarterDiscipline, Users.firstName,
	                    Users.secondName, Users.lastName FROM Marks
	                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
	                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
	                    JOIN Users ON Marks.idStudent = Users.idUser 
                        JOIN Classes ON Classes.idClass = Users.idClass
	                    WHERE Marks.dateOfMark < '{0}' AND TeacherDisciplines.idTeacher = {1} AND Classes.idClass = {2}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName, 
                        TeacherDisciplines.idTeacher", dateOfMark, idTeacher, comboBoxClass_);
                }
                else if (roleName_.Equals("Ученик"))
                {
                    DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;
                    int idStudent = (int)user_["idUser"];

                    queryMarks_ = string.Format(@"SELECT ROUND (AVG(CAST(Marks.mark as float)), 1) as quarterMark, 
	                    Disciplines.title as titleQuarterDiscipline, Users.firstName,
	                    Users.secondName, Users.lastName FROM Marks
	                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
	                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
	                    JOIN Users ON Marks.idStudent = Users.idUser 
	                    WHERE Marks.dateOfMark < '{0}' AND Marks.idStudent = {1}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, idStudent);
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryMarks_, connection_);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                initQuarterMarksDataGridView(dataTable);
            }
            else
            {
                initMarks();
            }
        }

        private void initQuarterMarksDataGridView(DataTable dataTable)
        {
            
            if (dataTable.Rows.Count == 0)
            {
                quarterMarksDataGridView.Visible = false;
            }
            string[][] marksArray = new string[dataTable.Rows.Count][];
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                string[] s = new string[]
              {
                       "" + dataTable.Rows[i]["quarterMark"],
                       "" + dataTable.Rows[i]["titleQuarterDiscipline"],
                       "" + dataTable.Rows[i]["firstName"],
                       "" + dataTable.Rows[i]["secondName"],
                       "" + dataTable.Rows[i]["lastName"],
             };
                marksArray[i] = s;
            };

            quarterMarksDataGridView.Rows.Clear();
            for (int i = 0; i < marksArray.Length; ++i)
            {
                quarterMarksDataGridView.Rows.Add(marksArray[i]);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm_.Show();
        }
    }
}
