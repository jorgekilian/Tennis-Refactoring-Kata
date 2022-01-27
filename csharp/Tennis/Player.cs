namespace Tennis {
    public class Player {
        public int Score { get; private set; }

        public Player(int score, string name) {
            Score = score;
        }

        public void AddScore() {
            Score += 1;
        }
    }
}