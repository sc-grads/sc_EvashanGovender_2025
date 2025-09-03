using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceConstraint
{
    internal interface IEntity
    {
        int ID { get; set; }
    }
    internal class Repository<T> where T : IEntity
    {
        private List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }
    }
}
