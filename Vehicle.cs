using AutoServiceCuNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceCuNET
{
    internal class Vehicle
    {
        string licenseNumber, color;
        int capacity, fabricationYear;
        public string LicenseNumber
        {
            get { return licenseNumber; }
            set { licenseNumber = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public int FabricationYear
        {
            get { return fabricationYear; }
            set { fabricationYear = value; }
        }
        public Vehicle(string licenseNr, string color,int capacity,int fabrYr)
        {
            this.licenseNumber = licenseNr;
            this.color = color;
            this.capacity = capacity;
            this.fabricationYear = fabrYr;
        }
    }
}
