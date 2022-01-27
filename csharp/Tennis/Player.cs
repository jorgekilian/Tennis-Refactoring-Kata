namespace Tennis {
    public class Player {
        private static int score2;
        private readonly int score;

        public Player(int score) {
            score2 = 1;
            this.score = score;
        }

        public static int AddScore() {
            return score2;
        }
    }
}