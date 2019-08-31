using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Class2
    {
        public void elee()
        {
            {
                double num1, num2, res;

                Console.WriteLine("ingrese un numero");
                //num1 = system.convertConsole.ReadLine();
                num1 = System.Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese otro numero");
                //num1 = system.convertConsole.ReadLine();
                num2 = System.Convert.ToDouble(Console.ReadLine());

                res = Math.Truncate((num1 + num2) * 10) / 10;

                Console.WriteLine("la suma es: " + res);
                res = Math.Truncate((num1 - num2) * 10) / 10;

                Console.WriteLine("la resta es: " + res);

                res = Math.Truncate((num1 * num2) * 10) / 10;

                Console.WriteLine("la multiplicacion es: " + res);
                if (num2 != 0)
                {
                    res = Math.Truncate((num1 / num2) * 10) / 10;
                    Console.WriteLine("la division es: " + res);
                }
                    else
                {
                    Console.WriteLine("la division entre cero no es posible");
                }
                //Console.WriteLine("la division es: " + res);
                Console.ReadKey();
            }
        }
    }
}
