using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoService;
using AutoServiceCuNET;

namespace AutoServiceCuNET
{
    internal class Appointment
    {
        User user;
        Car car;
        string date, hour;

        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public Appointment(User User,Car Car,string date,string hour)
        {
            this.user = User;
            this.car = Car;
            this.date = date;
            this.hour = hour;
        }
    }
}
