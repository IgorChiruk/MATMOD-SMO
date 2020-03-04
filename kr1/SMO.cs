using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1
{
    // класс описания системы с n каналами и в каждом канале m мест в очереди
    public class smo
    {
        protected int kanal_quality;
        protected int query_quality;
        protected List<Chanel> SMO =new List<Chanel>();
        
        public smo()
        {
           
        }

        public int AverageBusyCanals()
        {
            int result=0;
            foreach(Chanel c in SMO)
            {
                if (c.getProgressSize() > 0)
                {
                    result += c.getProgressSize();
                }
            }

            return result;
        }
        public smo(int _k,int _q)
        {
            kanal_quality = _k;
            query_quality = _q;

            for(int i = 0; i < kanal_quality; i++)
            {
                Chanel c = new Chanel(_q);
                SMO.Add(c);
            }
        }

        private int getMinQuery()
        {
            int i = 99999999;
            int result =0;
            for(int j =0;j<kanal_quality;j++)
            {
                if (i > SMO[j].getQuerySize())
                {
                    i = SMO[j].getQuerySize();
                    result = j;
                }
            }
            return result;
        }

        public virtual bool incomingOrder(Order order) 
        {
            bool success = false;
            for(int i = 0; i < kanal_quality; i++)
            {
                if (SMO[i].addOrderToProgress(order))
                {
                    Form1.counter_time_in_smo1++;
                    Form1.average_time_in_SMO1 += order.getCompleteTime();
                    success = true;
                    return success;             
                }
            }

            if (!success)
            {
                int j = getMinQuery();
                if (SMO[j].getQuerySize() >= query_quality)
                {
                    return success;
                }
                else if (SMO[j].getQuerySize() < query_quality)
                {                  
                    SMO[j].addOrderToQuery(order);
                    success = true;
                    return success;
                }
            }


            return success;
        }

        public virtual int OrdersInSMO()
        {
            int result = 0;
            foreach (Chanel c in SMO)
            {
                if (c.getProgressSize() > 0)
                {
                    result += c.getProgressSize();
                }
            }
            return result;
        }

        public virtual int OrdersInQuery()
        {
            int result = 0;
            foreach (Chanel c in SMO)
            {
                if (c.getQuerySize() > 0)
                {
                    result += c.getQuerySize();
                }
            }
            return result;
        }

        public virtual void dec(double T) 
        { 
            foreach (Chanel c in SMO) { c.removeOrders(T); }
        }
    }
}
