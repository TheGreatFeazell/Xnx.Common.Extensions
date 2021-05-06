using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xnx.Common.Extensions
{
    public static class IEnumerableEx
    {
        /// <summary>
        /// Determines whether the object is NULL or contains no elements
        /// </summary>
        /// <typeparam name="T">The Type of objects to enumerate</typeparam>
        /// <param name="objs">The objects to enumerate</param>
        /// <returns>TRUE if the object is NULL or contains no elements; otherwise FALSE</returns>
        public static bool IsNullOrEmpty<T>( this IEnumerable<T> objs )
        {
            return objs == null || objs.Count() == 0;
        }

        /// <summary>
        /// Iterates a collection objects and performs an action on them
        /// </summary>
        /// <typeparam name="T">The Type of objects to enumerate</typeparam>
        /// <param name="objs">The objects upon which the action should be performed</param>
        /// <param name="action">The action to perform on each object in the collection</param>
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

        /// <summary>
        /// Creates a Stack from supplied list of objects by Pushing them onto the Stack in reverse order, thus allowing them
        /// to be Popped off of the Stack in their original order. This is particularly useful for recusive functions.
        /// </summary>
        /// <typeparam name="T">The type of objects to enumerate</typeparam>
        /// <param name="objs">The objects to Push on to the Stack</param>
        /// <returns>A Stack&lt;<typeparamref name="T"/>&gt; of the objects</returns>
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
