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
            if (PlayersHasTheSamePoints()) return player1.HasFortyPointsOrMore() ? "Deuce" : $"{PlayerScore(player1, scores)}-All";

            if (PlayersHasLessThanFortyPoints()) return $"{scores[player1.Points]}-{scores[player2.Points]}";

            if (AdvantagePlayer1()) return "Advantage player1";

            if (AdvantagePlayer2()) return "Advantage player2";

            if (Player1HasWon()) return "Win for player1";

            return "Win for player2";

        }

        private static string PlayerScore(Player player, List<string> list) {
            return list[player.Points];
        }

        private bool Player1HasWon() {
            return PointDifferential() >= 2;
        }

        private bool AdvantagePlayer2() {
            return PointDifferential() == -1;
        }

        private bool AdvantagePlayer1() {
            return PointDifferential() == 1;
        }

        private int PointDifferential() {
            return player1.Points - player2.Points;
        }

        private bool PlayersHasLessThanFortyPoints() {
            return player1.Points < 4 && player2.Points < 4;
        }

        private bool PlayersHasTheSamePoints() {
            return player1.Points == player2.Points;
        }
    }
}

