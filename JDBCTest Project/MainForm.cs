using Assign_07.Models.DataLayer;

namespace Assign_07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                lstProducts.DataSource = null;
                lstProducts.DataSource = ProductDB.GetProducts();
                lstProducts.Font = new Font("Consolas", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddModifyProductForm form = new AddModifyProductForm();
            form.IsAdd = true;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is not Product selectedProduct)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            AddModifyProductForm form = new AddModifyProductForm();
            form.IsAdd = false;
            form.Product = selectedProduct;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is not Product selectedProduct)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                bool removed = ProductDB.DeleteProduct(selectedProduct);
                if (!removed)
                    MessageBox.Show("Cannot delete product with related incidents or registrations.");
                else
                    LoadProducts();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}