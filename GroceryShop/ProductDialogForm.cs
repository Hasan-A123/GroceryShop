using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShop
{
    public partial class ProductDialogForm : Form
    {
        public ProductDialogForm()
        {
            InitializeComponent();
        }

        public Product product;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product(Convert.ToInt32(textBoxProductID.Text),
                    textBoxProductName.Text,
                    textBoxProductDescription.Text,
                    Convert.ToDecimal(textBoxProductPrice.Text),
                    Convert.ToInt32(textBoxProductStock.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
