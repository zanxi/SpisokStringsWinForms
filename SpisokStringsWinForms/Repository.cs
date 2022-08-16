using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisokStringsWinForms
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {

        public void Create(T entity)

        {

            

        }

        public void Delete(T entity)

        {

            

        }

        public T GetById(long id)

        {

            
            throw new NotImplementedException();

        }

        public void Update(T entity)

        {

            

        }

    }
}
