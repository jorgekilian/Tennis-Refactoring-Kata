using System.Collections.Generic;

namespace Tennis {
    public class TennisGame1 : ITennisGame {
        private readonly Player player1;
        private readonly Player player2;
        private List<string> drawScores = new List<string> { "Love-All", "Fifteen-All", "Thirty-All" };

        public TennisGame1(string player1Name, string player2Name) {
            player1 = Player.CreatePlayer(0, player1Name);
            player2 = Player.CreatePlayer(0, player2Name);
        }

        public void WonPoint(string playerName) {
            if (playerName == player1.Name)
                player1.AddScore();
            else
                player2.AddScore();
        }

        public string GetScore() {
            string score = "";
            var tempScore = 0;
            if (PlayersAreTied()) {
                score = player1.Score > 2 ? "Deuce" : drawScores[player1.Score];
                return score;
            }

            if (player1.Score >= 4 || player2.Score >= 4) {
                var minusResult = player1.Score - player2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
                return score;
            }
            else {
                for (var i = 1; i < 3; i++) {
                    if (i == 1) tempScore = player1.Score;
                    else { score += "-"; tempScore = player2.Score; }
                    switch (tempScore) {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }

        private bool PlayersAreTied() {
            return player1.Score == player2.Score;
        }
    }
}

