using System;
namespace MVCDemo.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 0; // normally would use a birthday so we can have it change with date.
        public bool IsAlive { get; set; } = true;

    }
}
