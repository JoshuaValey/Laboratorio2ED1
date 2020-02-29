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
        public Node<T> createNode(T newValue, Node<T> father)
        {
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
    }
}
