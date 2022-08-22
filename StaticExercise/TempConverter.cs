using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahr)
        {
            double toCelcius = (fahr - 32) * 5 / 9;
            return toCelcius;
        }
        public static double CelciustoFahrenheit(double cel)
        {
            
            double toFahrenheit = (cel * 9 / 5) + 32;
            return toFahrenheit;
        }
    }
}
