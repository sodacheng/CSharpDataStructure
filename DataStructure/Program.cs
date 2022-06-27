using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array1 a = new Array1(20);
            
            for(int i = 0; i < 10; i++)
            {
                a.AddLast(i);
            }

            a.AddFirst(66);
            Console.WriteLine(a);

            a.Add(2, 27);
            Console.WriteLine(a);

            Console.WriteLine(a.GetLast());
            Console.WriteLine(a.GetFirst());

            a.Set(0, 1000);

            Console.WriteLine(a.GetFirst());
        }
    }
}