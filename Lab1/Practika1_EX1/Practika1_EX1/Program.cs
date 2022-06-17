using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practika1_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            string otv;
        
            while((otv=Console.ReadLine())!=null) 
            {              
                otv = otv.Replace(",", " y:");
                otv = "x:" + otv;
                Console.WriteLine(otv);
                
            }
            
        }
    }
}
