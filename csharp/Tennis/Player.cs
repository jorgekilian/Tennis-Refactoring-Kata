using System.Collections.Generic;

namespace Tennis {
    public class Player {
        public int Points { get; private set; }
        public string Name { get; }

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

        public string PlayerScore(List<string> list) {
            return list[Points];
        }
    }
}