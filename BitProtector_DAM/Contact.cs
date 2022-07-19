using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BitProtector_DAM
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public bool Subscribed { get; set; }
    }
}
