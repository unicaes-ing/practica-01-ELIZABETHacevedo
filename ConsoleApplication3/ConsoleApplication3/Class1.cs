using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class1
    {
        //static void Main(string[] args)
        //{
        public void eje1()
        {
            string nombre = "mario", cargo = "empleado";
            int edad = 23, dia = 23, mes = 2, annio = 2017;
            double sueldo = 1200.00;

            Console.WriteLine("nombre {0} edad {1} cargo {2} sueldo {3}", nombre, edad, cargo, sueldo);

            DateTime thisDate1 = new DateTime(annio, mes, dia);
            Console.WriteLine("fecha de contratacion " + thisDate1.ToString("MMMM dd, yyyy") + ".");
            Console.ReadKey();
        }
       // }
    }
}
