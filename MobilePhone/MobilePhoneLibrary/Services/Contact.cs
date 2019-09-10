﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
    public class Contact {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Contact(string name, int phoneNumber) {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string GetContact() {
            return $"{Name} {PhoneNumber}";
        }
    }
}
