using AdaYazilim.Context;
using AdaYazilim.DTOs;
using AdaYazilim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdaYazilim.Services
{
    public class IkinciService
    {
        private readonly DatabaseContext _context;
        public IkinciService(DatabaseContext context)
        {
            _context = context;
        }

        public List<DtoSehirAnaliz> AnalizYap()
        {
            return _context.Musteriler
                                    .Include(x => x.Sepetler)
                                    .ThenInclude(x => x.SepetUrunler)
                                    .ToList()
                                    .GroupBy(x=>x.Sehir)
                                    .Select(x=> Metot(x))
                                    .OrderByDescending(x=>x.SepetAdet)
                                    .ToList();
        }

        private DtoSehirAnaliz Metot(IGrouping<string, Musteri> x)
        {
            var musteriListesi = x.ToList();

            int toplamSepetAdedi = musteriListesi.Sum(x => x.Sepetler.Count);

            int toplamSepetTutari = (int)musteriListesi.SelectMany(x => x.Sepetler).SelectMany(x => x.SepetUrunler).Sum(x => x.Tutar);


            return new DtoSehirAnaliz
            {
                SehirAdi = x.Key,
                SepetAdet = toplamSepetAdedi,
                ToplamTutar = toplamSepetTutari

            };
        }
    }
}
