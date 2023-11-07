using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	internal class MusteriManager
	{
		public void MusteriEkle(Musteri musteri)
		{
			Console.WriteLine("Müsteri Eklendi: " + musteri.Ad);
		}
		public void MusteriSil(Musteri musteri)
		{
			Console.WriteLine("Müsteri Silindi: " + musteri.Ad);
		}
		public void MusteriGuncelle(Musteri musteri)
		{
			Console.WriteLine("Müsteri Güncellendi: " + musteri.Ad);
		}
	}
}
