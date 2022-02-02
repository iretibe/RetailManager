using System.Collections.Generic;

namespace RetailManager.UI
{
    public class Calculations : ICalculations
    {
        public List<string> Register { get; set; } = new List<string>();

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
