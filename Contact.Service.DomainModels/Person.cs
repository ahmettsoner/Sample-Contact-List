using System;

namespace Contact.Service.DomainModels
{
    public class Person
    {
        public Guid Code { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
