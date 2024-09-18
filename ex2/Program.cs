using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {   //編寫一個名為table9to9的函式，它打印出九九乘法表的內容。
        static void Main(string[] args)
        {
            table9to9();
        }
        static void table9to9()
        {
            Console.WriteLine("九九乘法表的內容");
            for (int i = 1; i <= 9;i++)
            { 
                for (int j = 1; j <= 9; j++) 
                {
                    Console.WriteLine( i*j);
                }
                
            }
            Console.ReadKey();
        }
    }
}
