using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class User
    {
        public double wage { get; set; }
        public String name { get; set; }
        public double kmAllowance { get; set; }
        public List<Project> projects { get; set; }

        public User(double wage, String name, double kmAllowance)
        {
            this.wage = wage;
            this.name = name;
            this.kmAllowance = kmAllowance;
            projects = new List<Project>();
            
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
        }
    }
}
