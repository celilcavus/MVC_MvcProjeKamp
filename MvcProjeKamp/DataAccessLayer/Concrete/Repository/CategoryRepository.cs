using DataAccessLayer.AbstractClass;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        AppDbContext db = new AppDbContext();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            db.SaveChanges();
        }

        public void insert(Category p)
        {
            _object.Add(p);
            db.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            db.SaveChanges();  
        }
    }
}
