using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    interface IPremiumMicrowave
    {
        void AdjustFoodType(int foodType);
        void Start();
    }
}
