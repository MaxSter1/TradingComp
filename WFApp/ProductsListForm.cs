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
    public partial class ProductsListForm : Form
    {
        private readonly IProductManager _productManager;
        private readonly ICategoryManager _categoryManager;
        private List<ProductDTO> _products;
        public ProductsListForm(IProductManager productManager, ICategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            InitializeComponent();
            UpdateData();
            toolCategoryComboBox.ComboBox.Items.Add("All");
            toolCategoryComboBox.Items.AddRange(_categoryManager.GetAllCategories().Select(p => p.Name).ToArray());
            toolCategoryComboBox.SelectedIndex = 0;
        }
        private void UpdateData(List<ProductDTO> productList = null)
        {
            if(productList == null)
            {
                productList = _productManager.GetAllProducts();
            }
            _products = productList;
            
            var blProducts = new BindingList<ProductDTO>(productList);

            bsProducts.DataSource = blProducts;
            bnProducts.BindingSource = bsProducts;
            dgvProducts.DataSource = bsProducts;

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ProductEditForm edit = new ProductEditForm(_productManager, _categoryManager, null);
            edit.Show();
            UpdateData();
        }

        private void dgvProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductEditForm edit = new ProductEditForm(_productManager, _categoryManager, _products[e.RowIndex]);
            if(edit.ShowDialog() == DialogResult.OK)
            {
                toolCategoryComboBox.SelectedIndex = 0;
                UpdateData();
            }
        }

        private void toolCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolCategoryComboBox.SelectedIndex == 0)
            {
                UpdateData();
                return;
            }
            UpdateData(_productManager.GetAllProducts().Where(p => p.CategoryId == toolCategoryComboBox.SelectedIndex).ToList());

        }
    }
}
