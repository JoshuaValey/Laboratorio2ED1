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
    class Binary_tree<T> : INotLinearDataStructureBase<T>, IEnumerable<T>
    {
        //delegates declaration
        //delete methots
        //eliminar
        delegate bool ValueIsThan(Node<T> actual, T value);

    private void Eliminar(Node<T> actual, T value, ValueIsThan valueIsLess, 
        ValueIsThan valueIsGreater, ValueIsThan valueIsEqual)
        {
            if (actual == null)
            {
                return;
            }
            else if (valueIsLess(actual, value))
            {
                Eliminar(actual.Left, value, 
                    valueIsLess,valueIsGreater, valueIsEqual);
            }
            else if (valueIsGreater(actual, value))
            {
                Eliminar(actual.Right, value,
                    valueIsLess, valueIsGreater, valueIsEqual);
            }
            else if (valueIsEqual(actual, value))
            {
                //deleteNode();
                throw new NotImplementedException();
            }
        }









        public void Insert(Node<T> actual, T value, Node<T> father)
        {
            throw new NotImplementedException();
        }

        public void Order(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public void Search(Node<T> actual, T value)
        {
            throw new NotImplementedException();
        }

        public void Delete(Node<T> actual, T value)
        {
            throw new NotImplementedException();
        }

       















































        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
