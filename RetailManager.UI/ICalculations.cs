using System.Collections.Generic;

namespace RetailManager.UI
{
    public interface ICalculations
    {
        List<string> Register { get; set; }

        double Add(double x, double y);
    }
}