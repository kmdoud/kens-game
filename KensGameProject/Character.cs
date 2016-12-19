using System;
using System.Collections.Generic;

namespace KensGameProject {

    public class Character {

        public string Name { get; set; }
        public Class Class { get; set; }
        public List<Weapon> Weapons = new List<Weapon>();
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Attunement { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence {get;set;    }
        public int Luck { get; set; }

        private Weapon GetHighestDPS() {
            int highestDPS = 0;
            Weapon highestWeapon = null;
            foreach(var weapon in this.Weapons) {
                if(weapon.DPS > highestDPS) {
                    highestDPS = weapon.DPS;
                    highestWeapon = weapon;
                }
            }
            return highestWeapon;
        }

        public static Character Battle(Character ch1, Character ch2) {
            Random rnd = new Random(DateTime.Now.Millisecond);
            var ch1StrikesFirst = rnd.Next(2) == 0;
            var ch1Weapon = ch1.GetHighestDPS();
            var ch2Weapon = ch2.GetHighestDPS();
            while(ch1.Health > 0 && ch2.Health > 0) {
                if(ch1StrikesFirst) {
                    ch2.Health -= ch1Weapon.DPS;
                    if(ch2.Health > 0) {
                        ch1.Health -= ch2Weapon.DPS;
                    }
                } else {
                    ch1.Health -= ch2Weapon.DPS;
                    if(ch1.Health > 0) {
                        ch2.Health -= ch1Weapon.DPS;
                    }
                }
            }
            if(ch1.Health > 0) {
                return ch1;
            } else {
                return ch2;
            }
        }

        public Character(string name, Class cls) {
            this.Name = name;
            this.Class = cls;
            this.Health = cls.Health;
            this.Dexterity = cls.Dexterity;
            this.Intelligence = cls.Intelligence;
            this.Luck = cls.Luck;
            this.Strength = cls.Strength;
            this.Stamina = cls.Stamina;
            this.Attunement = cls.Attunement;
            this.Weapons = cls.Weapons;
        }
    }
}
