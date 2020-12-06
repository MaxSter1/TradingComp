using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Unity.Resolution;
using WPFApp.ViewModels;
using Unity;

namespace WPFApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для Manage.xaml
    /// </summary>
    public partial class Manage : Window
    {
        ProductListViewModel _productListViewModel;
        CollectionViewSource _productCollection;
        public Manage(ProductListViewModel vm)
        {
            InitializeComponent();
            _productListViewModel = vm;
            DataContext = vm;
            InitializeComponent();

            _productCollection = (CollectionViewSource)(Resources["ProductCollection"]);
            _productCollection.Filter += _ProductCollection_Filter;
        }

        private void _ProductCollection_Filter(object sender, FilterEventArgs e)
        {
            var filter = txtFilter.Text;
            var product = e.Item as ProductDTO;
            if (product.Name.Contains(filter) || product.Id.ToString().Contains(filter))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            _productCollection.View.Refresh();
        }

        private void dgProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            DataGrid grid = sender as DataGrid;
            var item = (ProductDTO)grid.SelectedItem;
            var detailsViewModel = ((App)Application.Current).Container.Resolve<ProductDetailsViewModel>(new ParameterOverride("product", item));
            var productDetailsWindow = new ProductDetails(detailsViewModel);
            productDetailsWindow.ShowDialog();
            _productListViewModel.Update();
            
        }
    }
}
