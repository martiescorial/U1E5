using System;

namespace U1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            Console.WriteLine("A = {0}", A);
            int B = 2;
            Console.WriteLine("B = {0}", B);
            int C = 8;
            Console.WriteLine("C = {0}", C);
            int D = 3;
            Console.WriteLine("D = {0}", D);
            B = C;
            Console.WriteLine("B = {0}", B);
            C = A;
            Console.WriteLine("C = {0}", C);
            A = D;
            Console.WriteLine("A = {0}", A);
            D = B;
            Console.WriteLine("D = {0}", D);
        }
    }
}
