using System;
namespace assignment4
{
	public class MyStack<T>
	{
		private List<T> elements = new List<T>();

		public int Count()
		{
			return elements.Count;
		}

		public T Pop()
		{
			if (elements.Count == 0)
			{
				throw new InvalidOperationException("Stack is empty");
			}
			T top = elements[elements.Count - 1];
			elements.RemoveAt(elements.Count - 1);
			return top;
		}

		public void Push(T item)
		{
			elements.Add(item);
		}
	}
}

