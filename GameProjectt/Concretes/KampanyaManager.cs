using GameProjectt.Abstracts;
using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Concretes
{
    public class KampanyaManager : IKampanyaService
    {
        public void KampanyaGüncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi+" Güncellendi");
        }

        public void KampanyaOlustur(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " Oluşturuldu");
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " Silindi");
        }
    }
}
