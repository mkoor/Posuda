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
        }

        private void FormProd_Load(object sender, EventArgs e)
        {
            foreach (ProductsSet productsSet in Program.pos.ProductsSet)
            {
                flowLayoutPanelProducts.Controls.Add(new UserControlProducts(productsSet));
            }
        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
