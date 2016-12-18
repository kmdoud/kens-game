using System;
namespace KensGameProject {

    public class Character {

        public string Name { get; set; }
        public Class Class { get; set; } 
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Attunement { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence {get;set;    }
        public int Luck { get; set; }
    
        public Character() {
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
        }
    }
}
