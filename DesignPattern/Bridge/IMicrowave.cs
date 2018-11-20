using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public interface IMicrowave
    {
        void AdjustTime(int time);
        void AdjustTemp(int temp);
        void Start();
    }
}
