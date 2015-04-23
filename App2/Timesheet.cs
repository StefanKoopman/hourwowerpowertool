using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App2
{
    class Timesheet
    {
        public double hours { get; set; }
        public DateTime date { get; set; }
        public double km { get; set; }
        public String location { get; set; }
        public String description { get; set; }

        public Timesheet(double hours, DateTime date, double km, String location, String description)
        {
            this.hours = hours;
            this.date = date;
            this.km = km;
            this.location = location;
            this.description = description;
        }
        
      


        
        
    }
}
