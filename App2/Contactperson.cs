using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Contactperson
    {
        public String name {get; set;}
        public String email { get; set; }
        public int telefoon { get; set; }
        public String organisation { get; set; }

        public Contactperson(String name, String email, int telefoon, String organisation)
        {
            this.name = name;
            this.email = email;
            this.telefoon = telefoon;
            this.organisation = organisation;
        }

      

        
    }
}
