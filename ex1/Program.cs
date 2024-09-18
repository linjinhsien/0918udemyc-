using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//編寫一個名為“printEvery3()”的函式，它打印出等差數列 1, 4, 7, …, 88。
//printEvery3();
// 1
// 4
// ... 
// 88
namespace ex1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
          
            printEvery3();

        }

        static void printEvery3()
        {
            Console.WriteLine("等差數列 1, 4, 7, …, 88");
            for (int i = 1; i <= 88; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
