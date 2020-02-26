﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Structures;

namespace CustomGenerics.Interfaces
{
    public abstract class NotLinearDataStructureBase<T>
    {
        protected abstract void Add(Node<T> actual, Node<T> a_insert);
        protected abstract T Delete(T value);
    }
}
