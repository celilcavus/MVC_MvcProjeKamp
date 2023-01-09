using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> ct = new GenericRepository<Category>();
        public List<Category> GetList()
        {
            return ct.List();
        }
        public void Insert(Category value)
        {
            if (value.CategoryName == "" || value.CategoryName.Length <= 3 
             || value.CategoryDescription == "" || value.CategoryName.Length >= 5)
            {
                    
            }
            else
            {
                ct.insert(value);
            }
           
        }
        public void Delete(Category value)
        {
            ct.Delete(value);
        }
        public void Update(Category value)
        {
            ct.Update(value);
        }
    }
}
