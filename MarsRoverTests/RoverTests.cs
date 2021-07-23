using System;
using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class RoverTests  
    {
        [Fact]
        public void TurnLeft() // check if turning left works
        {
            //arrange - init objec
            Rover rover = new Rover("1 2 N");

            //act - call method to test
            rover.TurnLeft();

            //assert - verify the test is a pass or fail
            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void TurnRight() // check if turning right works
        {
            //arrange - init object
            Rover rover = new Rover("1 2 W");

            //act - call method to test
            rover.TurnRight();

            //assert - verify the test is a pass or fail
            Assert.Equal("N", rover.direction);
        }

        [Fact]
        public void MoveFront() // check if moving on grid works
        {
            //arrange - init object
            Rover rover = new Rover("1 3 S");

            //act - call method to test
            rover.MoveFront();

            //assert - verify the test is a pass or fail
            Assert.Equal(2, rover.y);
        }

        // check if command from nasa works
        // LMLMLMLMM OR MMRMMRMRRM
        [Fact]
        public void MoveToDestination()
        {
            //arrange - init object
            Rover rover = new Rover("3 3 E"); // starting position

            //act - call method to test
            rover.MoveToDestination("MMRMMRMRRM"); // nasa command

            //assert - verify the test is a pass or fail
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction); //end position

        }
    }
}
