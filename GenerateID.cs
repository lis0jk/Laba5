using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GenerateID
    {        
        public static int Generate()
        {
            Random random = new Random();
            return random.Next(1000000, 99999999);            
        }
    }
}
