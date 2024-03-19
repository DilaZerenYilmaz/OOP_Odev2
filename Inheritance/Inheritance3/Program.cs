namespace Inheritance3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kedi kedi = new Kedi();
			kedi.Tur = "Sokak Kedisi";
			kedi.SesCikar(); // Hayvan sınıfından miras alınan metot
			kedi.Miyavla(); // Kedi sınıfının kendi metodu

			Kopek kopek = new Kopek();
			kopek.Tur = "Golden Retriever";
			kopek.SesCikar(); // Hayvan sınıfından miras alınan metot
			kopek.Havla(); // Köpek sınıfının kendi metodu
		}
	}

	class Hayvan // Üst Sınıfımız
	{
		public string Tur { get; set; }
		public void SesCikar()
		{
			Console.WriteLine("Hayvan ses çıkarıyor.");
		}
	}

	class Kedi : Hayvan // Alt Sınıfımız (Kedi), Hayvan sınıfından kalıtım alıyor
	{
		public void Miyavla()
		{
			Console.WriteLine("Kedi miyavlıyor.");
		}
	}

	class Kopek : Hayvan // Alt Sınıfımız (Köpek), Hayvan sınıfından kalıtım alıyor
	{
		public void Havla()
		{
			Console.WriteLine("Köpek havlıyor.");
		}
	}
}
