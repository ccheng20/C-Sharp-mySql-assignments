using System;

namespace assignment4
{
	public class GenericRepository<T> : IRepository<T> where T: Entity
	{
        private List<T> items = new List<T>(); 
		public GenericRepository()
		{
		}

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public T GetById(String id)
        {
            return items.Single(x => x.Id == id);
        }

        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            items.Remove(item);
        }

        public void Save()
        {
            // save changes to data source
        }
    }
}

