using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics.Interfaces
{
    public abstract class NotLinearDataStructureBase<T>
    {
        protected abstract void Insert(T value);
        protected abstract T Delete(T value);
    }
}
