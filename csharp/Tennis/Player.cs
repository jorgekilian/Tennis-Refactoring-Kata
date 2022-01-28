namespace Tennis {
    public class Player {
        public int Score { get; private set; }
        public string Name { get; }

        private Player(int score, string name) {
            Score = score;
            Name = name;
        }

        public static Player CreatePlayer(int score, string name) {
            return new Player(score, name);
        }

        public void AddScore() {
            Score += 1;
        }
    }
}