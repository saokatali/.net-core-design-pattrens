using System;

namespace DesignPattern
{
    using Factory;
    using Builder;
    using Adapter;
    using Bridge;
    class Program
    {
        static void Main(string[] args)
        {
            IPremiumMicrowave premiumMicrowave = new PremiumMicrowave();
            
            premiumMicrowave.AdjustFoodType(1);            
            premiumMicrowave.Start();
            

            
        }
    }
}
