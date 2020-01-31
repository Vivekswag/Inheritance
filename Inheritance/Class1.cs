using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s1 = " Cshr ";
            string s2 = s1.Insert(3, " a ");
            string s3 = s2.Insert(5, " p ");
            for (int i = 0; i < s3.Length; i++)
                Console.WriteLine(s3[i]);
            Console.ReadLine();
        }
    }
}
