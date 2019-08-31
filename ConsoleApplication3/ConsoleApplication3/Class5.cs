using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class5
    {
        public void eje1()
        {
            double tri1, tri2, tri3,res;
            Console.WriteLine("ingrese las ventas 1er trimestre: ");
            tri1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese las ventas 2do trimestre: ");
            tri2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese las ventas 3er trimestre: ");
            tri3 = Convert.ToDouble(Console.ReadLine());
            res = (tri1 + tri2 + tri3) / 3;
            Console.WriteLine("el promedio de ventas es: " + Math.Truncate( res*100)/100);
            Console.ReadKey();

        }
    }
}
