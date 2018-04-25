using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyTest.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Class2> Class2 { get; set; }
        public List<ApplicationUser> ApplicationUser { get; set; }
    }
}