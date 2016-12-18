using System;

namespace KensGameProject {
    
    class MainClass {

        void Run() {
            var bathazar = new Character("Balthazar", Class.Pyromancer);
            var leprechaun = new Character("Leprechaun", Class.Cleric);
        }
        public static void Main(string[] args) {
            new MainClass().Run();
        }
    }
}
