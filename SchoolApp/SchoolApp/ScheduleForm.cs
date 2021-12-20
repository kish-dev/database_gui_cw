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
    public partial class ScheduleForm : Form
    {
        DataRow user_;
        Form prevForm_;
        SqlConnection connection_;
        string roleName_;

        string querySchedule_ = "";
        string queryClass_ = "";
        string querySupervisedClass_ = "";
        int comboBoxClass_ = -1;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        public ScheduleForm(DataRow user, Form prevForm, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            user_ = user;
            prevForm_ = prevForm;
            connection_ = connection;
            roleName_ = roleName;

            initComboBoxClasses();
            initSchedule();
        }

        private void initComboBoxClasses()
        {
            if (roleName_.Equals("Директор"))
            {
                queryClass_ = string.Format(@"SELECT idClass FROM Classes");
                querySupervisedClass_ = "";
            }
            else if (roleName_.Equals("Классный руководитель"))
            {

                int supervisedClass = (int)user_["idSupervisedClass"];
                querySupervisedClass_ = string.Format(@"SELECT DISTINCT c.idClass FROM Classes as c
                    JOIN Users as u ON u.idClass = c.idClass
                    WHERE c.idClass = {0}", supervisedClass);


                int idTeacher = (int)user_["idUser"];
                queryClass_ = queryClass_ = string.Format(@"SELECT DISTINCT s.idClass From Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
                    JOIN Classes as c ON s.idClass = c.idClass 
                    WHERE t.idTeacher = {0}", idTeacher);
            }
            else if (roleName_.Equals("Учитель"))
            {
                int idTeacher = (int)user_["idUser"];
                queryClass_ = string.Format(@"SELECT DISTINCT s.idClass  From Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacherDiscipline = s.idTeacherDiscipline
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

            if (classes.Rows.Count > 0)
            {

                for (int i = 0; i < classes.Rows.Count; ++i)
                {
                    chooseClassComboBox.Items.Add(
                        "" + classes.Rows[i]["idClass"]
                        );
                }

                if (comboBoxClass_ == -1)
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

                if (comboBoxClass_ == -1)
                {
                    comboBoxClass_ = (int)supervisedClasses.Rows[0]["idClass"];
                }

            }


        }

        private void initSchedule()
        {
            DateTime endDate = chooseEndDatePicker.Value;
            DateTime beginDate = chooseBeginDatePicker.Value;
            if (roleName_.Equals("Директор"))
            {
                querySchedule_ = string.Format(@"SELECT d.title, s.date, c.number, c.letter, u.firstName, u.secondName, u.lastName FROM
	                Schedule AS s
	                JOIN TeacherDisciplines AS td ON td.idTeacherDiscipline = s.idTeacherDiscipline
	                JOIN Disciplines AS d ON td.idDiscipline = d.idDiscipline
	                JOIN Users AS u ON u.idUser = td.idTeacher
                    JOIN Classes AS c ON c.idClass = s.idClass
	                WHERE s.idClass = {2} AND s.date > '{0}' AND s.date < '{1}'", beginDate, endDate, comboBoxClass_);
            }
            else if (roleName_.Equals("Классный руководитель"))
            {
                querySchedule_ = string.Format(@"SELECT d.title, s.date,  c.number, c.letter, u.firstName, u.secondName, u.lastName FROM
	                Schedule AS s
	                JOIN TeacherDisciplines AS td ON td.idTeacherDiscipline = s.idTeacherDiscipline
	                JOIN Disciplines AS d ON td.idDiscipline = d.idDiscipline
	                JOIN Users AS u ON u.idUser = td.idTeacher
                    JOIN Classes AS c ON c.idClass = s.idClass
	                WHERE s.idClass = {2} AND s.date > '{0}' AND s.date < '{1}'", beginDate, endDate, comboBoxClass_);
            }
            else if (roleName_.Equals("Учитель"))
            {

                int idTeacher = (int)user_["idUser"];

                querySchedule_ = string.Format(@"SELECT d.title, s.date, c.number, c.letter, u.firstName, u.secondName, u.lastName FROM
	                Schedule AS s
	                JOIN TeacherDisciplines AS td ON td.idTeacherDiscipline = s.idTeacherDiscipline
	                JOIN Disciplines AS d ON td.idDiscipline = d.idDiscipline
	                JOIN Users AS u ON u.idUser = td.idTeacher
                    JOIN Classes AS c ON c.idClass = s.idClass
	                WHERE s.idClass = {3} AND td.idTeacher = {2} AND s.date > '{0}' AND s.date < '{1}'", beginDate, endDate, idTeacher, comboBoxClass_);
            }
            else if (roleName_.Equals("Ученик"))
            {
                chooseClassLabel.Visible = false;
                chooseClassComboBox.Visible = false;
                int idStudent = (int)user_["idUser"];

                querySchedule_ = string.Format(@"SELECT DISTINCT d.title, s.date, c.number, c.letter, u.firstName, u.firstName, u.secondName, u.lastName FROM
	                Schedule AS s
	                JOIN TeacherDisciplines AS td ON td.idTeacherDiscipline = s.idTeacherDiscipline
	                JOIN Disciplines AS d ON td.idDiscipline = d.idDiscipline
	                JOIN Users AS u ON u.idUser = td.idTeacher
	                JOIN Classes AS c ON s.idClass = c.idClass
	                JOIN Users as students ON students.idClass = c.idClass
	                WHERE students.idUser = {2} AND s.date > '{0}' AND s.date < '{1}'", beginDate, endDate, idStudent);
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querySchedule_, connection_);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            initScheduleDataGridView(dataTable);
        }

        private void initScheduleDataGridView(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                scheduleDataGridView.Visible = false;
            }
            string[][] marksArray = new string[dataTable.Rows.Count][];
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                string[] s = new string[]
              {
                      "" + dataTable.Rows[i]["title"],
                       "" + dataTable.Rows[i]["number"],
                       "" + dataTable.Rows[i]["letter"],
                       "" + dataTable.Rows[i]["date"],
                       "" + dataTable.Rows[i]["firstName"],
                       "" + dataTable.Rows[i]["secondName"],
                       "" + dataTable.Rows[i]["lastName"],

             };
                marksArray[i] = s;
            };

            scheduleDataGridView.Rows.Clear();
            for (int i = 0; i < marksArray.Length; ++i)
            {
                scheduleDataGridView.Rows.Add(marksArray[i]);
            }
        }

        private void chooseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxClass_ = Int32.Parse(chooseClassComboBox.Text);
            initSchedule();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm_.Show();
        }
    }

}
