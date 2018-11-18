using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public interface ILaptopBuilder
    {
         void AddModelNo(string modelNo);
        void AddRAM(string ram);
        void AddGraphicsCard(string graphicsCard);
        void AddDisplaySize(int size);
        Laptop Build();
    }
}
