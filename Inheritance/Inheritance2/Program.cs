namespace Inheritance2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ucak ucak = new Ucak();
			ucak.MARKA = "Türk Hava Yolları";
			ucak.KALKIS = "Trabzon";
			ucak.VARIS = "İstanbul";
			ucak.Ad = "Dila";
			ucak.Soyad = "Yılmaz";
			ucak.Yas = 22;
			ucak.Cinsiyet = "Bayan";

			Console.WriteLine("Hava yolları: " + ucak.MARKA);
			Console.WriteLine("Kalkış yeri: " + ucak.KALKIS);
			Console.WriteLine("Varış yeri: " + ucak.VARIS);
			Console.WriteLine("Yolcu Adı: " + ucak.Ad);
			Console.WriteLine("Yolcu Soyadı: " + ucak.Soyad);
			Console.WriteLine("Yolcu yaşı: " + ucak.Yas);
			Console.WriteLine("Yolcu cinsiyeti: " + ucak.Cinsiyet);
		}
	}

	class Ucak : Yolcu
	{
		private string Marka { get; set; }
		private string Kalkis { get; set; }
		private string Varis { get; set; }

		public string MARKA
		{
			get { return Marka; }
			set { Marka = value.ToUpper(); }
		}
		public string KALKIS
		{
			get { return Kalkis; }
			set { Kalkis = value.ToLower(); }
		}
		public string VARIS
		{
			get { return Varis; }
			set { Varis = value.ToLower(); }
		}
	}

	class Yolcu
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int Yas { get; set; }
		public string Cinsiyet { get; set; }
	}
}
