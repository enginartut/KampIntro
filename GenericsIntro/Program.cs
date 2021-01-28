using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // MyList isimler = new MyList();
            // yukarıdaki gibi eksiktir . Generik bir verit tipi tanımlanmalıdır. Class bile tanımlanabilir
            //aşağıdaki gibi olur

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Cemil");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
