using System;

namespace KensGameProject {
    
    class MainClass {

        void Run() {
            Character bathazar = new Character("Balthazar", Class.Pyromancer);
            Character leprechaun = new Character("Leprechaun", Class.Cleric);
        }
        public static void Main(string[] args) {
            new MainClass().Run(); 
        }
    }
}
