using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Kullanicilar(sayi1,sayi2);
        }
        static void Kullanicilar(int s1,int s2)
        {
            if (s1 < s2)
            {
                Console.WriteLine("girdiğiniz 1. sayı 2. sayıdan küçük");
            }
            else if (s1 > s2)
            {
                Console.WriteLine("girdiğiniz 2. sayı 1. sayıdan küçük");
            }
            else
            {
                Console.WriteLine("girdiğiniz iki sayıda birbirine eşit");
            }

            Console.ReadLine();
        }
    }



}
