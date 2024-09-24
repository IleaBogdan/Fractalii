using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.TreeFractal
{
    internal class TreeItem
    {

        // public variables
        public int start_x, end_x, start_y, end_y, level;
        public double angle, size, width;

        // first constructor
        public TreeItem(int START_X, int START_Y, int END_X, int END_Y, double ANGLE, 
            int LEVEL, double SIZE, double WIDTH) 
        {
            start_x = START_X;
            start_y = START_Y;
            end_x = END_X;
            end_y = END_Y;
            angle = ANGLE;
            level = LEVEL;
            size = SIZE;
            width = WIDTH;
        }

        public TreeItem()
        {

        }
    }
}
