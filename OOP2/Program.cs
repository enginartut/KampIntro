using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin Demiroğ";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


        }
    }
}
