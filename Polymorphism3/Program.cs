namespace Polymorphism3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			A a = new B();
			a.x = 1; //sadece x özelliğine erişebiliyoruz çünkü A classı üzerinden oluşturuldu.

			B b = (B)a; 
			b.y = 2;

		}
	}

	class A
	{
        public int x { get; set; }
    }

	class B : A
	{
        public int y { get; set; }
    }
}
