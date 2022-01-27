namespace Tennis {
    public class Player {
        public int Score { get; private set; }

        public Player(int score) {
            this.Score = score;
        }

        public void AddScore() {
            Score += 1;
        }
    }
}