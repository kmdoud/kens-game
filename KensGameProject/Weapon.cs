using System;
namespace KensGameProject {

    public class Weapon {

        public static Weapon Broadsword = new Weapon() {
            Name = "Broadsword", DPS = 10
        };
        public static Weapon Mace = new Weapon() {
            Name = "Mace", DPS = 12
        };

        public string Name { get; set; }
        public int DPS { get; set; }
      
        public Weapon() {
        }
    }
}
