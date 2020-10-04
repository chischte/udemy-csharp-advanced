using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // where T : IComparable   --> implement (or be) an interface
    // where T : ClassName     --> derive from (or be) a class
    // where T : struct        --> value type or a structure
    // where T : class         --> reference Type
    // where T : new()         --> has a default constructor
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
