using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository
    {
        void Add(CoverType obj);
        void Update(CoverType obj);

        void Save();
        IEnumerable<CoverType> GetAll();
        object GetFirstOrDefault(Func<CoverType, bool> value);
        void Remove(object obj);
        object FirstOrDefault(Func<object, bool> value);
    }
}
