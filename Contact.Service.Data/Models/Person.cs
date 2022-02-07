using System;
using System.Collections.Generic;

namespace Contact.Service.Data.Models
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public virtual ICollection<Contact> Contacts {get;set;}
    }
}