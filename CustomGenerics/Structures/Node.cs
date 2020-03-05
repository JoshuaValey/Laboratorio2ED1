using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics.Structures
{
    public class Node<T> where T: IComparable
    {
        public Node<T> Father { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        /*public int id;
        public string name;*/
        public T Value { get; set; }
    }
}
