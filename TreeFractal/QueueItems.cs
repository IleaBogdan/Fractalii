using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.TreeFractal
{
    internal class QueueItems
    {
        public int start_x, end_x, start_y, end_y, level;
        public double angle, size;
        public QueueItems(int START_X, int START_Y, int END_X, int END_Y, double ANGLE, int LEVEL, double SIZE) 
        {
            start_x =START_X;
            start_y =START_Y;
            end_x =END_X;
            end_y =END_Y;
            angle =ANGLE;
            level =LEVEL;
            size = SIZE;
        }
        public void Copy(int START_X, int START_Y, int END_X, int END_Y, double SIZE, int LEVEL, double ANGLE)
        {
            start_x = START_X;
            start_y = START_Y;
            end_x = END_X;
            end_y = END_Y;
            angle = ANGLE;
            level = LEVEL;
            size = SIZE;
        }
        public QueueItems(QueueItems q)
        {
            start_x = q.start_x;
            start_y = q.start_y;
            end_x = q.end_x;
            end_y = q.end_y;
            angle = q.angle;
            level = q.level;
            size = q.size;
        }
    }
}
