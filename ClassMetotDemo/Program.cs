using System;

namespace ClassMetotDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Banka Müşterilerimiz!");
			Console.WriteLine("--------------------!");

			Musteri musteri1 = new Musteri();
			musteri1.Id = 1;
			musteri1.Ad = "Berkay Kaya";
			musteri1.KrediNot = 595;
			//-neden atamıyorz
			Musteri musteri2 = new Musteri();
			musteri1.Id = 2;
			musteri2.Ad = "Engin Demiroğ";
			musteri2.KrediNot = 860;

			Musteri musteri3 = new Musteri();
			musteri1.Id = 3;

			//asdsadsadsad
			musteri3.Ad = "Ali Kefal";
			musteri3.KrediNot = 1;

			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

			foreach (var musteri in musteriler)
			{
				Console.WriteLine("Adı Soyadı: " + musteri.Ad);
				Console.WriteLine("Kredi Notu: " + musteri.KrediNot);
				Console.WriteLine("---------------");
			}

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.MusteriEkle(musteri1);
			musteriManager.MusteriSil(musteri2);
			musteriManager.MusteriGuncelle(musteri3);

		}
	}
}
