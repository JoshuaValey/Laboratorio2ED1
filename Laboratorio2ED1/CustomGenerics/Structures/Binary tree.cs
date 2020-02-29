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
        public Node<T> createNode(T newValue, Node<T> father)
        {
            throw new NotImplementedException();
            Node<T> new_Node = new Node<T>();
            new_Node.father = father;
            new_Node.value = newValue;
            new_Node.Right = null;
            new_Node.Left = null;
            return new_Node;
        }

        public void insertNode(Node<T> tree, T value, Node<T> father)
        {
            //if the tree is empty
            if (tree == null)
            {
                Node<T> new_Node = createNode(value, father);
                tree = new_Node;
            }
            else //if the tree already have one or more nodes
            {
                T valueRoot = tree.value; //get the root value
                if (value < valueRoot) //if the element is smaller than root, insert left
                {
                    insertNode(tree.Left, value, tree);
                }
                else //if the element isn't smaller, insert right
                {
                    insertNode(tree.Right, value, tree);
                }
            }
        }

        public bool Searching(Node<T> tree, T value)
        {
            if(tree == null) //tree is empty
            {
                return false;
            }
            else if ((tree.value).Equals(value)) //value foung
            {
                return true;
            }
            else if (value < tree.value) //search on smaller elements
            {
                Searching(tree.Left, value);
            }
            else //search on bigger elements
            {
                Searching(tree.Right, value);
            }
        }

        public void preOrder(Node<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                Console.Write(tree.value + " - ");
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        public void inOrder(Node<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                inOrder(tree.Left);
                Console.Write(tree.value + " - ");
                inOrder(tree.Right);
            }
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
        public void postOrder(Node<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write(tree.value + " - ");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
