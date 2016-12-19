using System;
namespace KensGameProject {

    public class Randomness {

        static Random rnd = null;

        public static bool TrueOrFalse(int truePercent = 50) {
            int nbrNeeded = 100 / truePercent;
            return rnd.Next(nbrNeeded) == 0;
        }
    
        public Randomness() {
        }

        static Randomness() {
            rnd = new Random(DateTime.UtcNow.GetHashCode());
        }
    }
}
