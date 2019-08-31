using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class4
    { 

        public void eje1()
        {
           int numero;
            double res;
            Console.WriteLine("ingrese un numero entero positivo");
            numero = Convert.ToInt32(Console.ReadLine());

            res = Math.Sqrt(numero);
            Console.WriteLine("la raiz cuadrada de "+numero+" es: "+res);
            Console.ReadKey();
        }
        
    }
}
