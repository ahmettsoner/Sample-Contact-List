using System;

namespace Contact.Service.DomainModels
{
    public class Contact
    {
        public Guid Code { get; set; }
        public ContactTypes Type { get; set; }
        public string Content { get; set; }
    }
}
