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
            ArbolBinario arbolBinario = new ArbolBinario();
            Nodo tree = new Nodo();
            Console.WriteLine("Inserte el numero para el nodo");
            string textNum = Console.ReadLine();
            int num = Convert.ToInt32(textNum);

            tree = arbolBinario.insertNodo(tree, num);
            Console.WriteLine(tree.num);
            Console.WriteLine(tree.left);
            Console.WriteLine(tree.rigth);
            Console.ReadKey();
        }
    }
}
