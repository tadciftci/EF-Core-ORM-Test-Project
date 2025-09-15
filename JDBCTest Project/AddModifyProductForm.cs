using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assign_07.Models.DataLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Assign_07
{
    public partial class AddModifyProductForm : Form
    {
        public bool IsAdd { get; set; }
        public Product? Product { get; set; }

        public AddModifyProductForm()
        {
            InitializeComponent();
        }

        private void AddModifyProductForm_Load(object sender, EventArgs e)
        {
            if (!IsAdd && Product != null)
            {
                txtCode.Text = Product.ProductCode;
                txtName.Text = Product.Name;
                txtVersion.Text = Product.Version.ToString();
                txtReleaseDate.Text = Product.ReleaseDate.ToShortDateString();
                txtCode.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                if (IsAdd)
                {
                    var newProduct = new Product
                    {
                        ProductCode = txtCode.Text,
                        Name = txtName.Text,
                        ReleaseDate = DateTime.Parse(txtReleaseDate.Text),
                        Version = Decimal.Parse(txtVersion.Text)
                    };
                    ProductDB.AddProduct(newProduct);
                }
                else if (Product != null)
                {
                    Product.Name = txtName.Text;
                    Product.ReleaseDate = DateTime.Parse(txtReleaseDate.Text);
                    Product.Version = Decimal.Parse(txtVersion.Text);
                    ProductDB.UpdateProduct(Product);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (txtCode.Text.Length == 0 || txtCode.Text.Length > 10)
            {
                MessageBox.Show("Product Code must be 1-10 characters.");
                return false;
            }

            if (txtName.Text.Length == 0 || txtName.Text.Length > 50)
            {
                MessageBox.Show("Name must be 1-50 characters.");
                return false;
            }

            if (!DateTime.TryParse(txtReleaseDate.Text, out var date) ||
                date < new DateTime(1, 1, 1) || date > new DateTime(9999, 12, 31))
            {
                MessageBox.Show("Release date must be a valid date between 01/01/0001 and 12/31/9999.");
                return false;
            }

            if (!Decimal.TryParse(txtVersion.Text, out decimal version) || version < 0)
            {
                MessageBox.Show("Please enter a valid release date.");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
