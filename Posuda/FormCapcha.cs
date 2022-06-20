using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Posuda
{
    public partial class FormCapcha : Form
    {
        string ENG = "ASDFGHJKLQWERTYUIOPZXCVBNM1234567890";
        string captch;
        Random rnd = new Random();
        List<char> letters = new List<char>();

        public FormCapcha()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                letters.Add(ENG[rnd.Next(0, ENG.Length - 1)]);
                captch = String.Join("", letters);
                label2.Text = captch;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == textBox1.Text)
            {
                MessageBox.Show("Верно!");
                FormAuthorization auto = new FormAuthorization();
                auto.Show();
                this.Hide();
                Thread.Sleep(5000);
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void FormCapcha_Load(object sender, EventArgs e)
        {
            
        }
    }
}
