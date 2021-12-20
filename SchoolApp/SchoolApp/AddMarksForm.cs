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
    public partial class AddMarksForm : Form
    {

        DataRow user_;
        Form prevForm_;
        SqlConnection connection_;
        string roleName_;

        string queryClass_ = "";
        string queryStudents_ = "";
        string queryDisciplines_ = "";

        int classId_ = -1;
        int studentId_ = -1;
        int mark_ = -1;
        int disciplineId_ = -1;
        DateTime date = DateTime.Now;   

        public AddMarksForm()
        {
            InitializeComponent();
        }

        public AddMarksForm(DataRow user, Form prevForm, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            user_ = user;
            prevForm_ = prevForm;
            connection_ = connection;
            roleName_ = roleName;

            errorLabel.Visible = false;
            initChooseMarkComboBox();
            initChooseClassComboBox();
            initChooseDisciplineComboBox();
        }

        private void initChooseDisciplineComboBox()
        {
            int idTeacher = (int)user_["idUser"];
            queryDisciplines_ = string.Format(@"SELECT DISTINCT d.title, d.idDiscipline From Disciplines as d
                JOIN TeacherDisciplines as t ON t.idDiscipline = d.idDiscipline
                WHERE t.idTeacher = {0}", idTeacher);


            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryDisciplines_, connection_);
            DataTable dataTable= new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {

                for (int i = 0; i < dataTable.Rows.Count; ++i)
                {
                    chooseDisciplineComboBox.Items.Add(
                        "" + dataTable.Rows[i]["title"] + " " +
                        dataTable.Rows[i]["idDiscipline"]
                        );
                }
            }
        }

        private void initChooseStudentComboBox()
        {
            if(classId_ != -1)
            {
                int idTeacher = (int)user_["idUser"];
                queryStudents_ = string.Format(@"SELECT DISTINCT u.firstName, u.secondName, u.lastName, u.idUser From Users as u
                    JOIN Classes as c ON u.idClass = c.idClass
                    WHERE c.idClass = {0}", classId_);
                

                SqlDataAdapter classesAdapter = new SqlDataAdapter(queryStudents_, connection_);
                DataTable classes = new DataTable();
                classesAdapter.Fill(classes);

                if (classes.Rows.Count > 0)
                {

                    for (int i = 0; i < classes.Rows.Count; ++i)
                    {
                        chooseStComboBox.Items.Add(
                            "" + classes.Rows[i]["firstName"] + " " +
                            classes.Rows[i]["secondName"] + " " +
                            classes.Rows[i]["lastName"] + " " + 
                            classes.Rows[i]["idUser"]
                            );
                    }
                }
            }
           
        }

        private void initChooseClassComboBox()
        {
           
                int idTeacher = (int)user_["idUser"];
                queryClass_ =  string.Format(@"SELECT DISTINCT s.idClass From Schedule as s
                    JOIN TeacherDisciplines as t ON t.idTeacher = s.idTeacherDiscipline
                    JOIN Classes as c ON s.idClass = c.idClass 
                    WHERE t.idTeacher = {0}", idTeacher);
            

            SqlDataAdapter classesAdapter = new SqlDataAdapter(queryClass_, connection_);
            DataTable classes = new DataTable();
            classesAdapter.Fill(classes);

            if (classes.Rows.Count > 0)
            {

                for (int i = 0; i < classes.Rows.Count; ++i)
                {
                    chooseClCB.Items.Add(
                        "" + classes.Rows[i]["idClass"]
                        );
                }
            }
        }

        private void initChooseMarkComboBox()
        {
            chooseMarkComboBox.Items.Clear();
            chooseMarkComboBox.Items.Add(2);
            chooseMarkComboBox.Items.Add(3);
            chooseMarkComboBox.Items.Add(4);
            chooseMarkComboBox.Items.Add(5);
        }

        private void chooseClCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            classId_ = Int32.Parse(chooseClCB.SelectedItem.ToString()); 
            initChooseStudentComboBox();    
        }

        private void chooseStComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] student = chooseStComboBox.SelectedItem.ToString().Split(' ');
            studentId_ = Int32.Parse(student[3]);
        }

        private void chooseMarkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mark_ = Int32.Parse(chooseMarkComboBox.SelectedItem.ToString());
        }

        private void chooseDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] discipline = chooseDisciplineComboBox.SelectedItem.ToString().Split(' ');
            disciplineId_ = Int32.Parse(discipline[1]);
        }

        private void AddMarkButton_Click(object sender, EventArgs e)
        {
            if(studentId_ == -1 || disciplineId_ == -1 || mark_ == -1 || classId_ == -1)
            {
                errorLabel.Visible = true;
            } else
            {
                errorLabel.Visible = false;
                string insertMark = string.Format(@"INSERT Marks(mark, dateOfMark, idStudent, idTeacherDiscipline)
                    VALUES({0}, '{1}', {2}, (SELECT t.idTeacherDiscipline FROM TeacherDisciplines as t
                                            JOIN Disciplines as d ON d.idDiscipline = t.idDiscipline
                                            WHERE d.idDiscipline = {3}))", mark_, chooseDateTimePicker.Value, studentId_, disciplineId_);

                connection_.Open();
                SqlCommand command = new SqlCommand(insertMark, connection_);
                command.ExecuteNonQuery();
                connection_.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm_.Show();
        }
    }
}
