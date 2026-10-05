using AutoServiceCuNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceCuNET
{
    internal class Car : Vehicle
    {
        int hpwr;
        string brand, transmission;
        public int HorsePower
        {
            get { return hpwr; }
            set { hpwr = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }

        public Car(string licenseNr, string color, int capacity, int fabrYr, int hpwr, string brand, string transmission): base(licenseNr,color,capacity,fabrYr)
        {
            this.hpwr = hpwr;
            this.brand = brand;
            this.transmission = transmission;
        }
    }
}
