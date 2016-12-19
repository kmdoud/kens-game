using System;

namespace KensGameProject {
    
    class MainClass {

        void Run() {
            Character knight = new Character("Balthazar", Class.Pyromancer);
            Character sorceror = new Character("Leprechaun", Class.Cleric);
            Character winner = Character.Battle(knight, sorceror);
            Console.WriteLine("Winner is {0}", winner.Name);
        }
        public static void Main(string[] args) {
            new MainClass().Run(); 
        }
    }
}
