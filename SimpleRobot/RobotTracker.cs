using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    public class RobotTracker : Robot
    {
        public static int distance;

        public RobotTracker()
        {
            
        }

        public void GoOne()
        {
            distance++;
        }

        public void GoTen()
        {
            distance += 10;
        }
    }
}
