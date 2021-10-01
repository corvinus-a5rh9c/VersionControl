using System;
using System.Collections.Generic;
using System.Text;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return LastName.ToString() + " " + FirstName.ToString(); } }
    }
}
