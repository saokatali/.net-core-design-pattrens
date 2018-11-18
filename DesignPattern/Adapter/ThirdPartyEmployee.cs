using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> empList = new List<string>();
            empList.Add("Tom");
            empList.Add("Harry");

            return empList;
        }
    }
}
