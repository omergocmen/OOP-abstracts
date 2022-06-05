using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Abstracts
{
    public interface IOyunService
    {
        public void OyunKaydet(Oyun oyun);
        public void OyunSil(Oyun oyun);
        public void OyunGüncelle(Oyun oyun);
    }
}
