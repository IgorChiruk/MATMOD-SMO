using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1
{
    public class Order
    {
        double queryTime;
        double completeTime;

        public Order(double qtime,double ctime)
        {
            queryTime = qtime;
            completeTime = ctime;
        }

        public double getQueryTime()
        {
            return this.queryTime;
        }

        public double getCompleteTime()
        {
            return this.completeTime;
        }

        public void decTime(double T) 
        {
            completeTime -= T;
        }

        public void decQTime(double T)
        {
            queryTime -= T;
        }
    }
}
