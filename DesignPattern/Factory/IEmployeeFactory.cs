using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    interface IEmployeeFactory
    {
        IEmployee Create(EmployeeType employeeType);
    }
}
