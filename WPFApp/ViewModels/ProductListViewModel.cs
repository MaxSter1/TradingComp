using BusinessLogic.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.ViewModels
{
    public class ProductListViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private IProductManager _manager;
        private ObservableCollection<ProductDTO> _productList;
        public ObservableCollection<ProductDTO> ProductList
        {
            get { return _productList; }
            set
            {
                _productList = value;
                OnPropertyChanged(nameof(ProductList));
            }
        }

        public ProductListViewModel(IProductManager manager)
        {
            _manager = manager;
            Update();
        }

        public void Update()
        {
            var products = _manager.GetAllProducts();
            ProductList = new ObservableCollection<ProductDTO>(products);
        }
    }
}
