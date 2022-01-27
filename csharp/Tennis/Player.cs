namespace Tennis {
    public class Player {
        private static int score;
        private readonly int score1;

        public Player(int score1) {
            score = 1;
            this.score1 = score1;
        }

        public static int AddScore() {
            return score;
        }
    }
}