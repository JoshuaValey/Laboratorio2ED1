using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Interfaces
{
    public abstract class NotLinearDataStructureBase<T>
    {
        //ponerla como interfaz y agregarle metodos
        public void insertNode(Node<T> tree, T value, Node<T> father);
    }
}
