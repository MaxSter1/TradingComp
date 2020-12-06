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
using WPFApp.ViewModels;

namespace WPFApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductDetails.xaml
    /// </summary>
    public partial class ProductDetails : Window
    {
        private readonly ProductDetailsViewModel _productDetailsViewModel;
        public ProductDetails(ProductDetailsViewModel vm)
        {
            DataContext = vm;
            _productDetailsViewModel = vm;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _productDetailsViewModel.Save();
            DialogResult = true;
            this.Close();
        }
    }
}
