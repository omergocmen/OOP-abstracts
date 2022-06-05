using GameProjectt.Abstracts;
using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Adapters
{
    //dışarıdan bir service kullandığımız varsayıyoruz
    public class MernisCheckServiceAdapter : ICheckService
    {
        public bool OyuncuyuDogrula(Oyuncu oyuncu)
        {
            //buraya  dış servisin gereken kullanımları yazılacak
            return true;
        }
    }
}
