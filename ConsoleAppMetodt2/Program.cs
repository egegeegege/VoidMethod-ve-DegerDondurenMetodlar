using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetodt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(FarkAl(sayi1, sayi2));
            Console.WriteLine(ToplamAl(sayi1, sayi2));

            Console.ReadLine();
        }

        static int FarkAl(int s1, int s2)
        {
            int sonuc = s1 - s2;
            Console.WriteLine(sonuc);
            return sonuc;
        }

        static int ToplamAl(int s1, int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
