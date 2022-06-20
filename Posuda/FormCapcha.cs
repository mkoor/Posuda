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
        public string text;
        public FormCapcha()
        {
            InitializeComponent();
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

                //Создадим изображение
                Bitmap result = new Bitmap(Width, Height);

                //Вычислим позицию текста
                int Xpos = 10;
                int Ypos = 10;

                //Добавим различные цвета ддя текста
                Brush[] colors = {
Brushes.Black,
};

                //Добавим различные цвета линий
                Pen[] colorpens = {
Pens.Black,
};

                //Делаем случайный стиль текста
                FontStyle[] fontstyle = {
FontStyle.Italic,
};

                //Добавим различные углы поворота текста
                Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

                //Укажем где рисовать
                Graphics g = Graphics.FromImage((Image)result);



                //Делаем случайный угол поворота текста
                g.RotateTransform(rnd.Next(rotate.Length));

                //Генерируем текст
                text = String.Empty;
                string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
                for (int i = 0; i < 5; ++i)
                    text += ALF[rnd.Next(ALF.Length)];

                //Нарисуем сгенирируемый текст
                g.DrawString(text,
                new Font("Arial", 15, fontstyle[rnd.Next(fontstyle.Length)]),
                colors[rnd.Next(colors.Length)],
                new PointF(Xpos, Ypos));

                //Добавим немного помех
                //Линии из углов
                g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                new Point(0, 0),
                new Point(Width - 1, Height - 1));

                return result;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == this.text)
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
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
