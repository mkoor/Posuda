using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posuda
{
    public partial class FormAuthorization : Form
    {
        public static User users = new User();
        public struct User
        {
            public string login, password, type, lastName, firstName;
        }
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.pos.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type.ToString();
                        users.lastName = user.LastName;
                        users.firstName = user.FirstName;
                    }

                }
                if (!key)
                {
                    FormCapcha cap = new FormCapcha();
                    cap.Show();
                    this.Hide();
                }                
                else
                {
                    if (FormAuthorization.users.type == "1")
                    {
                        FormMenuAdmin menu = new FormMenuAdmin();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormMenu menu = new FormMenu();
                        menu.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
