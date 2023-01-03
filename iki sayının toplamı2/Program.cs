using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2 , tpl;
            Console.WriteLine("lutfen sayi giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            tpl = sayi1 + sayi2;
            Console.WriteLine("tpl=" + tpl);
            Console.ReadKey();

        }
    }
}
