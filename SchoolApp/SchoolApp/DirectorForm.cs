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
    public partial class DirectorForm : Form
    {
        DataRow director_;
        SqlConnection connection_;
        string roleName_;

        public DirectorForm()
        {
            InitializeComponent();
        }

        public DirectorForm(DataRow director, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            director_ = director;
            connection_ = connection;   
            roleName_ = roleName;   
        }

        private void navigateToScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(director_, this, connection_, roleName_);
            this.Hide();
            scheduleForm.Show();
        }

        private void navigateToAddStudentButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(director_, this, connection_, roleName_, false, true);
            this.Hide();
            addUser.Show();
        }

        private void navigateToAddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(director_, this, connection_, roleName_, false, false);
            this.Hide();
            addUser.Show();
        }

        private void navigateToMarksButton_Click(object sender, EventArgs e)
        {
            Marks marksForm = new Marks(director_, this, connection_, roleName_);
            this.Hide();    
            marksForm.Show();
        }

        private void navigateToDeactivateUserButton_Click(object sender, EventArgs e)
        {
            DeactivateForm deactivateForm = new DeactivateForm(director_, this, connection_, roleName_);
            this.Hide();
            deactivateForm.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void navigateToChangeUserButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(director_, this, connection_, roleName_, true, false);
            this.Hide();
            addUser.Show();
        }
    }
}
