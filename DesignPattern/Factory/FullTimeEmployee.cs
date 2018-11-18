using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class FullTimeEmployee : IEmployee
    {
        public void Details()
        {
            Console.WriteLine("Permanent Employee Details");
        }
    }
}
