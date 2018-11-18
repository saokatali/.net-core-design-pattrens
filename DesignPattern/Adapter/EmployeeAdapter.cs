using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    class EmployeeAdapter : IEmployee
    {
        ThirdPartyEmployee employee = new ThirdPartyEmployee(); 
        public List<string> GetEmployee()
        {
            return employee.GetEmployeeList();
        }
    }
}
