namespace Tennis {
    public class Player {
        private TennisGame1 tennisGame1;
        public Player(TennisGame1 tennisGame1) {
            this.tennisGame1 = tennisGame1;
        }

        public int AddScore() {
            return tennisGame1.m_score1 += 1;
        }
    }
}