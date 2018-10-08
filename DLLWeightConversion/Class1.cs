using System;

namespace DLLWeightConversion
{
    public class Class1
    {
        public double ConvertToGrams(double onc)
        {
            double gm = onc * 28.34952;
            return gm;

        }
        
        public double ConvertToOunces(double gm)
        {
            double onc = gm * 0.03527396195;
            return onc;
        }
    }
}
