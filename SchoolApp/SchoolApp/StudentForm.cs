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
    public partial class StudentForm : Form
    {

        DataRow student_;
        SqlConnection connection_;
        string roleName_;

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(DataRow student, SqlConnection connection, string roleName)
        {
            InitializeComponent();
            student_ = student;
            connection_ = connection;
            roleName_ = roleName;
        }

        private void navigateToMarksAsStudentButton_Click(object sender, EventArgs e)
        {
            Marks marksForm = new Marks(student_, this, connection_, roleName_);
            this.Hide();
            marksForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void navigateToScheduleAsStudentButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(student_, this, connection_, roleName_);
            this.Hide();
            scheduleForm.Show();
        }
    }
}
