using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class VeriTypes
    {
      

        static void Main(string[] args)
        {
            // Signed 8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit      : {SByte.MinValue,25}");
            Console.WriteLine($"Üst limit      : {SByte.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(SByte), 25}");
            Console.ReadKey();

            // Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit      : {Byte.MinValue,25}");
            Console.WriteLine($"Üst limit      : {Byte.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(Byte),25}");
            Console.ReadKey();

            // Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit      : {Int16.MinValue,25}");
            Console.WriteLine($"Üst limit      : {Int16.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(Int16),25}");
            Console.ReadKey();

            // Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit      : {UInt16.MinValue,25}");
            Console.WriteLine($"Üst limit      : {UInt16.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(UInt16),25}");
            Console.ReadKey();

            // Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit      : {Int32.MinValue,25}");
            Console.WriteLine($"Üst limit      : {Int32.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(Int32),25}");
            Console.ReadKey();

            // Usigned 32-bit integer
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt limit      : {UInt32.MinValue,25}");
            Console.WriteLine($"Üst limit      : {UInt32.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(UInt32),25}");
            Console.ReadKey();

            // Double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit      : {Double.MinValue,25}");
            Console.WriteLine($"Üst limit      : {Double.MaxValue,25}");
            Console.WriteLine($"Boyut          : {sizeof(Double),25}");
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}