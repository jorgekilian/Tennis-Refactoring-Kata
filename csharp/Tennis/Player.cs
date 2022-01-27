namespace Tennis {
    public class Player {
        private static int score2;
        private int score;

        public Player(int score) {
            score2 = 1;
            this.score = score;
        }

        public int AddScore() {
            this.score += 1;
            return this.score;
        }
    }
}