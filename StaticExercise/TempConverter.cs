using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double UsersTempInput()
        {
            Console.WriteLine("This is a converter, please enter a temperature");
            var userTempInput = double.Parse(Console.ReadLine());
           return userTempInput;
        }

        public static void DisplayTemp()
        {
            var input = UsersTempInput();
            Console.WriteLine($"{input} converted to Farehnheit is {CelsiusToFarenheit(input)}");
            Console.WriteLine($"{input} converted to Celsius is {FarehnheitToCelsius(input)}");
        }
        public static double FarehnheitToCelsius(double farenheitTemp)
        {
            var celsius = (farenheitTemp - 32) / 1.8;
            return celsius;
        }

        public static double CelsiusToFarenheit(double celsiusTemp)
        {
            var fahrenheit = (celsiusTemp * 9) / 5 + 32;
            return fahrenheit;
        }





    }



}

