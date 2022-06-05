using GameProjectt.Abstracts;
using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Concretes
{
    public class SatisManager : ISatisService
    {
        public void OyunSat(Oyuncu oyuncu, Oyun oyun, Kampanya kampanya)
        {
            Console.WriteLine(oyuncu.Ad+" "+oyuncu.Soyad+" "+oyun.OyunAdi+" Oyununu "+kampanya.KampanyaAdi+" kampanyasıyla satın aldı");
        }
    }
}
