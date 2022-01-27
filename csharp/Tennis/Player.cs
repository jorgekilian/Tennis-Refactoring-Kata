namespace Tennis {
    public class Player {
        private static int score;
        public Player() { }
        static Player() {
            score = 1;
        }

        public static int AddScore() {
            return score;
        }
    }
}