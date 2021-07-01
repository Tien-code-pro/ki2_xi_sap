using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strA, strB, strC, strD;
            String strA1, strB1, strC1, strD1;
            String strA2, strB2, strC2, strD2;



            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            Console.WriteLine("Enter atomic number :");
            strA = Console.ReadLine();
            Console.WriteLine("Enter symbol :");
            strB = Console.ReadLine();
            Console.WriteLine("Enter full name :");
            strC = Console.ReadLine();
            Console.WriteLine("Enter atomic weight :");
            strD = Console.ReadLine();

            Console.WriteLine("Enter atomic number :");
            strA1 = Console.ReadLine();
            Console.WriteLine("Enter symbol :");
            strB1 = Console.ReadLine();
            Console.WriteLine("Enter full name :");
            strC1 = Console.ReadLine();
            Console.WriteLine("Enter atomic weight :");
            strD1 = Console.ReadLine();

            Console.WriteLine("Enter atomic number :");
            strA2 = Console.ReadLine();
            Console.WriteLine("Enter symbol :");
            strB2 = Console.ReadLine();
            Console.WriteLine("Enter full name :");
            strC2 = Console.ReadLine();
            Console.WriteLine("Enter atomic weight :");
            strD2 = Console.ReadLine();

            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("{0} {1} {2} {3}", strA, strB, strC,strD);
            Console.WriteLine(" {0} {1} {2} {3}", strA1, strB1, strC1, strD1);
            Console.WriteLine(" {0} {1} {2}  {3}", strA2, strB2, strC2, strD2);


            Console.ReadKey();
        }
    }
}
