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
    public partial class AddUser : Form
    {

        DataRow director_;
        Form prevForm_;
        SqlConnection connection_;
        string roleName_;
        bool isChanged_;
        bool isStudent_;

        int idClass_ = 7;
        int idSupervisedClass_ = 9;
        int idRole_ = 21;

        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(DataRow director, Form prevForm, SqlConnection connection, string roleName, bool isChanged, bool isStudent)
        {
            InitializeComponent();

            director_ = director;
            prevForm_ = prevForm;
            connection_ = connection;
            roleName_ = roleName;
            isChanged_ = isChanged;
            isStudent_ = isStudent;

            initVisibility();
            initClassesStudentComboBox();
            initClassesTeacherComboBox();
            initRoleComboBox();
        }

        private void initRoleComboBox()
        {
            if (isStudent_)
            {
                chooseRoleComboBox.Items.Add(
                       "Ученик 21"
                       );
                return;
            }
            
            string queryRole = string.Format(@"SELECT TOP 3 idRole, roleName FROM Roles");

            SqlDataAdapter sda = new SqlDataAdapter(queryRole, connection_);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    chooseRoleComboBox.Items.Add(
                        "" + dataTable.Rows[i]["roleName"] + "," +
                        dataTable.Rows[i]["idRole"]
                        );
                }
            }
        }

        private void initClassesTeacherComboBox()
        {
            string queryClass = string.Format(@"SELECT * FROM Classes");

            SqlDataAdapter sda = new SqlDataAdapter(queryClass, connection_);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    chooseClassTeacherComboBox.Items.Add(
                        "" + dataTable.Rows[i]["number"] + " " +
                        dataTable.Rows[i]["letter"] + " " +
                        dataTable.Rows[i]["idClass"]
                        );

                }
            }
        }

        private void initClassesStudentComboBox()
        {
            string queryClass = string.Format(@"SELECT * FROM Classes");

            SqlDataAdapter sda = new SqlDataAdapter(queryClass, connection_);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    chooseClassStComboBox.Items.Add(
                        "" + dataTable.Rows[i]["number"] + " " +
                        dataTable.Rows[i]["letter"] + " " +
                        dataTable.Rows[i]["idClass"]
                        );

                   
                }
            }
        }

        

        private void initVisibility()
        {
            errorLabel.Visible = false;
          

            if(isStudent_)
            {
                chooseClassForStudentLabel.Visible = true;
                chooseClassStComboBox.Visible = true;
                chooseClassTeacherLabel.Visible = false;
                chooseClassTeacherComboBox.Visible = false;

            } else
            {
                chooseClassForStudentLabel.Visible = false;
                chooseClassStComboBox.Visible = false;
                chooseClassTeacherLabel.Visible = true;
                chooseClassTeacherComboBox.Visible= true;
            }

            if (isChanged_)
            {
                chooseClassForStudentLabel.Visible = true;
                chooseClassStComboBox.Visible = true;
                chooseClassTeacherLabel.Visible = true;
                chooseClassTeacherComboBox.Visible = true;

                registerButton.Visible = false;
                changeUserButton.Visible = true;
            }
            else
            {
                registerButton.Visible = true;
                changeUserButton.Visible = false;
            }

        }

        private bool canCreateOrChange()
        {
            if(firstNameTextBox.Text.Length == 0 
                || secondNameTextBox.Text.Length == 0
                || loginTextBox.Text.Length == 0
                || passwordTextBox.Text.Length == 0
                || phoneTextBox.Text.Length == 0
                || emailTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void chooseRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] roleString = chooseRoleComboBox.SelectedItem.ToString().Split(',');
            idRole_ = Int32.Parse(roleString[1]);
            if(idRole_ == 18 || idRole_ == 20)
            {
                chooseClassTeacherLabel.Visible = false;
                chooseClassTeacherComboBox.Visible = false;
            } else if(idRole_ == 19)
            {
                chooseClassTeacherLabel.Visible = true;
                chooseClassTeacherComboBox.Visible = true;
            }
        }

        private void chooseClassStComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] classString = chooseClassStComboBox.SelectedItem.ToString().Split(' ');
            idClass_ = Int32.Parse(classString[2]);
        }

        private void chooseClassTeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] classString = chooseClassTeacherComboBox.SelectedItem.ToString().Split(' ');
            idSupervisedClass_ = Int32.Parse(classString[2]);
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            if (!canCreateOrChange())
            {
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;

                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string secondName = secondNameTextBox.Text;
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text.GetHashCode().ToString();
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;

                string changeUser = string.Format(@"UPDATE Users
                    SET firstName = '{0}', secondName = '{1}', lastName = '{2}',
                        idRole = {3}, idSupervisedClass = {4},
                        idClass = {5},
                        password = '{6}', phone = '{7}',
                        email = '{8}' 
                    WHERE login = '{6}'",
                    firstName,
                    secondName,
                    lastName,
                    idRole_,
                    idSupervisedClass_,
                    idClass_,
                    login,
                    password,
                    phone,
                    email);

                connection_.Open();
                SqlCommand command = new SqlCommand(changeUser, connection_);
                command.ExecuteNonQuery();
                connection_.Close();

                errorLabel.Visible = false;
                clearFields();

            }
        }

        private void clearFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            secondNameTextBox.Clear();
            loginTextBox.Clear();
            passwordTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(!canCreateOrChange())
            {
                errorLabel.Visible = true;
            } else
            {
                errorLabel.Visible = false;

                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string secondName = secondNameTextBox.Text;
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text.GetHashCode().ToString();
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;



                string insertUser = string.Format(@"INSERT Users(firstName, secondName, lastName, idRole, idSupervisedClass,
                                                    idClass, login, password, phone, email, activityStatus)
                        VALUES('{0}', '{1}', '{2}', {3}, 
                            {4}, {5}, '{6}', '{7}', '{8}', '{9}', 1)",
                    firstName,
                    secondName, 
                    lastName, 
                    idRole_,
                    idSupervisedClass_,
                    idClass_,
                    login,
                    password,
                    phone,
                    email);

                connection_.Open();
                SqlCommand command = new SqlCommand(insertUser, connection_);
                try
                {
                    command.ExecuteNonQuery();

                } catch (System.Data.SqlClient.SqlException ex) {
                    errorLabel.Visible = true;
                    connection_.Close();
                    return;
                }
                connection_.Close();

                if(isStudent_ || idRole_ == 18 || idRole_ == 20)
                {
                    string setNull = string.Format(@"UPDATE Users SET idSupervisedClass=NULL WHERE login = '{0}'", login);

                    connection_.Open();
                    SqlCommand nullCommand = new SqlCommand(setNull, connection_);
                    nullCommand.ExecuteNonQuery();
                    connection_.Close();
                } 
                if(!isStudent_)
                {
                    string setNull = string.Format(@"UPDATE Users SET idClass=NULL WHERE login = '{0}'", login);

                    connection_.Open();
                    SqlCommand nullCommand = new SqlCommand(setNull, connection_);
                    nullCommand.ExecuteNonQuery();
                    connection_.Close();
                }

                errorLabel.Visible = false;
                clearFields();

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm_.Show();
        }
    }
}
