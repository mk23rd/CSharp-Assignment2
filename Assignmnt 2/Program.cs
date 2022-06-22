using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t N"+ "\t 10*N"+ "\t 100*N"+ "\t 1000*N");
            

            
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\t" + i + "\t" + 10 * i + "\t" + 100 * i + "\t" + 1000 * i);
               
            }
            Console.ReadKey();
        }
    }
}
