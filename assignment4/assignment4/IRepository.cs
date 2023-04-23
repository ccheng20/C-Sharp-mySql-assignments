using System;
namespace assignment4
{
	public interface IRepository<T> where T : class
	{
		T GetById(String id);
		void Add(T item);
		void Save();
		void Remove(T item);
		IEnumerable<T> GetAll();
	}
}

