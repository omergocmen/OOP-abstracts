using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Abstracts
{
    public interface ISatisService
    {
        public void OyunSat(Oyuncu oyuncu,Oyun oyun,Kampanya kampanya);
    }
}
