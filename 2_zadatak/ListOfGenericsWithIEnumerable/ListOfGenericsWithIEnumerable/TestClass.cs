using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGenericsWithIEnumerable
{
    class TestClass
    {
        static void Main(string[] args)
        {
            IGenericList<string> list = new GenericList<string>();
            list.Add("First");
            list.Add("Second");
            list.Add("Third");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach(var item in list)
            {
                Console.WriteLine(list.IndexOf(item));
            }
            Console.ReadLine();
        }

    }
}
