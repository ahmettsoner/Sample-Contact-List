using System;

namespace Contact.Service.Data
{
    public class Contact
    {
        public Guid Code { get; set; }
        public ContactTypes Type { get; set; }
        public string Content { get; set; }
    }
}
