using System;
using System.Collections.Generic;
using System.Text;

namespace String__StringBuilder__Array.Models
{
    internal class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public void ShowInfo()
        {
            Console.WriteLine($"Brendi: {Brand} Modeli: {Model} " +
            $"Yanacaq tutumu:{FuelCapacity}  1km ucun yanacaq: {FuelFor1Km} Cari yanacaq miqdari:{CurrentFuel} Ili: {Year} Rengi: {Color}");
        }



        public void Drive()
        {
            double km;
            double result;
            Console.Write("Nece km gedecek:  ");
            km = Convert.ToInt32(Console.ReadLine());
            result = CurrentFuel - km * FuelFor1Km;

            if (result > 0 || result ==0)   // normalda 0-a qeder gede bilir deye bunu da qeyd eledim xais bal qirmayin mellim ssjsjs))))
            {
                Console.WriteLine($"Hal hazirki yanacaq:   " + result);
            }
            else 
            {
                Console.WriteLine("Benzin yoxdu qardasim ozunu oldurme");
            }
        }
    }

        
}
