using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.Business.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        
    }
}
