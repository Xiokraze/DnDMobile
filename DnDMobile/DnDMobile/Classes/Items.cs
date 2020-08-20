using Android.Hardware.Camera2;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes
{
    class Items
    {
        private List<Armor> StandardLightArmor { get; } = FetchStandardLightArmor();
        private List<Armor> StandardMediumArmor { get; } = FetchStandardMediumArmor();
        private List<Armor> StandardHeavyArmor { get; } = FetchStandardHeavyArmor();
        private List<Armor> StandardShields { get; } = FetchStandardShilelds();
        private List<Weapon> SimpleMeleeWeapons { get; } = FetchSimpleMeleeWeapons();
        private List<Weapon> SimpleRangedWeapons { get; } = FetchSimpleRangedWeapons();
        private List<Weapon> MartialMeleeWeapons { get; } = FetchMartialMeleeWeapons();
        private List<Weapon> MartialRangedWeapons { get; } = FetchMartialRangedWeapons();


        public Items() { }


        public List<Armor> GetStandardLightArmor()
        {
            return StandardLightArmor;
        }


        public List<Armor> GetStandardMediumArmor()
        {
            return StandardMediumArmor;
        }


        public List<Armor> GetStandardHeavyArmor()
        {
            return StandardHeavyArmor;
        }


        public List<Armor> GetStandardShields()
        {
            return StandardShields;
        }


        public List<Weapon> GetSimpleMeleeWeapons()
        {
            return SimpleMeleeWeapons;
        }


        public List<Weapon> GetSimpleRangedWeapons()
        {
            return SimpleRangedWeapons;
        }


        public List<Weapon> GetMartialMeleeWeapons()
        {
            return MartialMeleeWeapons;
        }


        public List<Weapon> GetMartialRangedWeapons()
        {
            return MartialRangedWeapons;
        }


        private static List<Armor> FetchStandardLightArmor()
        {
            List<Armor> lightArmor = new List<Armor>
            {
                new Armor("Padded", "5 gp", "11 + Dex Modifier", "-", "Disadvantage", "8 lbs"),
                new Armor("Leather", "10 gp", "11 + Dex Modifier", "-", "-", "10 lbs"),
                new Armor("Studded Leather", "45 gp", "12 + Dex Modifier", "-", "-", "13 lbs")
            };
            return lightArmor;
        }


        private static List<Armor> FetchStandardMediumArmor()
        {
            List<Armor> mediumArmor = new List<Armor>
            {
                new Armor("Hide", "10 gp", "12 + Dex Modifier (Max 2)", "-", "-", "12 lbs"),
                new Armor("Chain Shirt", "50 gp", "13 + Dex Modifier (Max 2)", "-", "-", "20 lbs"),
                new Armor("Scale Mail", "50 gp", "14 + Dex Modifier (Max 2)", "-", "Disadvantage", "45 lbs"),
                new Armor("Breastplate", "400 gp", "14 + Dex Modifier (Max 2)", "-", "-", "20 lbs"),
                new Armor("Half Plate", "750 gp", "15 + Dex Modifier (Max 2)", "-", "Disadvantage", "40 lbs")
            };
            return mediumArmor;
        }


        private static List<Armor> FetchStandardHeavyArmor()
        {
            List<Armor> heavyArmor = new List<Armor>
            {
                new Armor("Ring Mail", "30 gp", "14", "-", "Disadvantage", "40 lbs"),
                new Armor("Chain Mail", "75 gp", "16", "13", "Disadvantage", "55 lbs"),
                new Armor("Splint", "200 gp", "17", "15", "Disadvantage", "60 lbs"),
                new Armor("Plate", "1,500 gp", "18", "15", "Disadvantage", "65 lbs")
            };
            return heavyArmor;
        }


        private static List<Armor> FetchStandardShilelds()
        {
            List<Armor> shields = new List<Armor>
            {
                new Armor("Shield", "10 gp", "+2", "-", "-", "6 lbs")
            };
            return shields;
        }


        private static List<Weapon> FetchSimpleMeleeWeapons()
        {
            List<Weapon> simpleMeleeWeapons = new List<Weapon>
            {
                new Weapon("Club", "1 sp", "1d4 bludgeoning", "2 lbs", "Light"),
                new Weapon("Dagger", "2 gp", "1d4 piercing",  "1 lbs", "Finesse, Light, Thrown (range 20/60)"),
                new Weapon("Greatclub", "2 sp", "1d8 bludgeoning", "10 lbs", "Two-handed"),
                new Weapon("Handaxe", "5 gp", "1d6 slashing", "2 lbs", "Light, Thrown (range 20/60)"),
                new Weapon("Javelin", "5 sp", "1d6 piercing", "2 lbs", "Thrown (range 30/120)"),
                new Weapon("Light Hammer", "2 gp", "1d4 bludgeoning", "2 lbs", "Light, Thrown (range 20/60)"),
                new Weapon("Mace", "5 gp", "1d6 bludgeoning", "4 lbs",  "-"),
                new Weapon("Quarterstaff", "2 sp", "1d6 bludgeoning", "4 lbs", "Versatile (1d8)"),
                new Weapon("Sickle", "1 gp", "1d4 slashing", "2 lbs", "Light"),
                new Weapon("Spear", "1 gp", "1d6 piercing", "3 lbs", "Thrown (range 20/60), Versatile (1d8)")
            };
            return simpleMeleeWeapons;
        }


        private static List<Weapon> FetchSimpleRangedWeapons()
        {
            List<Weapon> simpleRangedWeapons = new List<Weapon>
            {
                new Weapon("Crossbow, Light", "25 gp", "1d8 piercing", "5 lbs", "Ammunition (range 80/320), Loading, Two-handed"),
                new Weapon("Dart", "5 cp", "1d4 piercing", "1/4 lbs", "Finesse, Thrown (range 20/60)"),
                new Weapon("Shortbow", "25 gp", "1d6 piercing", "2 lbs", "Ammunition (range 80/320), Two-handed"),
                new Weapon("Sling", "1 sp", "1d4 bludgeoning", "-", "Ammunition (range 30/120)")
            };
            return simpleRangedWeapons;
        }


        private static List<Weapon> FetchMartialMeleeWeapons()
        {
            List<Weapon> martialMeleeWeapons = new List<Weapon>
            {
                new Weapon("Battleaxe", "10 gp", "1d8 slashing", "4 lbs", "Versatile (1d10)"),
                new Weapon("Flail", "10 gp", "1d8 bludgeoning", "2 lbs", "-"),
                new Weapon("Glaive", "20 gp", "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Greataxe", "30 gp", "1d12 slashing", "7 lbs", "Heavy, Two-handed"),
                new Weapon("Greatsword", "50 gp", "2d6 slashing", "6 lbs", "Heavy, Two-handed"),
                new Weapon("Halberd", "20 gp",    "1d10 slashing", "6 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Lance", "10 gp", "1d12 piercing", "6 lbs", "Reach, Special"),
                new Weapon("Longsword", "15 gp", "1d8 slashing", "3 lbs", "Versatile (1d10)"),
                new Weapon("Maul", "10 gp", "2d6 bludgeoning", "10 lbs", "Heavy, Two-handed"),
                new Weapon("Morningstar", "15 gp", "1d8 piercing", "4 lbs", "-"),
                new Weapon("Pike", "5 gp", "1d10 piercing", "18 lbs", "Heavy, Reach, Two-handed"),
                new Weapon("Rapier", "25 gp", "1d8 piercing", "2 lbs", "Finesse"),
                new Weapon("Scimitar", "25 gp", "1d6 slashing", "3 lbs", "Finesse, Light"),
                new Weapon("Shortsword", "10 gp", "1d6 piercing", "2 lbs", "Finesse, Light"),
                new Weapon("Trident", "5 gp", "1d6 piercing", "4 lbs", "Thrown (range 20/60), Versatile (1d8)"),
                new Weapon("War Pick", "5 gp", "1d8 piercing", "2 lbs", "-"),
                new Weapon("Warhammer", "15 gp", "1d8 bludgeoning", "2 lbs", "Versatile (1d10)"),
                new Weapon("Whip", "2 gp", "1d4 slashing", "3 lbs", "Finesse, Reach")
            };
            return martialMeleeWeapons;
        }


        private static List<Weapon> FetchMartialRangedWeapons()
        {
            List<Weapon> martialRangedWeapons = new List<Weapon>
            {
                new Weapon("Blowgun", "10 gp", "1 piercing", "1 lbs", "Ammunition (range 25/100), Loading"),
                new Weapon("Crossbow, Hand", "75 gp", "1d6 piercing", "3 lbs", "Ammunition (range 30/120), Light, Loading"),
                new Weapon("Crossbow, Heavy", "50 gp", "1d10 piercing", "18 lbs", "Ammunition (range 100/400), Heavy, Loading, Two-handed"),
                new Weapon("Longbow", "50 gp", "1d8 piercing", "2 lbs", "Ammunition (range 150/600), Heavy, Two-handed"),
                new Weapon("Net", "1 gp", "-", "3 lbs", "Special, Thrown (range 5/15)")
            };
            return martialRangedWeapons;
        }
    }
}
