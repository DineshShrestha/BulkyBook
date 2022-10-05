using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Add(Category obj);
        void Update(Category obj);

        void Save();
        IEnumerable<Category> GetAll();
        object GetFirstOrDefault(Func<Category, bool> value);
        void Remove(object obj);
        object FirstOrDefault(Func<object, bool> value);
    }
}
