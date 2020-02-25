using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1
{
   public class smo2:smo
    {
        List<Order> query = new List<Order>();
        public smo2(int _k,int _q)
        {
            kanal_quality = _k;
            query_quality = _q*_k;
            

            for (int i = 0; i < kanal_quality; i++)
            {
                Chanel c = new Chanel(_q);
                SMO.Add(c);
            }
        }
       

        public override bool incomingOrder(Order order)
        {
            bool success = false;
            for (int i = 0; i < kanal_quality; i++)
            {
                if (SMO[i].addOrderToProgress(order))
                {
                    success = true;
                    return success;
                }
            }
            return success;
        }

        public override void dec(double T)
        {
            foreach (Chanel c in SMO) { c.removeOrders(T); }
        }

    }
}
