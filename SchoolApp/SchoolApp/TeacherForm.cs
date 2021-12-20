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
    public partial class TeacherForm : Form
    {

        DataRow teacher_;
        SqlConnection connection_;
        string roleName_;
        public TeacherForm()
        {
            InitializeComponent();
        }

        public TeacherForm(DataRow teacher, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            teacher_ = teacher;
            connection_ = connection;
            roleName_ = roleName;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void navigateToMarksAsTeacherButton_Click(object sender, EventArgs e)
        {
            Marks marksForm = new Marks(teacher_, this, connection_, roleName_);
            this.Hide();
            marksForm.Show();
        }

        private void navigateToScheduleAsTeacherButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(teacher_, this, connection_, roleName_);
            this.Hide();
            scheduleForm.Show();    
        }

        private void navigateToAddMarksAsTeacherButton_Click(object sender, EventArgs e)
        {
            AddMarksForm scheduleForm = new AddMarksForm(teacher_, this, connection_, roleName_);
            this.Hide();
            scheduleForm.Show();
        }
    }
}
