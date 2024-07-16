using Generics_Method_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Method_Classes
{
    /*
    // Generics Method Example
    class Example
    {
        // Method to display any type of array
        public static void showArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        // Generic method to check equality of two values
        public static bool check<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example arrays
            int[] Numbers = new int[] { 11, 22, 33 };
            string[] Names = { "Junaid", "Khalid", "Mehmood" };
            double[] Points = { 5.7, 7.8, 2.5 };

            // Using Example class methods
            Example.showArray(Numbers); // Display integers
            Example.showArray(Names);   // Display strings
            Example.showArray(Points);  // Display doubles

            // Checking equality using generics method
            Console.WriteLine(Example.check(2, 5)); // Should return False
            Console.WriteLine(Example.check(5, 5)); // Should return True

            Console.ReadLine();
        }
    }
    */


    //Generics classes
    /*
    class Example <T>
    {
        T box;
        public T Box
        {
            set
            {
                this.box = value;  ;
            }
            get
            {
              return this.box  ;
            }
        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example<int> e = new Example<int>();
            Example<string> e1 = new Example<string>();
            e.Box = 30;
            e1.Box = "JK";
            Console.WriteLine(e.Box);
            Console.WriteLine(e1.Box);
            Console.ReadLine();
        }
    }
    */

    //OR

    /*
    class Example<T>
    {
        T box;
        public Example (T b)
        {
            this.box = b;
        }
        public T getBox()
        {
            return this.box;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example<int> e = new Example<int>(20);
            Example<string> e1 = new Example<string>("Junaid");
            Console.WriteLine(e.getBox());
            Console.WriteLine(e1.getBox());
            Console.ReadLine();
        }
    }
    */
}
