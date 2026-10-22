using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Бортовой_модуль_космического_шаттла_SpaceShuttle
{
    public partial class SpaceShuttle
    {
        public void ExecuteOrbitalBurn(double burnTimeSeconds, double thrustPower)
        {
            if (burnTimeSeconds <= 0 || thrustPower <= 0)
            {
                Console.WriteLine("Ошибка, время и мощность должны быть больше нуля");
            }

            double FuelRequired = burnTimeSeconds * thrustPower * 2.5;

            if (FuelKg < FuelRequired)
            {
                Console.WriteLine("Ошибка, маневр не может быть выполнен, топлива не достаточно");
            }








        }
    }
}




