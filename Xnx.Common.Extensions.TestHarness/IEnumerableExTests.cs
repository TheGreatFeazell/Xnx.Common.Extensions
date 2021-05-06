using System;
using System.Collections.Generic;
using System.Text;

namespace Xnx.Common.Extensions.TestHarness
{
    public class IEnumerableExTests
    {
        public void TestIsNullOrEmpty()
        {
            Console.WriteLine( "Testing IsNullOrEmpty()...\n" );

            try
            {
                string[] arrayOfSome = new string[]
                {
                "Pater",
                "Paul",
                "Mary",
                };

                string[] arrayOfNone = new string[0];
                string[] arrayOfNothing = null;

                Console.WriteLine( "Array of Some: {0}", arrayOfSome.IsNullOrEmpty() ? "Empty" : $"{arrayOfSome.Length} elements" );
                Console.WriteLine( "Array of None: {0}", arrayOfNone.IsNullOrEmpty() ? "Empty" : $"{arrayOfNone.Length} elements" );
                Console.WriteLine( "Array of Nothing: {0}", arrayOfNothing.IsNullOrEmpty() ? "Empty" : $"{arrayOfNothing.Length} elements" );
            }
            catch( Exception ex )
            {
                Console.WriteLine( $"\nTest failed with: {ex.Message}\nStack Trace: {ex.StackTrace}" );
            }

            Console.WriteLine( "\nTest Complete." );
        }

        public void TestForEach()
        {
            Console.WriteLine( "Testing ForEach()...\n" );

            try
            {
                string[] arrayOfSome = new string[]
                {
                "Pater",
                "Paul",
                "Mary",
                };

                string[] arrayOfNone = new string[0];
                string[] arrayOfNothing = null;

                Action<string> writer = ( word ) =>
                {
                    Console.WriteLine( word );
                };

                Console.WriteLine( "Array of Some: {0}", arrayOfSome.IsNullOrEmpty() ? "Empty" : $"{arrayOfSome.Length} elements" );
                Console.WriteLine( "With action:" );
                arrayOfSome.ForEach( writer );
                Console.WriteLine( "\nDirect:" );
                arrayOfSome.ForEach( word => Console.WriteLine( word ) );

                Console.WriteLine( "\nArray of None: {0}", arrayOfNone.IsNullOrEmpty() ? "Empty" : $"{arrayOfNone.Length} elements" );
                arrayOfNone.ForEach( writer );

                Console.WriteLine( "\nArray of Nothing: {0}", arrayOfNothing.IsNullOrEmpty() ? "Empty" : $"{arrayOfNothing.Length} elements" );
                arrayOfNothing.ForEach( writer );
            }
            catch( Exception ex )
            {
                Console.WriteLine( $"\nTest failed with: {ex.Message}\nStack Trace: {ex.StackTrace}" );
            }

            Console.WriteLine( "\nTest Complete." );
        }

        public void TestToStack()
        {
            Console.WriteLine( "Testing ToStack()...\n" );

            try
            {
                string sentence = "The quick brown fox jumped over the lazy dog.";
                var words = sentence.Split( ' ', StringSplitOptions.RemoveEmptyEntries );
                var stack = words.ToStack();

                Console.WriteLine( $"Original: {sentence}" );
                Console.WriteLine( $"Words: {string.Join( ' ', words )}" );

                Console.Write( "Unstack:" );
                while( !stack.IsNullOrEmpty() )
                {
                    var word = stack.Pop();
                    Console.Write( $" {word}" );
                }
                Console.WriteLine();
            }
            catch( Exception ex )
            {
                Console.WriteLine( $"\nTest failed with: {ex.Message}\nStack Trace: {ex.StackTrace}" );
            }

            Console.WriteLine( "\nTest Complete." );
        }

        public static void RunTests()
        {
            Console.WriteLine( "Running all tests...\n" );

            try
            {
                var test = new IEnumerableExTests();
                test.TestIsNullOrEmpty();
                test.TestForEach();
                test.TestToStack();
            }
            catch( Exception ex )
            {
                Console.WriteLine( $"\nTests failed with: {ex.Message}\nStack Trace: {ex.StackTrace}" );
            }

            Console.WriteLine( "\nTests Complete." );
        }
    }
}
