using System;

namespace Contact.Service.Data.Models
{
    public class Contact
    {
        public Guid ID { get; set; }
        public ContactTypes Type { get; set; }
        public string Content { get; set; }

        public virtual Person Person {get;set;}
    }
}