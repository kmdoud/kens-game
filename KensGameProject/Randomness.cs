using System;
namespace KensGameProject {

    public class Randomness {

        static Random rnd = null;

        public static bool TruePercent(int truePercent = 50) {
            if(truePercent < 0 || truePercent > 99) {
                throw new ApplicationException("truePercent must be 0 <= x < 100");
            }
            return rnd.Next(100) <= truePercent;
        }
    
        public Randomness() {
        }

        static Randomness() {
            rnd = new Random(DateTime.UtcNow.GetHashCode());
        }
    }
}
