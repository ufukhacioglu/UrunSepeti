using AdaYazilim.Context;
using AdaYazilim.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace AdaYazilim.Services
{
    public class BirinciService
    {
        private readonly DatabaseContext _context;
        private readonly Random _random;

        public BirinciService(DatabaseContext context)
        {
            _context = context;
            _random = new Random();
        }


        public List<Musteri> TestVerisiOlustur(int musteriAdet, int sepetAdet)
        {
            List<Musteri> musteriler = new List<Musteri>();

            List<Sepet> sepetler = new List<Sepet>();

            for (int i = 0; i < musteriAdet; i++)
            {
                musteriler.Add(YeniMusteriOlustur());
            }

            _context.Musteriler.AddRange(musteriler);
            _context.SaveChanges();

            for (int i = 0; i < sepetAdet; i++)
            {

                int min = 0;
                int max = musteriler.Count -1;

                var musteri = musteriler[RandomSayiOlustur(min,max)];

                sepetler.Add(SepetOlustur(musteri));
                        
            }

            _context.Sepetler.AddRange(sepetler);
            _context.SaveChanges();

            sepetler.ForEach(x => UrunEkle(x));


            return musteriler;
        }

        private void UrunEkle(Sepet sepet)
        {
            int sepettekiUrunAdedi = RandomSayiOlustur(1, 6);
            List<SepetUrun> sepetUrunleri = new List<SepetUrun>();

            for (int i = 0; i < sepettekiUrunAdedi; i++)
            {
                SepetUrun sepetUrun = new SepetUrun()
                {
                    SepetId = sepet.SepetId,
                    Tutar = _random.Next(100, 1000)
                };

                sepetUrunleri.Add(sepetUrun);
            }

            _context.SepetUrunler.AddRange(sepetUrunleri);
            _context.SaveChanges();

        }

        private Sepet SepetOlustur(Musteri musteri)
        {
            return new Sepet()
            {
                MusteriId = musteri.MusteriId
            };
            
        }

        private Musteri YeniMusteriOlustur()
        {
            return new Musteri()
            {
                Ad = MetinOlustur(5),
                Soyad = MetinOlustur(6),
                Sehir = SehirOlustur()
            };
        }

        private string SehirOlustur()
        {
            string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne", "Konya", "Antalya", "Diyarbakır", "Van", "Rize" };

            

            return sehirler[RandomSayiOlustur(0,sehirler.Length)];
        }

        private int RandomSayiOlustur(int min,int max)
        {
            return _random.Next(min, max);
        }

        private string MetinOlustur(int metinUzunlugu)
        {
            string metin = "";
            for (int i = 0; i < metinUzunlugu; i++)
            {
                metin += ((char)_random.Next('A','Z')).ToString();
            }
            return metin;
        }
    }
}
