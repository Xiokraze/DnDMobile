using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes
{
    class Weapon
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public string Damage { get; set; }
        public string Weight { get; set; }
        public string Properties { get; set; }


        // Constructor.
        public Weapon(string type, string value, string damage, string weight, string properties)
        {
            this.Type = type;
            this.Value = value;
            this.Damage = damage;
            this.Weight = weight;
            this.Properties = properties;
        }
    }
}
