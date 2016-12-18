using System;
namespace KensGameProject {
    public class Class {
        public static Class Warrior = new Class() {
            Name = "Warrior", Attunement = 6, Dexterity = 8,
                Health = 100, Intelligence = 10, Luck = 5, Stamina = 50, Strength = 11
            };
        public static Class Thief = new Class() {
            Name = "Thief", Attunement = 5, Dexterity = 12,
                Health = 100, Intelligence = 5, Luck = 10, Stamina = 50, Strength = 6
            };
        public static Class Cleric = new Class() {
            Name = "Cleric", Attunement = 10, Dexterity = 6,
                Health = 70, Intelligence = 11, Luck = 8, Stamina = 70, Strength = 5
            };
        public static Class Pyromancer = new Class() {
            Name = "Pyromancer", Attunement = 10, Dexterity = 5,
                Health = 80, Intelligence = 6, Luck = 11, Stamina = 70, Strength = 8
            };

        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Attunement { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Luck { get; set; }

        public Class() {
        }
    }
}
