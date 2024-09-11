using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteraion
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found seven! ");
                    break;
                }
            }


            for (int x = 0; x < 12; x++)
            {
                Console.WriteLine(x);
            }


            Console.ReadLine();        
        }
    }
}
