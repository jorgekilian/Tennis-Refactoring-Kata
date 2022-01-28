using System;
using System.Collections.Generic;

namespace Tennis {
    public class TennisGame1 : ITennisGame {
        private readonly Player player1;
        private readonly Player player2;

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
            if (PlayersAreDeuce()) return "Deuce";

            if (PlayersHasTheSamePoints()) return $"{player1.PlayerScore()}-All";

            if (PlayersHasLessThanFortyPoints()) return $"{player1.PlayerScore()}-{player2.PlayerScore()}";

            if (AdvantagePlayer1()) return $"Advantage {player1.Name}";

            if (AdvantagePlayer2()) return "Advantage player2";

            if (Player1HasWon()) return "Win for player1";

            return "Win for player2";

        }

        private bool PlayersAreDeuce() {
            return PlayersHasTheSamePoints() && player1.HasFortyPointsOrMore();
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

