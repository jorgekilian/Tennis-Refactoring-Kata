namespace Tennis {
    public class Player {
        private int score;

        public Player(int score) {
            this.score = score;
        }

        public int AddScore() {
            this.score += 1;
            return this.score;
        }
    }
}