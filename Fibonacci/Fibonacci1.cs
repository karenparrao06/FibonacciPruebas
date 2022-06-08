using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci1
    {
        public bool calcularFibonacci(int? numero) {
            
            if (numero <= 0 || numero > 500) return false;
            else if (numero == null) return false;

            int v1 = 0;
            int v2 = 1;

            for (int i = 0; i < numero; i++)
            {
                int temp = v1;

                v1 = v2;

                v2 = temp + v1;

                Console.WriteLine(v1);
            }

            return true;

        }
    }
}
