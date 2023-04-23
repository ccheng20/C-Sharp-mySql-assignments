using System;
using System.Collections;

namespace assignment4
{
	public class MyList<T> : IEnumerable<T>
	{
		private List<T> myList = new List<T>();
		public void Add(T element)
		{
			myList.Add(element);
		}

		public T Remove(int index)
		{
			if (myList.Count > index)
			{
				T ele = myList[index];
				myList.RemoveAt(index);
				return ele;
			}
			throw new InvalidOperationException("List does not have index");
		}

		public bool Contains(T element)
		{
			if (myList.Contains(element))
			{
				return true;
			}
			return false;
		}

		public void Clear()
		{
			myList.Clear();
		}

		public void InsertAt(T element, int index)
		{
			if (myList.Count > index)
			{
				myList.Insert(index, element);
			} else
			{
				throw new IndexOutOfRangeException();
			}

		}

		public void DeleteAt(int index)
		{
			if (myList.Count > index)
			{
				myList.RemoveAt(index);
			} else
			{
				throw new IndexOutOfRangeException();
			}
		}

		public T Find(int index)
		{
			if (index < 0 || index >= myList.Count)
			{
				throw new IndexOutOfRangeException();
			}
			return myList[index];
		}

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)myList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)myList).GetEnumerator();
        }
    }
}

