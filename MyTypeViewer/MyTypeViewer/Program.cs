﻿using System;
using System.Linq;

namespace MyTypeViewer
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("***** Welcome to MyTypeViewer *****");
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write(" or enter Q to quit: "); 
                    
                // Get name of type.
                var typeName = Console.ReadLine();
                // Does user want to quit? 
                if (typeName != null && typeName.ToUpper() == "Q")
                {
                    break;
                }
                // Try to display type. 
                try
                {
                    if (typeName != null)
                    {
                        var t = Type.GetType(typeName);
                        Console.WriteLine("");
                        ListVariousStats(t);
                        ListFields(t);
                        ListProps(t);
                        ListMethods(t);
                        ListInterfaces(t);
                    }
                }
                catch
                {
                    Console.WriteLine(" Sorry, can’t find type");
                }
            } while (true);
        }

        // Display method names of type. 
        private static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            var methodNames = from n in t.GetMethods() select n.Name;

            foreach (var name in methodNames)
                Console.WriteLine("->{0}", name);

            Console.WriteLine();
        }

        // Display field names of type. 
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;

            foreach (var name in fieldNames)
                Console.WriteLine("->{0}", name);

            Console.WriteLine();
        }

        // Display property names of type. 
        private static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() select p.Name;

            foreach (var name in propNames)
                Console.WriteLine("->{0}", name);

            Console.WriteLine();
        }

        // Display implemented interfaces. 
        private static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var ifaces = from i in t.GetInterfaces() select i;

            foreach ( Type i in ifaces)
                Console.WriteLine("->{0}", i.Name);
        }

        // Just for good measure. 
        private static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            Console.WriteLine(" Base class is: {0}", t.BaseType);
            Console.WriteLine(" Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine(" Is type sealed? {0}", t.IsSealed);
            Console.WriteLine(" Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine(" Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}
