using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KataNetHack.Console.PlayerSubsystem
{
    public class Player
    {
        public Player(IMap map)
        {
            Map = map;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public IMap Map { get; private set; }

        public void MoveNorth()
        {
            Y--;
        }

        public void MoveSouth()
        {
            Y++;
        }

        public void MoveWest()
        {
        }

        public void MoveEast()
        {
        }
    }

    public interface IMap
    {
        bool CanMoveTo(int x, int y);
    }

    public class Map : IMap
    {
        public bool CanMoveTo(int x, int y)
        {
            return true;
        }
    }
}