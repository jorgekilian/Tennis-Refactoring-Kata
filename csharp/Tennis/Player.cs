using System.Collections.Generic;

namespace Tennis {
    public class Player {
        public int Points { get; private set; }
        public string Name { get; }

        private readonly List<string> scores = new List<string> { "Love", "Fifteen", "Thirty", "Forty" };

        private Player(int points, string name) {
            Points = points;
            Name = name;
        }

        public static Player CreatePlayer(int score, string name) {
            return new Player(score, name);
        }

        public void AddPoint() {
            Points += 1;
        }

        public bool HasFortyPointsOrMore() {
            return Points > 2;
        }

        public string PlayerScore() {
            return scores[Points];
        }

        public string Advantage1() {
            return $"Advantage {Name}";
        }
    }
}