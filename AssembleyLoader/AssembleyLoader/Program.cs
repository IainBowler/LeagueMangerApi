using System;
using System.Linq;
using System.Reflection;

namespace AssembleyLoader
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("***** Welcome to MyAssembleyLoader *****");
            // Load TestSharedLibrary from GAC. 
            string displayName = null;
            displayName = "TestSharedLibrary," + 
                "Version = 1.0.0.0," +
                "PublicKeyToken = 735c3567c35a4d77," + 
                @" Culture =""";

            var asm = Assembly.Load(displayName);

            DisplayAssembleyInfo(asm);

            var types = asm.GetTypes();

            foreach (var type in types)
            {
                ListTypeInfo(type);
            }

            Console.WriteLine(" Done!");
            Console.ReadLine();
        }

        private static void ListTypeInfo(Type type)
        {
            ListVariousStats(type);
            ListFields(type);
            ListProps(type);
            ListMethods(type);
            ListInterfaces(type);
        }

        private static void DisplayAssembleyInfo(Assembly assembley)
        {
            Console.WriteLine("***** Info about Assembly *****");
            Console.WriteLine(" Loaded from GAC? {0}", assembley.GlobalAssemblyCache);
            Console.WriteLine(" Asm Name: {0}", assembley.GetName().Name);
            Console.WriteLine(" Asm Version: {0}", assembley.GetName().Version);
            Console.WriteLine(" Asm Culture: {0}", assembley.GetName().CultureInfo.DisplayName);
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

            foreach (Type i in ifaces)
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
