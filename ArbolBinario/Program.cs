using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int num;

            ArbolBinario arbolBinario = new ArbolBinario();
            Nodo tree = null;
            do
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("1.insertar nodo \n2.Imprimir \n3.Salir");

                text = Console.ReadLine();


                switch (text)
                {
                    case "1":
                        Console.WriteLine("\n==========================\nInserte el numero para el nodo");
                        num = Convert.ToInt32(Console.ReadLine());
                        tree = arbolBinario.insertNodo(tree, num);
                        break;

                    case "2":
                        Console.WriteLine("\n==========================\nNodo imprimido\n\n");
                        arbolBinario.showTree(tree, 0);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }

            } while (text != "3");

        }
    }
}
