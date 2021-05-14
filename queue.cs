using System;

namespace pr6
{
	interface IQueue
	{
		void Enqueue(object item);
		object Dequeue();
		object Peek();
	}
	
	class Queue : IQueue
	{
		public int count;
		public int Count 
		{
			get
			{
				return count;
			}
		}
		object[] data;
		
		public Queue()
		{
			data = null;
			count = 0;
		}
		
		public void Enqueue(object item)
		{
			if(data != null)
			{
				object[] temp;
				temp = new object[data.Length];
				
				for(int i = 0; i < data.Length; i++)
				{
					temp[i] = data[i];
				}
				
				data = new object[data.Length + 1];
				
				for(int i = 0; i < temp.Length; i++)
				{
					data[i] = temp[i];
				}
					
			}
			else
			{
				data = new object[1];
			}
			
			data[data.Length - 1] = item;
			count++;
			
		}
		
		public object Dequeue()
		{
			object item = null;
			
			if(data != null)
			{
				item = data[0];
					
				object[] temp;
				temp = new object[data.Length];
				
				for(int i = 0; i < data.Length; i++)
				{
					temp[i] = data[i];
				}
				
				
				data = new object[data.Length - 1];
				
				for(int i = 1; i < temp.Length; i++)
				{
					data[i - 1] = temp[i];
				}
					
			}
			count--;
			return item;
		}
		
		public object Peek()
		{
			object item = null;
			if(data != null)
			{
				item = data[0];
			}
			return item;
		}
	}

  internal class NewBaseType
  {
    public static void Main(string[] args)
    {

      Queue queue;
      queue = new Queue();
      queue.Enqueue(23);
      queue.Enqueue(45);

      object obj = queue.Peek();
      Console.WriteLine(obj);

      obj = queue.Dequeue();
      Console.WriteLine(obj);

      Console.WriteLine(queue.Count);

      Console.Write("Press any key to continue . . . ");
      Console.ReadKey(true);
    }
  }

  class Program : NewBaseType
  {
  }
}