using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ICategoryDal
    {
        CategoryDTO CreateCategory(CategoryDTO category);
        List<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int id);
        void DeleteCategory(int id);
    }
}
