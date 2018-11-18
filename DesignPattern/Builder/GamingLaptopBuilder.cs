using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class GamingLaptopBuilder : ILaptopBuilder
    {
        Laptop laptop = new Laptop();

        public void AddDisplaySize(int size)
        {
            laptop.ScreenSize = size;
        }

        public void AddGraphicsCard(string graphicsCard)
        {
            laptop.GraphicsCard = graphicsCard;
        }

        public void AddModelNo(string modelNo)
        {
            laptop.ModelNo = modelNo;
        }

        public void AddRAM(string ram)
        {
            laptop.RAM = ram;
        }

        public Laptop Build()
        {
            return laptop;
        }
    }
}
