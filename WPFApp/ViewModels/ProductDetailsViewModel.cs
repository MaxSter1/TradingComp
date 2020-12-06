using BusinessLogic.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.ViewModels
{
    public class ProductDetailsViewModel: INotifyPropertyChanged
    {
        private IProductManager _manager;
        private ICategoryManager _categoryManager;

        private ProductDTO _product;
        public ProductDTO Product
        {
            get { return _product; }
            set
            {
                _product= value;
                OnPropertyChanged(nameof(Product));
            }
        }

        public List<CategoryDTO> Categories { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public ProductDetailsViewModel(IProductManager manager,ICategoryManager categoryManager, ProductDTO product)
        {
            
            _manager = manager;
            _categoryManager = categoryManager;
            Product = product;
            Categories = _categoryManager.GetAllCategories();
        }

        public void Save()
        {
           Product= _manager.UpdateProduct(Product);
        }
    }
}
