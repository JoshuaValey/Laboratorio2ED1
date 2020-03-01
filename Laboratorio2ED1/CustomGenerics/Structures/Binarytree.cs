﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Interfaces;
using CustomGenerics.Structures;

namespace CustomGenerics.Structures
{
    public class Binary_tree<T> : INotLinearDataStructureBase<T>, IEnumerable<T>
    {

        #region methods and delegates 
        public delegate bool ValueIsThan(Node<T> actual, T value);
        public delegate bool ReplaceDelegate(Node<T> actual, Node<T> newNode);
        public delegate int Compare(T value, T value2);


        public Node<T> createNode(T newValue, Node<T> father)
        {
           
            Node<T> new_Node = new Node<T>();
            new_Node.Father = father;
            new_Node.Value = newValue;
            new_Node.Right = null;
            new_Node.Left = null;
            return new_Node;
        }

        public void insertNode(Node<T> tree, T value, Node<T> father, Compare function)
        {
            //if the tree is empty
            if (tree == null)
            {
                Node<T> new_Node = createNode(value, father);
                tree = new_Node;
            }
            else //if the tree already have one or more nodes
            {
                T valueRoot = tree.Value; //get the root value
                if (function(value,valueRoot)<0) //if the element is smaller than root, insert left
                {
                    insertNode(tree.Left, value, tree, function);
                }
                else //if the element isn't smaller, insert right
                {
                    insertNode(tree.Right, value, tree, function);
                }
            }
        }

        public bool Searching(Node<T> tree, T value, Compare function)
        {
            bool x = false;
            if (tree == null) //tree is empty
            {
                x = false;
            }
            else if (function(value,tree.Value)==0) //value found
            {
                x = true;
            }
            else if (function(value, tree.Value)<0) //search on smaller elements
            {
                Searching(tree.Left, value, function);
            }
            else if(function(value,tree.Value)>0)//search on bigger elements
            {
                Searching(tree.Right, value, function);
            }
            return x;
        }

        public void preOrder(Node<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                Console.Write(tree.Value + " - ");
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
                Console.Write(tree.Value + " - ");
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
                Console.Write(tree.Value + " - ");
            }
        }


        //Delete methods
        public void Delete(Node<T> actual, T value, ValueIsThan valueIsLess,
            ValueIsThan valueIsGreater, ValueIsThan valueIsEqual, 
            ReplaceDelegate replaceDelegateLeft = null,
            ReplaceDelegate replaceDelegateRight = null)
        {
            if (actual == null)
            {
                return;
            }
            else if (valueIsLess(actual, value))
            {
                Delete(actual.Left, value,
                    valueIsLess, valueIsGreater, valueIsEqual);
            }
            else if (valueIsGreater(actual, value))
            {
                Delete(actual.Right, value,
                    valueIsLess, valueIsGreater, valueIsEqual);
            }
            else if (valueIsEqual(actual, value))
            {
                DeleteNode(actual, replaceDelegateLeft, replaceDelegateRight);
                throw new NotImplementedException();
            }
        }

        private void DeleteNode(Node<T> nodeToDelete,
            ReplaceDelegate replaceDelegateLeft,
            ReplaceDelegate replaceDelegateRight)
        {
            //Delete if it has both
            if (nodeToDelete.Left != null && nodeToDelete.Right != null)
            {
                Node<T> lefter = ToLeft(nodeToDelete.Right);
                nodeToDelete.Value = lefter.Value;
                DeleteNode(lefter, replaceDelegateLeft, replaceDelegateRight);
            }                     
            #region Eliminar el nodo si tiene solo uno de sus dos hijos
            //Delete if it has a left node
            else if (nodeToDelete.Left != null)
            {
                Replace(nodeToDelete, nodeToDelete.Left, replaceDelegateLeft, replaceDelegateRight);
                KillNode(nodeToDelete);
            }
            else if (nodeToDelete.Right != null)
            {
                Replace(nodeToDelete, nodeToDelete.Right, replaceDelegateLeft, replaceDelegateRight);
                KillNode(nodeToDelete);
            }
            #endregion
            //It is at the end of the binary tree
            else
            {
                Replace(nodeToDelete, null, replaceDelegateLeft, replaceDelegateRight);
                KillNode(nodeToDelete);
            }
        }

        private void KillNode(Node<T> nodeToDelete)
        {
            nodeToDelete.Right = null;
            nodeToDelete.Left = null;
            nodeToDelete.Father = null;
        }

        private void Replace(Node<T> actual, Node<T> newNode, 
            ReplaceDelegate replaceDelegateLeft, 
            ReplaceDelegate replaceDelegateRight)
        {
            if (actual.Father != null)
            {
                //arbol->value == arbol->father->izq->value
                if (replaceDelegateLeft(actual, newNode))
                {
                    actual.Father.Left = newNode;
                }//arbol->value == arbol->father->der->value
                else if (replaceDelegateRight(actual, newNode))
                {
                    actual.Father.Right = newNode;
                }

            }
            if (newNode != null)
            {
                //Asignarle un nuevo padre
                newNode.Father = actual.Father;
            }
        }

        //go to last left node 
        private Node<T> ToLeft(Node<T> actual)
        {
            if (actual == null)//si actual está vacio
            {
                return null;
            }
            if (actual.Left != null)// si no está vacío y tiene hijo izquierdo
            {
                return ToLeft(actual.Left);
            }
            else//si no está vacío y no tine hijo izquierdo
            {
                return actual;
            }
        }


        #endregion

      

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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
