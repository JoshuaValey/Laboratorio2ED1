using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Interfaces
{
    public interface  INotLinearDataStructureBase<T> where T: IComparable
    {
        void Insert(Node<T> actual, T value, Node<T> father);
        void Delete(Node<T> actual, T value);
        void Search(Node<T> actual, T value);
        void Order(Node<T> node);
    }
}
