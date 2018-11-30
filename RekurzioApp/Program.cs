using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzioApp
{
    class Program
    {
        public static int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 1; i <= n; i++)
            {
                eredmeny *= i;
            }
            return eredmeny;
        }

        public static int FaktorialisRekurziv(int n)
        {
            if (n > 0)
            {
                return n* FaktorialisRekurziv(n - 1);
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Faktorialis(5));
            Console.WriteLine(FaktorialisRekurziv(5));
            Console.ReadLine();
        }
    }
}
