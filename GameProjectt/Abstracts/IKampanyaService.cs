using GameProjectt.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt.Abstracts
{
    public interface IKampanyaService
    {
        public void KampanyaOlustur(Kampanya kampanya);
        public void KampanyaSil(Kampanya kampanya);
        public void KampanyaGüncelle(Kampanya kampanya);
    }
}
