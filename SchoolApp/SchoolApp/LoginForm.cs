using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
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
    public partial class LoginForm : Form
    {
        public const string DIRECTOR_ROLE= "Директор";
        public const string CLASSROOM_TEACHER = "Классный руководитель";
        public const string TEACHER_ROLE= "Учитель";
        public const string STUDENT_ROLE= "Ученик";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-MIP6BU6;Initial Catalog=CoursePt;Integrated Security=True;
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
            var password = passwordTextBox.Text.Trim();

            //hash password
            var hashedPassword = password.GetHashCode();

            string query = "SELECT * FROM Users JOIN Roles as r ON Users.idRole = r.idRole WHERE login = '" + loginTextBox.Text.Trim() +
                "' AND password = '" + hashedPassword +
                "' AND activityStatus = 1";


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); 

            if(dataTable.Rows.Count == 1)
            {
                string roleName = (string)dataTable.Rows[0]["roleName"];
                if(roleName.Equals(DIRECTOR_ROLE)) {
                    DirectorForm directorForm = new DirectorForm(dataTable.Rows[0], sqlConnection, roleName);
                    this.Hide();
                    directorForm.Show();
                } else if(roleName.Equals(CLASSROOM_TEACHER))
                {
                    ClassroomTeacher classroomTeacher = new ClassroomTeacher(dataTable.Rows[0], sqlConnection,roleName);
                    this.Hide();
                    classroomTeacher.Show();
                } else if (roleName.Equals(TEACHER_ROLE))
                {
                    TeacherForm teacherForm = new TeacherForm(dataTable.Rows[0], sqlConnection, roleName);
                    this.Hide();
                    teacherForm.Show();
;                } else if(roleName.Equals(STUDENT_ROLE))
                {
                    StudentForm studentForm = new StudentForm(dataTable.Rows[0], sqlConnection, roleName);
                    this.Hide();
                    studentForm.Show();
                }

            }
        }
    }
}
