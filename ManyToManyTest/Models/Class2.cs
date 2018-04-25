using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyTest.Models
{
    public class Class2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Class1> Class1 { get; set; }
        public List<ApplicationUser> Fred { get; set; }
    }
}