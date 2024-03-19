namespace GenericType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GenericList<int> intList = new GenericList<int>();
			intList.Add(42);
			intList.Add(10);
			intList.PrintItems();

			GenericList<string> stringList = new GenericList<string>();
			stringList.Add("Merhaba");
			stringList.Add("Dünya");
			stringList.PrintItems();
		}
	}

	public class GenericList<T>
	{
		private T[] items;
		private int count;

		public GenericList()
		{
			items = new T[10];
			count = 0;
		}

		public void Add(T item)
		{
			if (count < items.Length)
			{
				items[count] = item;
				count++;
			}
			else
			{
				Console.WriteLine("Liste dolu!");
			}
		}
		public void PrintItems()
		{
			Console.Write("Liste içeriği: ");
			for (int i = 0; i < count; i++)
			{
				Console.Write(items[i] + " ");
			}
			Console.WriteLine();
		}
	}

}
