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
            var Pyromancer = new Character("Pyromancer", Class.Pyromancer);
            var Cleric = new Character("Cleric", Class.Cleric);
            var winner = Character.Battle(Pyromancer, Cleric);
            Console.WriteLine("Winner is {0}", winner.Name);
        }
        public static void Main(string[] args) {
            new MainClass().Run(); 
            //new MainClass().TestRandomness();
        }
    }
}
