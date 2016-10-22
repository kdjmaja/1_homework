using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGenerics
{
    class TestClass
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();
            list.Add("hehe");
            list.Add("haha");
            list.Add("hoho");
            list.Add("hihi");
            Console.WriteLine("contains haha: " + list.Contains("haha"));
            list.Remove("haha");
            Console.WriteLine("contains haha: " + list.Contains("haha"));
            Console.WriteLine("broj elemenata: " + list.Count);
            Console.WriteLine("index of hihi: " + list.IndexOf("hihi"));
            Console.WriteLine("na 1. mjestu je: " + list.GetElement(0));
            list.Clear();
            Console.WriteLine("sad ih ima: " + list.Count);
            Console.ReadLine();
        }
    }
}
