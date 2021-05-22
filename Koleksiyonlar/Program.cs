using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"orkun","ayca","ati" };
            //Console.WriteLine(isimler[0]);
            List<string> isimler2 = new List<string> { "orkun", "ayca", "ati" };
            isimler2.Add("sa");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
