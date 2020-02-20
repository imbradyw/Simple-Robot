using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleRobot
{
    public class Robot
    {
        private enum Direction { North, East, South, West }; //Direction enumerator.
        private Direction dir; //A Direction variable.
        private Point position; //Starts the Point object.
        private const int MAXX = 209; //Sets the max value for x
        private const int MAXY = 205; //Sets the max value for y
        private const int MINX = 24; //Sets the min value for x
        private const int MINY = 12; //Sets the min value for y
        private const int MAXDISTANCE = 100; //Sets the max travel distance.

        public Robot()
        {
            dir = Direction.North; //Sets initial Direction.
            position = new Point(120, 100); //Instantiates Point object and sets start position.
        }

        public void FaceNorth() //Sets direction to north.
        {
            dir = Direction.North;
        }

        public void FaceSouth() //Sets direction to south.
        {
            dir = Direction.South;
        }

        public void FaceEast() //Sets direction to east.
        {
            dir = Direction.East;
        }

        public void FaceWest() //Sets direction to west.
        {
            dir = Direction.West;
        }

        public void GoOne() //Checks which direction is being faced and moves accordingly(1).
        {
            if (RobotTracker.distance + 1 <= MAXDISTANCE)
            {
                switch (dir)
                {
                    case Direction.North:
                        if (position.Y - 1 < MINY)
                        { }
                        else
                        {
                            position.Y -= 1;
                            RobotTracker.distance++;
                        }
                        break;

                    case Direction.South:
                        if (position.Y + 1 < MAXY)
                        { }
                        else
                        {
                            position.Y += 1;
                            RobotTracker.distance++;
                        }
                        break;

                    case Direction.East:
                        if (position.X + 1 > MAXX)
                        { }
                        else
                        {
                            position.X += 1;
                            RobotTracker.distance++;
                        }
                        break;
                    case Direction.West:
                        if (position.X - 1 < MINX)
                        { }
                        else
                        {
                            position.X -= 1;
                            RobotTracker.distance++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public void GoTen() //Checks which direction is being faced and moves accordingly(10).
        {
            if (RobotTracker.distance + 10 <= MAXDISTANCE)
            {
                switch (dir)
                {
                    case Direction.North:
                        if (position.Y - 10 < MINY)
                        { }
                        else
                        {
                            position.Y -= 10;
                            RobotTracker.distance += 10;
                        }
                        break;

                    case Direction.South:
                        if (position.Y + 10 > MAXY)
                        { }
                        else
                        {
                            position.Y += 10;
                            RobotTracker.distance += 10;
                        }
                        break;

                    case Direction.East:
                        if (position.X + 10 > MAXX)
                        { }
                        else
                        {
                            position.X += 10;
                            RobotTracker.distance += 10;
                        }
                        break;

                    case Direction.West:
                        if (position.X - 10 < MINX)
                        { }
                        else
                        {
                            position.X -= 10;
                            RobotTracker.distance += 10;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public Point GetPosition() //Returns the point object.
        {
            return position;
        }

        public int GetYCoord() //Returns Y coord
        {
            return position.Y;
        }

        public int GetXCoord() //Returns X coord
        {
            return position.X;
        }
    }
}
