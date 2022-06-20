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
    public partial class FormMenu : Form
    {
        public static Products pr = new Products();
        public struct Products
        {
            public string title, description, count, category, price, maker;

        }

        void Pr()
        {
            foreach (ProductsSet productsSet in Program.pos.ProductsSet)
            {
                pr.title = productsSet.Title;
                pr.price = productsSet.Price.ToString();
                pr.maker = productsSet.MakersSet.Title;
                pr.description = productsSet.Description;
                pr.count = productsSet.Сount.ToString();
                pr.category = productsSet.CategorySet.Category;          

            }
        }

        public FormMenu()
        {
            InitializeComponent();
            Pr();
            if (FormAuthorization.users.type == "2")
            {
                labelHello.Text = FormAuthorization.users.lastName + " " + 
                    FormAuthorization.users.firstName + " - Менеджер";
            }
            if (FormAuthorization.users.type == "3")
            {
                labelHello.Text = FormAuthorization.users.lastName + " " +
                    FormAuthorization.users.firstName + " - Клиент";
            }
            labelHello.ForeColor = Color.Blue;
            ShowProducts();
        }

        void ShowProducts()
        {
            listViewProducts.Items.Clear();
            foreach (ProductsSet productsSet in Program.pos.ProductsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   productsSet.Id.ToString(), productsSet.Title,productsSet.CategorySet.Category,
                   productsSet.Price.ToString(), productsSet.Description,
                   productsSet.Сount.ToString(), productsSet.MakersSet.Title,
                });
                item.Tag = productsSet;
                listViewProducts.Items.Add(item);
            }
            listViewProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization auto = new FormAuthorization();
            auto.Show();
            this.Hide();
        }

        private void listViewManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem = listViewProducts.FindItemWithText(textBoxSearch.Text, true, 0, true);
            if (foundItem != null)
            {
                listViewProducts.TopItem = foundItem;
                foundItem.BackColor = SystemColors.Control;
            }
        }

        private void listViewProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                FormProd prod = new FormProd();
                prod.Show();
            }
        }
    }
}
