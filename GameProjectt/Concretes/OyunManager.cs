using GameProjectt.Abstracts;
using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Concretes
{
    public class OyunManager : IOyunService
    {
        public void OyunGüncelle(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi+" Güncellendi");
        }

        public void OyunKaydet(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Kayedildi");
        }

        public void OyunSil(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Silindi");
        }
    }
}
