using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KataNetHack.Console.PlayerSubsystem;

using Xunit;

namespace KataNetHack.Tests.PlayerSubsystem
{
    public class PlayerTests
    {
        [Fact]
        public void CanCreateSut()
        {
            var sut = new Player(default(Point));
        }
    }
}