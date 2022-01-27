namespace Tennis {
    public class Player {
        private TennisGame1 tennisGame1;
        private int score;

        public Player(TennisGame1 tennisGame1) {
            this.tennisGame1 = tennisGame1;
        }

        public int AddScore() {
            score = tennisGame1.m_score1 += 1;
            return score;
        }
    }
}