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

        public void Attack(Character opponent, Weapon weapon) {
            
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
