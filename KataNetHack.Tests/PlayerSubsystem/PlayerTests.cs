using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KataNetHack.Console.PlayerSubsystem;

using Moq;

using Xunit;

namespace KataNetHack.Tests.PlayerSubsystem
{
    public class PlayerTests
    {
        [Fact]
        public void CanCreateSut()
        {
            var sut = CreateSut();
        }

        [Fact]
        public void MoveNorthSuccessfullyDecrementsYPosition()
        {
            var sut = CreateSut();
            int expectedYPosition = sut.Y - 1;

            sut.MoveNorth();

            Assert.Equal(expectedYPosition, sut.Y);
        }

        [Fact]
        public void MoveSouthSuccessfullyIncrementsYPosition()
        {
            var sut = CreateSut();
            int expectedYPosition = sut.Y + 1;

            sut.MoveSouth();

            Assert.Equal(expectedYPosition, sut.Y);
        }

        private static Player CreateSut()
        {
            return new Player(Mock.Of<IMap>());
        }
    }
}