//Beni Yaratn Elbet Yolumu Gösterir .Şuara78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char deger;
            deger = 'r';
            char value;

            Console.WriteLine("Your character:" + " " + deger);
            Console.WriteLine("Another Example:");
            Console.WriteLine();
            Console.WriteLine("Please enter character:");
            value = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your entried character is:"+" "+value);
            Console.Read();


            
        }


    }
}
