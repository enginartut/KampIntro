﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Tartar";
            kurs2.IzlenmeOrani = 72;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Cemil Meriç";
            kurs3.IzlenmeOrani = 58;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Cem Yılmaz";
            kurs4.IzlenmeOrani = 48;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " +kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
