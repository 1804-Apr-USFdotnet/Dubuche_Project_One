using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubuche.DAL.Repositories
{
    interface ICrud<T> //creating repositories that every crud operation should follow
    {

        IEnumerable<T> GetAll(); // generic entities
        T GetById(int id);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);

    }
}
