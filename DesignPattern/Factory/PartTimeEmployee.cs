using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class PartTimeEmployee : IEmployee
    {
        public void Details()
        {
            Console.WriteLine("PartTime Employee Details");
        }
    }
}
