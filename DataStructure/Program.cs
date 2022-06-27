using System.Collections;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; // 创建了一个int类型的数组 容量为10
            for(int i = 0; i < 10; i++)
            {
                arr[i] = i; 
                Console.WriteLine(arr[i]+" ");
            }

            // 使用动态数组 ArrayList
            ArrayList a = new ArrayList(10);// 可以传入一个参数来指定动态数组容量的大下, 不传的话具备一个默认的容量
            for(int i = 0; i < 15; i++) // 动态数具备自动扩容的能力
            {
                a.Add(i);
                Console.WriteLine(a[i]+" ");
            }

            // List<T>
            List<int> l = new List<int>(10);
            for(int i = 0; i<15;i++)
            {
                l.Add(i);
                Console.WriteLine(l[i]);
            }    
        }
    }
}