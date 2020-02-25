using System;
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
        Node<T> Root = new Node<T>();

        public void Node(T data)
        {
            Root.value = data;
            Root.Left = null;
            Root.Right = null;
        }

        public void Start(T data)
        {
            Root.value = data;
        }

    }
}
