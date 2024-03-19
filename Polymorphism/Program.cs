namespace Polymorphism
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ISekil sekil = new Dikdortgen();
			CizimManager cizimManager = new CizimManager(new Dikdortgen());
			CizimManager cizimManager1 = new CizimManager(new Ucgen());
		}

		public interface ISekil
		{
			public void Draw();
		}

		public class Dikdortgen : ISekil
		{
			public void Draw()
			{
				Console.WriteLine("Dikdörtgen çizildi.");
			}
		}
		public class Ucgen : ISekil
		{
			public void Draw()
			{
				Console.WriteLine("Üçgen çizildi.");
			}
		}

		public class CizimManager
		{
			private ISekil _sekil;
            public CizimManager(ISekil sekil)
            {
                _sekil = sekil;
            }

			public void Draw()
			{
				_sekil.Draw();
			}
        }
	}
}
