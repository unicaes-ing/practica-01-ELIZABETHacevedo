using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion = 0;
            Console.WriteLine("ingrese una opcion o 0 para salir");
            opcion = System.Convert.ToByte(Console.ReadLine());
            do
            {
                
                switch (opcion){
                    //Console.WriteLine("ingrese una opcion");
                    case 1:
                        Class1 c = new Class1();
                        c.eje1();
                        break;
                    case 2:
                        Class3 n = new Class3();
                        n.eje1();
                        break;
                    case 3:
                        Class2 c2 = new Class2();
                        c2.elee();
                        break;
                    case 4:
                        Class4 c4 = new Class4();
                        c4.eje1();
                        break;
                    case 5:
                        Class5 c5 = new Class5();
                        c5.eje1();
                        break;
                    case 6:
                        Class6 c6 = new Class6();
                        c6.eje1();
                        break;
                    default:
                        //Console.WriteLine("saliendo");
                       // Console.ReadKey();
                        break;
            }
                Console.WriteLine("ingrese una opcion o 0 para salir");
                opcion = System.Convert.ToByte(Console.ReadLine());
            } while (opcion != 0);
            Console.ReadKey();
        }
    }
}
