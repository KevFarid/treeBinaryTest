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
                Console.WriteLine("1.insertar nodo \n2.Imprimir \n3.Lowest Common Ancestor \n4.Salir");

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
                    case "3":
                        Console.WriteLine("\n==========================\nLowest Common Ancestor");

                        int nodo1;
                        int nodo2;
                        Nodo nodoAncestor;

                        Console.WriteLine("Escriba el par de nodo que quiera buscar");
                        Console.WriteLine("Escriba el nodo 1");
                        nodo1 = Convert.ToInt32( Console.ReadLine() );
                        
                        Console.WriteLine("Escriba el nodo 2");
                        nodo2 = Convert.ToInt32( Console.ReadLine() );

                        nodoAncestor = arbolBinario.LCA(tree, arbolBinario.findNodo(tree, nodo1), arbolBinario.findNodo(tree, nodo2));

                        Console.WriteLine( "Ancestor{" + nodo1 + ", " + nodo2 + "} = " + nodoAncestor.num);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }

            } while (text != "4");

        }
    }
}
