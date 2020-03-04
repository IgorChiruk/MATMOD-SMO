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
        double primordialQueryTime;
        double completeTime;

        public Order(double qtime,double ctime)
        {
            queryTime = qtime;
            completeTime = ctime;
            primordialQueryTime = qtime;
        }

        public double getQueryTime()
        {
            return this.queryTime;
        }

        public double getCompleteTime()
        {
            return this.completeTime;
        }

        public double getPrimordialQueryTime()
        {
            return this.primordialQueryTime;
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
