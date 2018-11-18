using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class EmployeeFactory : IEmployeeFactory
    {
        public IEmployee Create(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.FULLTIME:
                    return new FullTimeEmployee();
                  
                case EmployeeType.PARTTIME:
                    return new PartTimeEmployee();
                default:
                    throw new Exception("Employee Type is not supported");
            }
        }
    }
}
