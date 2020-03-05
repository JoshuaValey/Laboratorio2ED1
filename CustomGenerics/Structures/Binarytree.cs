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
    public class Binary_tree<T> where T : IComparable, INotLinearDataStructureBase<T>
    {
        public Node<T> root = null;

        #region Métodos y delegados para eliminación de nodos. 

        //SobreCarga de Delete
        public void Eliminar(Node<T> actual,T value)
        {
            if (actual == null)
            {
                return;
            }
            else if (actual.Value.CompareTo(value) == -1)
            {
                Eliminar(actual.Left, value);
            }
            else if (actual.Value.CompareTo(value) == 1)
            {
                Eliminar(actual.Right, value);
            }
            else if (actual.Value.CompareTo(value) == 0)
            {
                DeleteNode(actual);
                throw new NotImplementedException();
            }
        }

        private void DeleteNode(Node<T> nodeToDelete)
        {
            // Eliminar si tiene ambos
            if (nodeToDelete.Left != null && nodeToDelete.Right != null)
            {
                Node<T> lefter = ToLeft(nodeToDelete.Right);
                nodeToDelete.Value = lefter.Value;
                DeleteNode(lefter);
            }                     
            #region Eliminar el nodo si tiene solo uno de sus dos hijos
                //Si tiene el nodo izquierdo
            else if (nodeToDelete.Left != null)
            {
                Replace(nodeToDelete, nodeToDelete.Left);
                KillNode(nodeToDelete);
            }
            else if (nodeToDelete.Right != null)
            {
                Replace(nodeToDelete, nodeToDelete.Right);
                KillNode(nodeToDelete);
            }
            #endregion
            // Ha llegado al final del árbol.
            else
            {
                Replace(nodeToDelete, null);
                KillNode(nodeToDelete);
            }
        }

        private void KillNode(Node<T> nodeToDelete)
        {
            nodeToDelete.Right = null;
            nodeToDelete.Left = null;
            nodeToDelete.Father = null;
        }

        private void Replace(Node<T> actual, Node<T> newNode)
        {
            if (actual.Father != null)
            {
                //arbol->value == arbol->father->izq->value
                if (actual.Value.CompareTo(actual.Father.Left.Value) == 0)
                {
                    actual.Father.Left = newNode;
                }//arbol->value == arbol->father->der->value
                else if (actual.Value.CompareTo(actual.Father.Right.Value) == 0)
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

        //Ir al nodo que esté más a la izquierda. 
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

        }
        public Node<T> createNode(T newValue, Node<T> father)
        {
           
            Node<T> new_Node = new Node<T>();
            new_Node.Father = father;
            new_Node.Value = newValue;
            new_Node.Right = null;
            new_Node.Left = null;
            return new_Node;
        }

       /* public void insertNode(Node<T> tree, T value, Node<T> father)
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
                if (value < valueRoot) //if the element is smaller than root, insert left
                {
                    insertNode(tree.Left, value, tree);
                }
                else //if the element isn't smaller, insert right
                {
                    insertNode(tree.Right, value, tree);
                }
            }
        }*/

        /*public bool Searching(Node<T> tree, T value)
        {
            if (tree == null) //tree is empty
            {
                return false;
            }
            else if ((tree.Value).Equals(value)) //value foung
            {
                return true;
            }
            else if (value < tree.Value) //search on smaller elements
            {
                Searching(tree.Left, value);
            }
            else //search on bigger elements
            {
                Searching(tree.Right, value);
            }
        }
        */
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

        public void Search(Node<T> actual, T value)
        {
            throw new NotImplementedException();
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

        public void Delete(Node<T> actual, T value)
        {
            throw new NotImplementedException();
        }
    }
}
