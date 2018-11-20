using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class PremiumMicrowave : IPremiumMicrowave
    {
        IMicrowave microwave = new Microwave();
        public void AdjustFoodType(int foodType)
        {
            switch (foodType)
            {
                case 1:
                    microwave.AdjustTime(5);
                    microwave.AdjustTemp(100);
                    break;
                case 2:
                    microwave.AdjustTime(10);
                    microwave.AdjustTemp(120);
                    break;
                default:
                    break;
            }
        }

        public void Start()
        {
            microwave.Start();
        }
    }
}
