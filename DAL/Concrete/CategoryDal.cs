using AutoMapper;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly IMapper _mapper;
        public CategoryDal(IMapper mapper)
        {
            _mapper = mapper;
        }
        public CategoryDTO CreateCategory(CategoryDTO category)
        {
            using(var e = new DbEntities())
            {
                if (e.Category.Any(p => p.Name ==category.Name))
                {
                    throw new Exception("Category exist.");
                }
                Category cat = _mapper.Map<Category>(category);
                e.Category.Add(cat);
                e.SaveChanges();
                return _mapper.Map<CategoryDTO>(cat);
            }
        }

        public void DeleteCategory(int id)
        {
            using (var e = new DbEntities())
            {
                var cat = e.Category.SingleOrDefault(p => p.Id == id);
                if (cat == null) return;
                e.Category.Remove(cat);
            }
        }

        public List<CategoryDTO> GetAllCategories()
        {
            using (var e = new DbEntities())
            {
                return _mapper.Map<List<CategoryDTO>>(e.Category.ToList());
            }
        }

        public CategoryDTO GetCategoryById(int id)
        {
            using (var e = new DbEntities())
            {
                Category cat = e.Category.SingleOrDefault(p => p.Id == id);
                return _mapper.Map<CategoryDTO>(cat);
            }
        }
    }
}
