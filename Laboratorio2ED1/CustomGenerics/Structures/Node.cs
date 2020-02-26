﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics.Structures
{
    class Node<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public int id;
        public string name;
    }
}
