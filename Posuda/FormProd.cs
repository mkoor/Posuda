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
    public partial class FormProd : Form
    {
        public FormProd()
        {
            InitializeComponent();
            
            labelTitle.Text = FormMenu.pr.title;
            labelCategory.Text = FormMenu.pr.category;
            labelCount.Text = FormMenu.pr.count;
            labelDescription.Text = FormMenu.pr.description;
            labelMaker.Text = FormMenu.pr.maker;
            labelPrice.Text = FormMenu.pr.price;
        }

        private void FormProd_Load(object sender, EventArgs e)
        {

        }
    }
}
