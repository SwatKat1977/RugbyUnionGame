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

		public int PitchWidth { get; private set; }
		public int PitchLength { get; private set; }

		public Match()
        {
            Players = new Dictionary<int, PlayerGameState>();

			// Currently the pitch details are hard coded for the purpose of
			// the prototype...
			PitchLength = 50;
			PitchWidth = 50;
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
                Players[playerId] = playerState;
            }
        }

		private double DegreesToRadians(double degrees)
		{
			return degrees * Math.PI / 180;
		}

		public void Test()
        {
			foreach (var p in Players)
            {
				PredictMove(p.Key);
            }
        }

		private Position PredictMove(int playerId)
		{
			var playerState = Players[playerId];
			var newPosition = playerState.CurrentPosition;

			var speed = 10;    // TEMPORARY HARD CODED VALUE

			// Length of pitch is X
			// Width of pitch is Y

			double radians = DegreesToRadians(playerState.Heading);
			double velocityX = speed * Math.Cos(radians);
			double velocityY = speed * Math.Sin(radians);

			if ((newPosition.X + velocityX) >= PitchLength)
			{
				newPosition.X = PitchLength;
			}
			else if ((newPosition.X + velocityX) <= -PitchLength)
			{
				newPosition.X = -PitchLength;
			}
			else
			{
				newPosition.X += velocityX;
			}

			if ((newPosition.Y + velocityY) >= PitchWidth)
			{
				newPosition.Y = PitchWidth;
			}
			else if ((newPosition.Y + velocityY) <= -PitchWidth)
			{
				newPosition.Y = -PitchWidth;
			}
			else
			{
				newPosition.Y += velocityY;
			}

			string msg = $"Player {playerId} Cartesian Coordinates of " +
				         $"X, Y after speed of {speed} and angle of " +
						 $"{playerState.Heading} is :=>";
			Console.WriteLine(msg);

			Console.WriteLine($"=> X coord := {newPosition.X}");
			Console.WriteLine($"=> Y coord := {newPosition.Y}");

			return newPosition;
		}

		//private bool Move(double angle, double speed, double boundary, double* x, double* y)
		//{
		//	double radians = DegreesToRadians(angle);
		//	double velocityX = speed * Math.Cos(radians);
		//	double velocityY = speed * Math.Sin(radians);

		//	if ((*x + velocityX) >= boundary)
		//	{
		//		*x = boundary;
		//	}
		//	else if ((*x + velocityX) <= 0)
		//	{
		//		*x = 0;
		//	}
		//	else
		//	{
		//		*x += velocityX;
		//	}

		//	if ((*y + velocityY) >= boundary)
		//	{
		//		*y = boundary;
		//	}
		//	else if ((*y + velocityY) <= 0)
		//	{
		//		*y = 0;
		//	}
		//	else
		//	{
		//		*y += velocityY;
		//	}

		//	std::cout << "Cartesian Coordinates of X,Y after speed of "
		//		<< speed
		//		<< " and angle of "
		//		<< angle
		//		<< " is :=>" << std::endl;
		//	std::cout << "X coord := " << std::setprecision(6) << std::fixed << *x << std::endl;
		//	std::cout << "Y coord := " << std::setprecision(6) << std::fixed << *y << std::endl;

		//	return (*x == boundary || *y == boundary || *x == 0 || y == 0) ? false : true;
		//}
	}
}
