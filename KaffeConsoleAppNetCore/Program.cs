using kaffe;
using System;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            FlatWhite FW = new FlatWhite();
            Cortado C = new Cortado();
            Latte L = new Latte();
            SortKaffe SK = new SortKaffe();

            Console.WriteLine("");
            Console.WriteLine("en " + FW.Navn());
            Console.WriteLine("-----------------");
            Console.WriteLine("Styrke " + FW.Styrke());
            Console.WriteLine("Indeholer " + FW.MlMælk() + "Ml Mælk");
            Console.WriteLine("Koster " + FW.Pris() + " Dkk");

            Console.WriteLine("");
            Console.WriteLine("en " + C.Navn());
            Console.WriteLine("-----------------");
            Console.WriteLine("Styrke " + C.Styrke());
            Console.WriteLine("Indeholer " + C.MlMælk() + "Ml Mælk");
            Console.WriteLine("Koster " + C.Pris() + " Dkk");





            Console.ReadLine();
        }
    }
}
