using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Interfaces;
using CustomGenerics.Structures;

namespace CustomGenerics.Structures
{
    class Binary_tree<T> : NotLinearDataStructureBase<T>, IEnumerable<T>
    {
        protected override void Add(Node<T> actual, Node<T> a_insert)
        {
            //cuando es mayor
            if (a_insert.id > actual.id)
            {
                if (actual.Right == null)
                {
                    actual.Right = a_insert;
                }
                else
                {
                    Add(actual.Right, a_insert);
                }
            }

            //cuando es menor 
            else
            {
                if (actual.Left == null)
                {
                    actual.Left = a_insert;
                }
                else
                {
                    Add(actual.Left, a_insert);
                }
            }
        }

        protected override T Delete(T value)
        {
            //decidir si se desea unir por izquierda, derecha o volver a insertar al arbol y se ordenaria bien
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
