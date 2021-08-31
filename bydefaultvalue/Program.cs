using System;

namespace bydefaultvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            bool boolVar = true;
            byte byteVar = default;
            short shortVar = default;
            ushort ushortVar = default;
            int intVar = default;
            uint uintVar = default;
            long longVar = default;
            ulong ulongVar = default;
            float floatVar = default;
            double doubleVar = default;
            char charVar = 'A';
            Console.WriteLine("Value Data Types ");
            Console.WriteLine(boolVar);
            Console.WriteLine(byteVar);
            Console.WriteLine(shortVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(intVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(longVar);
            Console.WriteLine(ulongVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(charVar);

        }
    }
}
