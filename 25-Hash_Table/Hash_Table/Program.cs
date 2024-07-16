using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht  = new Hashtable();
            ht.Add("Id", 2256);
            ht.Add("Name", "Junaid");
            ht.Add("Age", 23);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);

            //Console.WriteLine(ht["Name"]);    //Print for single value

            /*
            foreach(object key in ht.Keys)     //print all value but unorder
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            */

            /*
            ht.Remove("Age");    //remove one key
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            */

            /*
            ht.Clear();    //remove all key after but past print key is placed
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            */

            /*
            //Contain is for check weather the key is place or not in code.
            Console.WriteLine(ht.Contains("FName"));   //False becuase of Fname
            */

            /*
            //Contain value is for check weather the value is place or not in code.
            Console.WriteLine(ht.ContainsValue("Junaid"));  //True because name value is correct
            */
            Console.ReadLine();
        }
    }
}
