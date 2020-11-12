using BusinessLogic.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp
{
    public partial class ProductEditForm : Form
    {
        private readonly IProductManager _productManager;
        private readonly ICategoryManager _categoryManager;
        private ProductDTO _product;
        public ProductEditForm(IProductManager productManager,ICategoryManager categoryManager,ProductDTO product)
        {
            _product = product;
            _productManager = productManager;
            _categoryManager = categoryManager;
            InitializeComponent();
            UpdateData();
        }
        private void UpdateData()
        {
            var cat = _categoryManager.GetAllCategories();
            Category.Items.AddRange(cat.Select(p => p.Name).ToArray());
            if (_product != null)
            {
                ProductId.Text = Convert.ToString(_product.Id);
                ProductId.Enabled = false;
                //Category.SelectedItem = cat.ElementAt((int)_product.CategoryId-1);
                Category.SelectedIndex = (int)_product.CategoryId - 1;
                ProductName.Text = _product.Name;
                EntryPrice.Text = Convert.ToString(_product.EntryPrice);
                SellingPrice.Text = Convert.ToString(_product.SellingPrice);
                chBoxIsLocked.Checked = _product.IsLocked;
            }
            else
            {
                ProductId.Text = "";
                ProductId.Enabled = false;
                ProductName.Text = "";
                EntryPrice.Text = "";
                SellingPrice.Text = "";
                chBoxIsLocked.Checked = false;
            }

        }

        private void ReadSaveData()
        {
            //_product.Id = Convert.ToInt64(ProductId.Text);
            if(_product == null)
            {
                _product = new ProductDTO();
            }
            _product.CategoryId = Category.SelectedIndex+1;
            _product.Name = ProductName.Text;
            _product.EntryPrice = Decimal.Parse(EntryPrice.Text.Replace('.',','));
            _product.SellingPrice = Decimal.Parse(SellingPrice.Text.Replace('.', ','));
            _product.IsLocked = chBoxIsLocked.Checked;

            _productManager.UpdateProduct(_product);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ReadSaveData();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
