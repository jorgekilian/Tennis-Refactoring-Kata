namespace Tennis {
    public class Player {
        public int Score { get; private set; }
        public string Name { get; }

        public Player(int score, string name) {
            Score = score;
            Name = name;
        }

        public void AddScore() {
            Score += 1;
        }
    }
}