using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{//renta 10%,afp 15,iss 15
    class Class6
    {
        public void eje1()
        {
            string nombre;
            double sueldo,iss,renta,afp;

            Console.WriteLine("nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("sueldo:");
            sueldo = System.Convert.ToDouble(Console.ReadLine());
            iss = (sueldo * 0.07);
            afp = (sueldo * 0.15);
            renta = (sueldo * 0.10);
            Console.WriteLine("descuentos");
            Console.WriteLine("isss: "+iss+"\nAFP: "+afp+"\nrenta: "+renta);
            sueldo = sueldo - iss;
            sueldo -= renta;
            sueldo -= afp;
            Console.WriteLine("sueldo: "+sueldo);

        }
    }
}
