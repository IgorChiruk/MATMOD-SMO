using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1
{
    // класс описания системы с n каналами и m местами общей очереди
    public class smo2 : smo
    {
        List<Order> query = new List<Order>();
        public smo2(int _k, int _q)
        {
            kanal_quality = _k;
            query_quality = _q * _k;


            for (int i = 0; i < kanal_quality; i++)
            {
                SMO.Add(new Chanel(_q));
            }
        }
    

        private double CheckProgress()
        {
            double i = 9999999;
            foreach (Chanel c in SMO) 
            { 

                if (c.getProgressTime() < i) 
                {
                    i = c.getProgressTime(); 
                } 
            }
            return i;
        }

        private int MinProgress()
        {
            int counter=0;
            double temp=0;
            for(int i = 0; i < SMO.Count; i++)
            {
                if (SMO[i].getProgressSize() > 0)
                {
                    if (SMO[i].getProgressTime() < temp)
                    {
                        counter = i;
                        temp = SMO[i].getProgressTime();
                    }
                }
            }
            return counter;
        }

        private double CheckQuery()
        {
            double i = 9999999;
            foreach (Order O in query) { if (O.getQueryTime() < i) { i = O.getQueryTime(); } }
            return i;
        }

        private int MinQuery()
        {
            int counter = 0;
            double temp = 0;
            for (int i = 0; i < query.Count; i++)
            {
                if (query[i].getQueryTime() < temp)
                {
                    counter = i;
                    temp = query[i].getQueryTime();
                }
            }
            return counter;
        }

        public override bool incomingOrder(Order order)
        {
            bool success = false;
            for (int i = 0; i < kanal_quality; i++)
            {
                if (SMO[i].addOrderToProgress(order))
                {
                    Form1.counter_time_in_smo2++;
                    Form1.average_time_in_SMO2 += order.getCompleteTime();
                    success = true;
                    return success;
                }
            }

            if (!success)
            {
                if (query.Count >= query_quality)
                {
                    return success;
                }
                else if (query.Count < query_quality)
                {
                    query.Add(order);
                    success = true;
                    return success;
                }
            }
            return success;
        }

        public override void dec(double T)
        {          
            foreach (Chanel c in SMO) { c.decQueryAndProgressTime(T); }
            foreach(Order o in query) { o.decQTime(T);o.decTime(T); }
            RemoveOrders();
        }

        private void clearQuery()
        {
            bool success = true;
            while (success)
            {
                success = false;
                for (int i = 0; i < query.Count; i++)
                {
                    if (query[i].getQueryTime() < 0)
                    {
                        Form1.counter_time_in_query2++;
                        Form1.average_time_in_query2 += query[0].getPrimordialQueryTime();
                        query.RemoveAt(0);
                        success = true;
                    }
                }
            }    
        }

        private void RemoveOrders()
        {
            double temp = CheckProgress();

            while (temp < 0)
            {
                int min_counter = MinProgress();
                if (query.Count > 0 & SMO[min_counter].getProgressSize()>0)
                {
                    if (SMO[min_counter].getProgressTime() <= query[0].getQueryTime())
                    {
                        //ордер из очереди попадает в прогресс
                        double temp_time = SMO[min_counter].getProgressTime();
                        SMO[min_counter].removeOrders(0);

                        Form1.counter_time_in_smo2++;
                        Form1.average_time_in_SMO2 += query[0].getCompleteTime();

                        Form1.counter_time_in_query2++;
                        Form1.average_time_in_query2 += (query[0].getPrimordialQueryTime()-(query[0].getQueryTime()+(0-temp_time)));

                        query[0].decTime(0-temp_time);
                        SMO[min_counter].addOrderToProgress(query[0]);
                        
                        query.RemoveAt(0);
                        temp = CheckProgress();
                    }
                    else if (SMO[min_counter].getProgressTime() > query[0].getQueryTime())
                    {
                        //ордер из очереди не попадает в прогресс

                        Form1.counter_time_in_query2++;
                        Form1.average_time_in_query2 += query[0].getPrimordialQueryTime();

                        query.RemoveAt(0);
                        Form1.fail2++;
                        Form1.success2--;
                        temp = CheckProgress();
                    }
                }
                else if (query.Count <= 0)
                {
                    SMO[min_counter].removeOrders(0);
                    temp = CheckProgress();
                }           
            }

            while (temp == 0)
            {
                if (query.Count > 0)
                {
                    double temp_query = CheckQuery();
                    while (temp_query < 0)
                    {
                        if (query.Count <= 0) { break; }
                        int min_querry_count = MinQuery();

                        Form1.counter_time_in_query2++;
                        Form1.average_time_in_query2 += query[min_querry_count].getPrimordialQueryTime();

                        query.RemoveAt(min_querry_count);
                        Form1.fail2++;
                        Form1.success2--;
                        temp_query = CheckQuery();
                    }
                }

                PushToProgress();
                if (query.Count <= 0)
                {
                    break;
                }
            }

            if (query.Count > 0)
            {
                double temp_query = CheckQuery();
                while (temp_query <= 0)
                {
                    if (query.Count <= 0) { break; }
                    int min_querry_count = MinQuery();

                    Form1.counter_time_in_query2++;
                    Form1.average_time_in_query2 += query[min_querry_count].getPrimordialQueryTime();

                    query.RemoveAt(min_querry_count);
                    Form1.fail2++;
                    Form1.success2--;
                    temp_query =CheckQuery();
                }
            }

            
        }


        private void PushToProgress()
        {
            clearQuery();
            foreach (Chanel c in SMO)
            {
                if (c.getProgressSize() == 0)
                {
                    if (query.Count > 0)
                    {
                        Form1.counter_time_in_smo2++;
                        Form1.average_time_in_SMO2 += query[0].getCompleteTime();

                        Form1.counter_time_in_query2++;
                        if (query[0].getQueryTime()>=0)
                        {
                            Form1.average_time_in_query2 += (query[0].getPrimordialQueryTime() - query[0].getQueryTime());
                        }
                        else if (query[0].getQueryTime() < 0)
                        {
                            Form1.average_time_in_query2 += (query[0].getPrimordialQueryTime());
                        }
                        

                        c.addOrderToProgress(query[0]);
                        query.RemoveAt(0);
                    }
                }
            }
        }

        public override int OrdersInSMO()
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

        public override int OrdersInQuery()
        {
            
            return query.Count;
        }

    }
}
