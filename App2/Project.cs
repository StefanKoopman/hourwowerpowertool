using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Project
    {
        public String title;
        public String description;
        public String location;
        public Contactperson contactperson;
        public List<Timesheet> timesheets;
        public DateTime startdate;

        public Project(String title, String description, String location, Contactperson contactperson, DateTime startdate)
        {
            this.title = title;
            this.description = description;
            this.location = location;
            this.contactperson = contactperson;
            this.startdate = startdate;
        }
       

        public void AddTimesheet(Timesheet timesheet)
        {
            timesheets.Add(timesheet);
        }

        public double getHours()
        {
            double total = 0;
            foreach(Timesheet timesheet in timesheets)
            {
                total += timesheet.hours;
            }
            return total;
        }
    }
}
