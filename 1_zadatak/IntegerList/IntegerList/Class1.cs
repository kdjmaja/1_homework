using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListNamespace
{
    class TestClass
    {
        static void Test(IIntegerList list)
        {
            Console.WriteLine(list.Count);
            list.Add(5);
            list.Add(17);
            list.Add(3);
            list.RemoveAt(1);
            list.Add(18);
            list.Add(1);
            list.Remove(18);
            Console.WriteLine("index of 1: " + list.IndexOf(1) + "\n");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("element na " + (i + 1) + ". mjestu: " + list.GetElement(i));
            }
            Console.WriteLine("index of 1: " + list.IndexOf(1) + "\n");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(5));
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(233));
            Console.WriteLine(list.RemoveAt(233));
            Console.WriteLine(list.IndexOf(233));
            Console.WriteLine(list.Count);
        }
        static void Main(string[] args)
        {
            IntegerList list = new IntegerList(20);

            Test(list);
            Console.ReadLine();
        }
    }
}
