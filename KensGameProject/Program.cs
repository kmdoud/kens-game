using System;

namespace KensGameProject {
    
    class MainClass {

        void TestRandomness() {
            var t = 0;
            var f = 0;
            for (var i = 0; i < 100; i++) {
                var tf = Randomness.TruePercent(35);
                if (tf) {
                    t++;
                } else {
                    f++;
                }
            }
            Console.WriteLine("True: {0}; False: {1}", t, f);
        }

        void Run() {
            var knight = new Character("Balthazar", Class.Pyromancer);
            var sorceror = new Character("Leprechaun", Class.Cleric);
            var winner = Character.Battle(knight, sorceror);
            Console.WriteLine("Winner is {0}", winner.Name);
        }
        public static void Main(string[] args) {
            new MainClass().TestRandomness(); 
        }
    }
}
