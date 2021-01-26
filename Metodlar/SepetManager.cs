using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)// İmza
        {
            Console.WriteLine("Terikler Sepete Eklendi : " + urun.Adi);
            
        }

        //kullanılmaması gereken mehtod yazımı
        public void Ekle2(string urundAdi,string aciklama, double fiyati,int stokAdeti) 
        {
            Console.WriteLine("Tebrikler sepete eklendi : "+ urundAdi);
        }

    }
}
