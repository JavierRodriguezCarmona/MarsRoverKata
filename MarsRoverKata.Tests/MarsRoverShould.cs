using System;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        private MarsRover _rover;

        [SetUp]
        public void Setup()
        {
            _rover = new MarsRover(new RoverPosition(0, 0, 'N'));
        }

        [TestCase("R", 'E')]
        [TestCase("RR", 'S')]
        [TestCase("RRR", 'W')]
        [TestCase("RRRR", 'N')]
        public void ChangeOrientationAccordinglyWhenRotatingRight(string commands, char expectedDirection)
        {
            _rover.ProcessCommands(commands);

            Assert.AreEqual(new RoverPosition(0, 0, expectedDirection), _rover.CurrentPosition);
        }

        [TestCase("L", 'W')]
        [TestCase("LL", 'S')]
        [TestCase("LLL", 'E')]
        [TestCase("LLLL", 'N')]
        public void ChangeOrientationAccordinglyWhenRotatingLeft(string commands, char expectedDirection)
        {
            _rover.ProcessCommands(commands);

            Assert.AreEqual(new RoverPosition(0, 0, expectedDirection), _rover.CurrentPosition);
        }

        [TestCase('W', -1, 0)]
        [TestCase('S', 0, -1)]
        [TestCase('E', 1, 0)]
        [TestCase('N', 0, 1)]
        public void MovesToTheDirectionItIsFacingWhenMovingForward(char direction, int expectedX, int expectedY)
        {
            _rover = new MarsRover(new RoverPosition(0, 0, direction));

            _rover.ProcessCommands("F");

            Assert.AreEqual(new RoverPosition(expectedX, expectedY, direction), _rover.CurrentPosition);
        }
    }
}
