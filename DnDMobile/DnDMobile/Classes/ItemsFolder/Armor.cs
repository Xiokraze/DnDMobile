﻿namespace DnDMobile.Classes.ItemsFolder
{
    public class Armor
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public string ArmorClass { get; set; }
        public string RequiredStrength { get; set; }
        public string StealthImpact { get; set; }
        public string Weight { get; set; }
        public string Type { get; set; }

        // Consctructor.
        public Armor(string description, string value, string armorClass, string requiredStrength, string stealthImpact, string weight, string type) 
        {
            this.Description = description;
            this.Value = value;
            this.ArmorClass = armorClass;
            this.RequiredStrength = requiredStrength;
            this.StealthImpact = stealthImpact;
            this.Weight = weight;
            this.Type = type;
        }
    }
}
