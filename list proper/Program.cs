using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_proper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstint = new List<int>();
            int a = 1;
            while(a<=10)
            {
                
                lstint.Add(a);
                a++;
                
            }
            
           foreach(int i in lstint)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("COUNT");
            Console.WriteLine( lstint.Count());
            Console.WriteLine("revers");
            lstint.Reverse();
            foreach(int i in lstint)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("CONTAINS OR NOT");
            Console.WriteLine(lstint.Contains(11));

            Console.WriteLine("CAPACITY");
            Console.WriteLine(lstint.Capacity);

            Console.WriteLine("to find eliment via  list");
            Console.WriteLine(lstint[2]);

            Console.WriteLine("change eliment");
            lstint.Insert(5, 11);
            foreach(int i in lstint)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("remove");
            lstint.Remove(5);
            foreach (int j in lstint)
            {
                Console.WriteLine(j);
            }
            List<int> lstint1 = new List<int>();
            Console.WriteLine("list2");
           int b = 0;
            while(b<5)
            {
                lstint1.Add(b);
                b++;
            }
            foreach(int c in lstint1)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("join");
            lstint.AddRange(lstint1);
            foreach(int d in lstint)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
           
            
        }
    }
}
