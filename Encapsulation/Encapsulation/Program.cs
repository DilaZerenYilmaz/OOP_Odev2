namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Encapsulation Örneği");
        }
	}

	class Customer
	{
		public int Id { get; set; }

		private string _firstName;
        public string FirstName // Burada encapsulation işlemi yapıldı.
		{ 
			get { return _firstName; }
			set { _firstName = value; }
		}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
