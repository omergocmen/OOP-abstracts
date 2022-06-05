using GameProjectt.Abstracts;
using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Concretes
{
    public class OyuncuManager : IOyuncuService
    {
        ICheckService CheckService;
        public OyuncuManager(ICheckService CheckService)
        {
            this.CheckService = CheckService;
        }
        public void OyuncuGüncelle(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+" "+oyuncu.Soyad+" Güncellendi");
        }

        public void OyuncuKaydet(Oyuncu oyuncu)
        {
            if (CheckService.OyuncuyuDogrula(oyuncu))
            {
                Console.WriteLine(oyuncu.Ad + " " + oyuncu.Soyad + " Başarıyla Kaydedildi");
            }
        }

        public void OyuncuSil(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " " + oyuncu.Soyad + " Silindi");
        }
    }
}
