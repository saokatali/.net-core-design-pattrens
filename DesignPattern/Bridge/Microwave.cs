using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class Microwave : IMicrowave
    {
        int temp;
        int time;
        public void AdjustTemp(int temp)
        {
            this.temp = temp;
        }

        public void AdjustTime(int time)
        {
            this.time = time;
        }

        public void Start()
        {
            Console.WriteLine($"Microwave started. Temp:{this.temp} and Time: {this.time}");
        }
    }
}
