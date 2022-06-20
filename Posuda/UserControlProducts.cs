using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posuda
{
    public partial class UserControlProducts : UserControl
    {
        public UserControlProducts(ProductsSet productsSet)
        {
            InitializeComponent();
            labelTitle.Text = $"{productsSet.Title}";
            labelCategory.Text = "Категория: " + $"{productsSet.CategorySet.Category}"; ;
            labelCount.Text = "Количество на складе: " + $"{productsSet.Сount}"; ;
            labelDescription.Text = $"{productsSet.Description}";
            labelMaker.Text = "Производитель: " + $"{productsSet.MakersSet.Title}";
            labelPrice.Text = $"{productsSet.Price}" + " руб.";
            if (productsSet.Photo != null) { pictureBox1.Load($"../../Resources/{productsSet.Photo}");}
            if (productsSet.Сount == 0) { BackColor = Color.Gray; button1.Enabled = false; }
        }
        public UserControlProducts()
        {
            InitializeComponent();
            labelTitle.Text = $"Название";
            labelCategory.Text = "Категория: " + $"Категория"; ;
            labelCount.Text = "Количество на складе: " + $"Количество"; ;
            labelDescription.Text = $"Описание";
            labelMaker.Text = "Производитель: " + $"Производитель";
            labelPrice.Text = $"Цена" + " руб.";
        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
