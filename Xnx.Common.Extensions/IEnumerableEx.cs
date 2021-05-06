using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xnx.Common.Extensions
{
    public static class IEnumerableEx
    {
        public static bool IsNullOrEmpty<T>( this IEnumerable<T> objs )
        {
            return objs == null || objs.Count() == 0;
        }

        public static void ForEach<T>( this IEnumerable<T> objs, Action<T> action)
        {
            if( !objs.IsNullOrEmpty() )
            {
                foreach( var obj in objs )
                {
                    action( obj );
                }
            }
        }

        public static Stack<T> ToStack<T>( this IEnumerable<T> objs )
        {
            var stack = new Stack<T>();

            if( !objs.IsNullOrEmpty() )
            {
                foreach( var obj in objs.Reverse() )
                {
                    stack.Push( obj );
                }
            }

            return stack;
        }
    }
}
