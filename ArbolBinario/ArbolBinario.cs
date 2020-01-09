using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class ArbolBinario
    {

        public Nodo root;
        
        //public ArbolBinario(){
        //    this.root = null;
        //}

        public Nodo createNodo(int num)
        {

            Nodo new_nodo = new Nodo();

            new_nodo.num = num;
            new_nodo.rigth = null;
            new_nodo.left = null;

            return new_nodo;
        }

        public Nodo insertNodo(Nodo tree, int num)
        {
            if(tree == null)
            {
                Nodo new_root = createNodo(num);
                tree = new_root;
            }
            else
            {
                int rootValue = tree.num;

                if( num < rootValue)
                {
                    tree.left = insertNodo(tree.left, num);
                }
                else
                {
                    tree.rigth = insertNodo(tree.rigth, num);
                }

            }

            return tree;
        }

        public void showTree(Nodo tree, int cont)
        {
            if( tree == null)
            {
                return;
            }
            else
            {
                showTree( tree.rigth, cont + 1);
                for(int i=0; i < cont; i++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine(tree.num);
                showTree(tree.left, cont + 1);
            }
        }

        public Nodo LCA(Nodo root, Nodo nodo1, Nodo nodo2)
        {
            if( root == null)
            {
                return null;
            }

            if ( root == nodo1 || root == nodo2 )
            {
                return root;
            }

            Nodo left = LCA( root.left, nodo1, nodo2 );
            Nodo rigth = LCA( root.rigth, nodo1, nodo2 );

            if( left != null && rigth != null)
            {
                return root;
            }

            return (left != null) ? left : rigth;
        }

        public Nodo findNodo(Nodo tree, int node)
        {
            if( tree == null)
            {
                return null;
            }
            else if( node < tree.num )
            {
                return findNodo(tree.left, node);
            }
            else if ( node > tree.num )
            {
                return findNodo(tree.rigth, node);
            }
            else
            {
                return tree;
            }

        }
    }
}
