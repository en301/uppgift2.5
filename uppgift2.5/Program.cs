using System;

namespace uppgift_2_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två decimaltal och ett * tecken mellan för att få reda på produkten...");
            string produkt = Console.ReadLine();
            int talindex = produkt.IndexOf("*");
            string tal1text = produkt[..talindex];
            string tal2text = produkt[(talindex+1)..];

            double tal1 = double.Parse(tal1text);
            double tal2 = double.Parse(tal2text);
            double sum = tal1 * tal2;
            Console.WriteLine("Produkten av dina tal är "+ sum +".");
            Console.ReadKey();
        }
    }
}
