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
    public partial class ClassroomTeacher : Form
    {
        DataRow classroomTeacher_;
        SqlConnection connection_;
        string roleName_;
        public ClassroomTeacher()
        {
            InitializeComponent();
        }

        public ClassroomTeacher(DataRow classroomTeacher, SqlConnection connection, string rolenName)
        {
            InitializeComponent();
            classroomTeacher_ = classroomTeacher;
            connection_ = connection;
            roleName_ = rolenName;  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void navigateToMarkAsClassroomTeacherButton_Click(object sender, EventArgs e)
        {
            Marks marksForm = new Marks(classroomTeacher_, this, connection_, roleName_);
            this.Hide();
            marksForm.Show();
        }

        private void navigateToScheduleAsClassroomTeacherButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(classroomTeacher_, this, connection_, roleName_);
            this.Hide();
            scheduleForm.Show();
        }

        private void navigateToAddMarksAsClassroomTeacherButton_Click(object sender, EventArgs e)
        {
            AddMarksForm addMarksForm = new AddMarksForm(classroomTeacher_, this, connection_, roleName_);
            this.Hide();
            addMarksForm.Show();
        }
    }
}
