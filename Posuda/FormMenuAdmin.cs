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

namespace Posuda
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            textBoxLogin.Text = FormAuthorization.users.login;
            textBoxPassword.Text = FormAuthorization.users.password;
            textBoxFirstName.Text = FormAuthorization.users.firstName;
            textBoxLastName.Text = FormAuthorization.users.lastName;
        }
       

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization auto = new FormAuthorization();
            auto.Show();
            this.Hide();
        }
    }
}
