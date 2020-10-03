using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // where T : IComparable --> implement an interface
    // where T : Product     --> 
    // where T : struct      --> value type
    // where T : class       --> reference Type
    // where T : new()       --> has a default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {

        }
    }
}
