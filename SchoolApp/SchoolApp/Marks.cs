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

        string queryDiscipline_ = "";
        int idDiscipline_ = -1;

        int idStudent_ = -1;

        string queryStudents_ = "";
        string querySupervisedStudents_ = "";

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
            initDisciplineComboBox();
            initComboBoxStudent();
            initMarks();
        }

        private void initComboBoxStudent()
        {
            comboBoxChooseStudent.Visible = true;
            chooseStudentLabel.Visible = true;
            if (roleName_.Equals("Директор"))
            {
                queryStudents_ = string.Format(@"SELECT DISTINCT u.firstName, u.secondName, u.lastName, u.idUser FROM Marks as m
                    JOIN Users as u ON u.idUser = m.idStudent
                    JOIN Classes as c ON c.idClass = u.idClass
                    WHERE c.idClass = {0}", comboBoxClass_);
            }
            else if (roleName_.Equals("Классный руководитель"))
            {

                /* int idTeacher = (int)user_["idUser"];
                 queryStudents_ = string.Format(@"SELECT DISTINCT  u.firstName, u.secondName, u.lastName. u.idUser FROM Schedule as s
                     JOIN Classes as c on s.idClass = c.idCLass
                     JOIN Users as u on u.idClass = c.idClass
                     JOIN TeacherDisciplines as t on t.idTeacherDiscipline = s.idTeacherDiscipline
                     WHERE t.idTeacher = {0}", idTeacher);

                 int idClass = (int)user_["idSupervisedClass"];
                 querySupervisedStudents_ = string.Format(@"SELECT DISTINCT  u.firstName, u.secondName, u.lastName, u.idUser FROM Classes as c
                     JOIN Users as u on u.idClass = c.idClass
                     WHERE c.idClass = {0}", idClass);*/
                queryStudents_ = string.Format(@"SELECT DISTINCT u.firstName, u.secondName, u.lastName, u.idUser FROM Marks as m
                    JOIN Users as u ON u.idUser = m.idStudent
                    JOIN Classes as c ON c.idClass = u.idClass
                    WHERE c.idClass = {0}", comboBoxClass_);

            } else if(roleName_.Equals("Учитель"))
            {

                /*   int idTeacher = (int)user_["idUser"];
                   queryStudents_ = string.Format(@"SELECT DISTINCT  u.firstName, u.secondName, u.lastName. u.idUser FROM Schedule as s
                       JOIN ClassesWithUsers as c on s.idClass = c.idCLass
                       JOIN Users as u on u.idUser = c.idStudent
                       JOIN TeacherDisciplines as t on t.idTeacherDiscipline = s.idTeacherDiscipline
                       WHERE t.idTeacher = {0}", idTeacher);*/
                queryStudents_ = string.Format(@"SELECT DISTINCT u.firstName, u.secondName, u.lastName, u.idUser FROM Marks as m
                    JOIN Users as u ON u.idUser = m.idStudent
                    JOIN Classes as c ON c.idClass = u.idClass
                    WHERE c.idClass = {0}", comboBoxClass_);
            } else
            {
                comboBoxChooseStudent.Visible = false;
                chooseStudentLabel.Visible = false;
                return;
            }
            comboBoxChooseStudent.Items.Clear();
            SqlDataAdapter studentAdapter = new SqlDataAdapter(queryStudents_, connection_);
            DataTable students = new DataTable();
            studentAdapter.Fill(students);

          /*  SqlDataAdapter supervisedAdapter = new SqlDataAdapter(querySupervisedStudents_, connection_);
            DataTable supervisedStudents = new DataTable();/**/

            if (students.Rows.Count > 0)
            {

                for (int i = 0; i < students.Rows.Count; ++i)
                {
                    comboBoxChooseStudent.Items.Add(
                        "" + students.Rows[i]["firstName"] + " " +
                        students.Rows[i]["secondName"] + " " +
                        students.Rows[i]["lastName"] + " " +
                        students.Rows[i]["idUser"]
                        );
                }

                if (idStudent_ == -1)
                {
                    idStudent_ = (int)students.Rows[0]["idUser"];

                }
            }


         /*  if (querySupervisedStudents_.Length > 0)
            {
                supervisedAdapter.Fill(supervisedStudents);
                comboBoxChooseStudent.Items.Add(
                     "" + supervisedStudents.Rows[0]["firstName"] + " " +
                        supervisedStudents.Rows[0]["secondName"] + " " +
                        supervisedStudents.Rows[0]["lastName"] + " " +
                        supervisedStudents.Rows[0]["idUser"]
                        );

                if (idStudent_ == -1)
                {
                    idStudent_ = (int)students.Rows[0]["idUser"];

                }

            }*/

        }

                private void initDisciplineComboBox() {
            if (roleName_.Equals("Директор"))
            {
                queryDiscipline_ = string.Format(@"SELECT DISTINCT d.title, d.idDiscipline FROM Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
                    JOIN Users as u on u.idClass = s.idClass    
                    JOIN Marks as m on m.idStudent = u.idUser
                    JOIN Disciplines as d ON d.idDiscipline = t.idDiscipline");
            }
            else if (roleName_.Equals("Классный руководитель"))
            {

                int idClass = (int)user_["idSupervisedClass"];
                int idTeacher = (int)user_["idUser"];
                queryDiscipline_ = string.Format(@"SELECT DISTINCT d.title, d.idDiscipline FROM Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
                    JOIN Users as u on u.idClass = s.idClass    
                    JOIN Marks as m on m.idStudent = u.idUser
                    JOIN Disciplines as d ON d.idDiscipline = t.idDiscipline
                    WHERE s.idClass = {0} or t.idTeacher = {1}", idClass, idTeacher);

            }
            else if (roleName_.Equals("Учитель"))
            {
                int idTeacher = (int)user_["idUser"];
                queryDiscipline_ = string.Format(@"SELECT DISTINCT d.title, d.idDiscipline FROM Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
                    JOIN Users as u on u.idClass = s.idClass    
                    JOIN Marks as m on m.idStudent = u.idUser
                    JOIN Disciplines as d ON d.idDiscipline = t.idDiscipline
                    WHERE t.idTeacher = {0}", idTeacher);
            }
            else
            {
                int idClass = (int)user_["idClass"];
                queryDiscipline_ = string.Format(@"SELECT DISTINCT d.title, d.idDiscipline FROM Schedule as s
                    JOIN Classes as c ON c.idClass = s.idClass
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
                    JOIN Users as u on u.idClass = s.idClass    
                    JOIN Marks as m on m.idStudent = u.idUser
                    JOIN Disciplines as d ON d.idDiscipline = t.idDiscipline
                    WHERE c.idClass = {0}", idClass);
            }



            SqlDataAdapter sda = new SqlDataAdapter(queryDiscipline_, connection_);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {

                for (int i = 0; i < dataTable.Rows.Count; ++i)
                {
                    chooseDisciplineComboBox.Items.Add(
                        "" + dataTable.Rows[i]["title"] + "," +
                        dataTable.Rows[i]["idDiscipline"]
                        );
                }

                if (idDiscipline_ == -1)
                {
                    idDiscipline_ = (int)dataTable.Rows[0]["idDiscipline"];

                }
            }

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
                    WHERE dateOfMark < '{0}' AND c.idClass = {1} AND Disciplines.idDiscipline = {2} AND Marks.idStudent = {3}
                    GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, comboBoxClass_, idDiscipline_, idStudent_);
            }
            else if (roleName_.Equals("Классный руководитель"))
            {
                DateTime dateOfMark = choosePeriodEndDateTimePicker.Value;

                queryMarks_ = string.Format(@"SELECT mark, dateOfMark, title FROM Marks
                    JOIN TeacherDisciplines ON TeacherDisciplines.idTeacherDiscipline = Marks.idTeacherDiscipline
                    JOIN Disciplines ON Disciplines.idDiscipline = TeacherDisciplines.idDiscipline
                    JOIN Users AS u ON u.idUser = Marks.idStudent
	                JOIN Classes AS c ON c.idClass = u.idClass
                    WHERE dateOfMark < '{0}' AND c.idClass = {1} AND Disciplines.idDiscipline = {2} AND Marks.idStudent = {3}
                    GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, comboBoxClass_, idDiscipline_, idStudent_);
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
                    AND Disciplines.idDiscipline = {3} AND Marks.idStudent = {4}
	                GROUP BY Disciplines.title, Marks.mark, Marks.dateOfMark", dateOfMark, idTeacher, comboBoxClass_, idDiscipline_, idStudent_);
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
                    WHERE dateOfMark < '{0}' AND Marks.idStudent = {1} AND Disciplines.idDiscipline = {2}", dateOfMark, idStudent, idDiscipline_);
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
            initComboBoxStudent();
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
	                    WHERE Marks.dateOfMark < '{0}' AND Classes.idClass = {1} AND Disciplines.idDiscipline = {2} AND Marks.idStudent = {3}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, comboBoxClass_, idDiscipline_,
                        idStudent_);

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
	                    WHERE Marks.dateOfMark < '{0}' AND Classes.idClass = {1}  AND Disciplines.idDiscipline = {2} AND Marks.idStudent = {3}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, comboBoxClass_, idDiscipline_,
                        idStudent_);

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
                        AND Disciplines.idDiscipline = {3} AND Marks.idStudent = {4}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName, 
                        TeacherDisciplines.idTeacher", dateOfMark, idTeacher, comboBoxClass_, idDiscipline_, idStudent_);
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
	                    WHERE Marks.dateOfMark < '{0}' AND Marks.idStudent = {1} AND Disciplines.idDiscipline = {2}
	                    GROUP BY Disciplines.title, Users.firstName, Users.secondName, Users.lastName", dateOfMark, idStudent, idDiscipline_);
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

        private void chooseDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string [] disciplines = chooseDisciplineComboBox.SelectedItem.ToString().Split(',');
            int lastIndex = disciplines.Length - 1; 
            idDiscipline_ = Int32.Parse(disciplines[lastIndex]);
            initMarkWithCheckQuarter();
        }

        private void comboBoxChooseStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] students = comboBoxChooseStudent.SelectedItem.ToString().Split(' ');
            idStudent_ = Int32.Parse(students[3]);
            initMarkWithCheckQuarter();
        }
    }
}
