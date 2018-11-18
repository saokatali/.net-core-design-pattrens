using System;

namespace DesignPattern
{
    using Factory;
    using Builder;
    using Adapter;
    class Program
    {
        static void Main(string[] args)
        {
            Adapter.IEmployee employee = new EmployeeAdapter();
            employee.GetEmployee();

            
        }
    }
}
