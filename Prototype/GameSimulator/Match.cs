using System;
using System.Collections.Generic;

namespace SimulationEngine
{
    public enum GameSide
    {
        LeftSide,
        RightSide
    }

    public class Match
    {
        Dictionary<int, PlayerGameState> Players;

        public Match()
        {
            Players = new Dictionary<int, PlayerGameState>();
        }

        public void AddSide(MatchDayTeam team, GameSide side)
        {
            int heading = (side == GameSide.LeftSide) ? 90 : 270;

            foreach(var p in team.Players)
            {
                int playerId = p.Key;
                var fieldPosition = p.Value.InitialFieldPosition;
                var playerState = new PlayerGameState(playerId,
                                                      fieldPosition,
                                                      heading);
                Players.Add(playerState);
            }
        }

		private double DegreesToRadians(double degrees)
		{
			return degrees * Math.PI / 180;
		}

		private bool PredictMove(int playerId)
		{
			var playerState = Players
			double radians = DegreesToRadians(angle);
			double velocityX = speed * Math.Cos(radians);
			double velocityY = speed * Math.Sin(radians);

			if ((*x + velocityX) >= boundary)
			{
				*x = boundary;
			}
			else if ((*x + velocityX) <= 0)
			{
				*x = 0;
			}
			else
			{
				*x += velocityX;
			}

			if ((*y + velocityY) >= boundary)
			{
				*y = boundary;
			}
			else if ((*y + velocityY) <= 0)
			{
				*y = 0;
			}
			else
			{
				*y += velocityY;
			}

			std::cout << "Cartesian Coordinates of X,Y after speed of "
				<< speed
				<< " and angle of "
				<< angle
				<< " is :=>" << std::endl;
			std::cout << "X coord := " << std::setprecision(6) << std::fixed << *x << std::endl;
			std::cout << "Y coord := " << std::setprecision(6) << std::fixed << *y << std::endl;

			return (*x == boundary || *y == boundary || *x == 0 || y == 0) ? false : true;
		}

		private bool Move(double angle, double speed, double boundary, double* x, double* y)
		{
			double radians = DegreesToRadians(angle);
			double velocityX = speed * Math.Cos(radians);
			double velocityY = speed * Math.Sin(radians);

			if ((*x + velocityX) >= boundary)
			{
				*x = boundary;
			}
			else if ((*x + velocityX) <= 0)
			{
				*x = 0;
			}
			else
			{
				*x += velocityX;
			}

			if ((*y + velocityY) >= boundary)
			{
				*y = boundary;
			}
			else if ((*y + velocityY) <= 0)
			{
				*y = 0;
			}
			else
			{
				*y += velocityY;
			}

			std::cout << "Cartesian Coordinates of X,Y after speed of "
				<< speed
				<< " and angle of "
				<< angle
				<< " is :=>" << std::endl;
			std::cout << "X coord := " << std::setprecision(6) << std::fixed << *x << std::endl;
			std::cout << "Y coord := " << std::setprecision(6) << std::fixed << *y << std::endl;

			return (*x == boundary || *y == boundary || *x == 0 || y == 0) ? false : true;
		}
	}
}
