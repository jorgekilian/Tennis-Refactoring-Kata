namespace Tennis {
    public class Player {
        public int Score { get; private set; }

        public Player(int score) {
            this.Score = score;
        }

        public int AddScore() {
            Score += 1;
            return Score;
        }
    }
}