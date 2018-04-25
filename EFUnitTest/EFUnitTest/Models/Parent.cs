using System.Collections.Generic;

namespace EFUnitTest.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Child> Children { get; set; }

        public Parent()
        {
            Children = new List<Child>();
        }
    }
}