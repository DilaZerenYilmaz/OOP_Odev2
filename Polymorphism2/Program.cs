namespace Polymorphism2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			Boat boat = new Boat();
			Bicycle bicycle = new Bicycle();

			Vehicle[] vehicles = { car, boat, bicycle };

			foreach (var vehicle in vehicles)
			{
				Console.WriteLine(vehicle);
			}
		}
	}

	class Vehicle
	{

	}
	class Car : Vehicle
	{
		public void Go()
		{
            Console.WriteLine("The car is moving.");
        }
	}
	class Boat : Vehicle
	{
		public void Go()
		{
			Console.WriteLine("The boat is moving.");
		}
	}
	class Bicycle : Vehicle
	{
		public void Go()
		{
			Console.WriteLine("The bicycle is moving.");
		}
	}

}
