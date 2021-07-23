using System;

// Rover: Position = (x y and "Z") Z can = N S E W
// Plateau: Grid of positions = (x y Z), for e.g. (0,0,N). MaxX, MaxY = 6 6
// Message: String of letters to move rover = L R M. L = TurnLeft, R = TurnRight, M = Move
// Safe Assumption: Moving forward moves by 1 grid square
// Input: 5 lines
// First line = Plateau Grid 5 5.
// Second line Rover Object = Rover position then rover message
// Then next rover object
// RoverTests spinleft/spinright/move
// Spin left/right modifies the "Z"

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
