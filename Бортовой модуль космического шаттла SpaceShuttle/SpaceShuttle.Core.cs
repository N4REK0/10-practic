using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Бортовой_модуль_космического_шаттла_SpaceShuttle
{
    public partial class SpaceShuttle
    {
        private double _fuekKg;
        private double _oxygenHours;
        private int _hullIntegrity;

        public string ShuttleName { get; set; }

        public double FuelKg
        {
            get { return _fuekKg; }
            set
            {
                if ( value < 0 )
                {
                    _fuekKg = 0;
                }

                else
                {
                    _fuekKg = value;
                }
            }
        }

        public int HullIntegrity
        {
            get { return _hullIntegrity; }
            set
            {
                if (value < 0)
                {
                    _hullIntegrity = 0;
                }

                else if (value > 100)
                {
                    _hullIntegrity = 100;
                }

                else
                {
                    _hullIntegrity = value;
                }
            }
        }

        public bool IsOperational
        {
            get { return _hullIntegrity > 15 && _oxygenHours > 0; }
        }

        public SpaceShuttle(string shuttleName, double fuelkg, double oxygenHours, int hullIntegrity)
        {
            this.ShuttleName = shuttleName;
            this.FuelKg = fuelkg;
            this._oxygenHours = oxygenHours;
            this.HullIntegrity = hullIntegrity;
        }









    }
}
