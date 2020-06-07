using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DnDMobile.Classes
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string VerificationPassword { get; set; }

        //private readonly int maxInputLength = 255;


        public User() { }


    }
}
