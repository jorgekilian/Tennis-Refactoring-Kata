using System;
using System.Collections.Generic;

namespace Tennis {
    public class TennisGame1 : ITennisGame {
        private readonly Player player1;
        private readonly Player player2;
        private readonly List<string> scores = new List<string> { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame1(string player1Name, string player2Name) {
            player1 = Player.CreatePlayer(0, player1Name);
            player2 = Player.CreatePlayer(0, player2Name);
        }

        public void WonPoint(string playerName) {
            if (playerName == player1.Name)
                player1.AddPoint();
            else
                player2.AddPoint();
        }

        public string GetScore() {
            string score = "";
            if (PlayerHasTheSamePoints()) {
                return player1.HasFortyPointsOrMore() ? "Deuce" : $"{scores[player1.Points]}-All";
            }

            if (SomePlayerHasMoreThanFortyPoints()) {
                var minusResult = player1.Points - player2.Points;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
                return score;
            }

            return $"{scores[player1.Points]}-{scores[player2.Points]}";
        }

        private bool SomePlayerHasMoreThanFortyPoints() {
            return player1.Points >= 4 || player2.Points >= 4;
        }

        private bool PlayerHasTheSamePoints() {
            return player1.Points == player2.Points;
        }
    }
}

