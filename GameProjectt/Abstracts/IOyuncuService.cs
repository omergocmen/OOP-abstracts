using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Abstracts
{
    public interface IOyuncuService
    {
        public void OyuncuKaydet(Oyuncu oyuncu);
        public void OyuncuSil(Oyuncu oyuncu);
        public void OyuncuGüncelle(Oyuncu oyuncu);
    }
}
