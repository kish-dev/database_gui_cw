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
    public partial class DeactivateForm : Form
    {

        DataRow director_;
        Form prevForm_;
        SqlConnection connection_;
        string roleName_;
        public DeactivateForm()
        {
            InitializeComponent();
        }

        public DeactivateForm(DataRow director, Form prevForm, SqlConnection connection, string roleName)
        {
            InitializeComponent();

            director_ = director;
            prevForm_ = prevForm;
            connection_ = connection;
            roleName_ = roleName;
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;

            string nullUser = string.Format(@"UPDATE Users
                    SET activityStatus = NULL
                    WHERE login = '{0}'",
                login
                );

            connection_.Open();
            SqlCommand command = new SqlCommand(nullUser, connection_);
            command.ExecuteNonQuery();
            connection_.Close();

            loginTextBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();    
            prevForm_.Show();
        }
    }
}
