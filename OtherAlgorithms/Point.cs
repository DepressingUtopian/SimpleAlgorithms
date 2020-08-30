using System;
using System.Collections.Generic;
using System.Text;

namespace OtherAlgorithms
{
    public struct Point
    {
        private string name;
        private int x;
        private int y;

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
