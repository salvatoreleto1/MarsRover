using System;
namespace MarsRover
{
    public class Rover
    {

        public int x; // x coordinate of the current rover pos
        public int y; // y coordinate of the current rover pos
        public string direction; // compass direction of the current rover pos

        public Rover(string NasaCommand)
        {
            Int32.TryParse(NasaCommand.Split(" ")[0], out x);
            Int32.TryParse(NasaCommand.Split(" ")[1], out y);
            direction = NasaCommand.Split(" ")[2];

        }

        public void TurnLeft()
        {
            if(direction == "N")
            {
                direction = "W";
            }
            else if(direction == "W")
            {
                direction = "S";
            }
            else if(direction == "S")
            {
                direction = "E";
            }
            else if(direction == "E")
            {
                direction = "N";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void TurnRight()
        {
            if (direction == "N")
            {
                direction = "E";
            }
            else if (direction == "E")
            {
                direction = "S";
            }
            else if (direction == "S")
            {
                direction = "W";
            }
            else if(direction == "W")
            {
                direction = "N";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void MoveToDestination(string InstructionsForRover)
        {
            char[] NasaCommand = InstructionsForRover.ToCharArray();
            for (int i = 0; i < NasaCommand.Length; i++)
            {
                if (NasaCommand[i] == 'L')
                {
                    TurnLeft();
                }
                else if(NasaCommand[i] == 'R')
                {
                    TurnRight();
                }
                else if(NasaCommand[i] == 'M')
                {
                    MoveFront();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public void MoveFront()
        {
            if (direction == "N")
            {
                y += 1;
            }
            else if (direction == "E")
            {
                x += 1;
            }
            else if (direction == "S")
            {
                y -= 1;
            }
            else if(direction == "W")
            {
                x -= 1; 
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
