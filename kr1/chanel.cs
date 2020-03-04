using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1
{
    public class Chanel
    {
        private int query_quality;
        private List<Order> query=new List<Order>();
        private List<Order> InProgress=new List<Order>();
        public Chanel(int q) 
        {
            query_quality = q;
        }

        public bool addOrderToProgress(Order Order) 
        {
            if (InProgress.Count < 1)
            {             
                InProgress.Add(Order);
                return true;
            }          
            else { return false; }
            
        }


        public int getProgressSize()
        {
            return InProgress.Count();
        }
        public double getProgressTime()
        {
            if (InProgress.Count > 0) { 
                return InProgress[0].getCompleteTime(); 
            }
            else return 0;
        }

        public int getQuerySize()
        {
            return query.Count();
        }
        public bool addOrderToQuery(Order Order)
        {
            bool success = false;
            if (query.Count < query_quality)
            {
                query.Add(Order);
                success = true;
            }
            return success;
        }

        public void decQueryAndProgressTime(double T)
        {
            if (InProgress.Count > 0)
            {
                InProgress[0].decTime(T);

                if (query.Count > 0)
                {
                    for (int i = 0; i < query.Count; i++)
                    {
                        query[i].decQTime(T);
                    }
                }
            }
        }

/*
в этом методе происхохдит уменьшение времени на 1 тик, и проверяется не выполнен
ли был ордер находящийся в прогрессе за этот тик. Если он был выполнен проверяется
верхний ордер из очереди на то, попал ли он в прогресс за этот тик, если попал то проверяется не был ли он так же выполнен за этот тик
для этого функция рекурсивно вызывается с параметром 0*/
        public void removeOrders(double T)
        {
            decQueryAndProgressTime(T);
            if (InProgress.Count > 0)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////
                /////
                ////////////////////////////////////////////////////////////////////////////////////////////
                if (InProgress[0].getCompleteTime() > 0)
                {
                    if (query.Count > 0)
                    {
                        for (int i = 0; i < query.Count; i++)
                        {
                            if (query[i].getQueryTime() <= 0)
                            {
                                Form1.counter_time_in_query1++;
                                Form1.average_time_in_query1 += query[i].getPrimordialQueryTime();

                                query.RemoveAt(i);
                                Form1.fail1++;
                                Form1.success1--;
                            }
                        }
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////////////
                /////
                ////////////////////////////////////////////////////////////////////////////////////////////
                else if (InProgress[0].getCompleteTime() < 0)
                {
                    if (query.Count > 0)
                    {

                        if (query[0].getQueryTime() <= 0)
                        {
                            query[0].decQTime(InProgress[0].getCompleteTime());
                            if (query[0].getQueryTime() >= 0)
                            {
                                query[0].decTime(0 - InProgress[0].getCompleteTime());

                                Form1.counter_time_in_smo1++;
                                Form1.average_time_in_SMO1 += query[0].getCompleteTime();
                                Form1.counter_time_in_query1++;
                                Form1.average_time_in_query1 += (query[0].getPrimordialQueryTime()-(query[0].getQueryTime()+(0- InProgress[0].getCompleteTime())));

                                InProgress.Clear();
                                InProgress.Add(query[0]);
                                query.RemoveAt(0);
                                removeOrders(0);
                            }

                            else if (query[0].getQueryTime() < 0)
                            {
                                Form1.counter_time_in_query1++;
                                Form1.average_time_in_query1 += query[0].getPrimordialQueryTime();
                                
                                query.RemoveAt(0);
                                Form1.fail1++;
                                Form1.success1--;
                                removeOrders(0);
                            }
                        }

                        else if (query[0].getQueryTime() > 0)
                        {
                            query[0].decTime(0 - InProgress[0].getCompleteTime());

                            Form1.counter_time_in_smo1++;
                            Form1.average_time_in_SMO1 += query[0].getCompleteTime();

                            Form1.counter_time_in_query1++;
                            Form1.average_time_in_query1 += (query[0].getPrimordialQueryTime()- (query[0].getQueryTime() + (0 - InProgress[0].getCompleteTime())));

                            InProgress.Clear();
                            InProgress.Add(query[0]);
                            query.RemoveAt(0);
                            removeOrders(0);
                        }
                    }

                    else if (query.Count <= 0)
                    {
                        InProgress.Clear();
                    }

                    if (query.Count > 0)
                    {
                        for (int i = 0; i < query.Count; i++)
                        {
                            if (query[i].getQueryTime() <= 0)
                            {
                                Form1.counter_time_in_query1++;
                                Form1.average_time_in_query1 += query[i].getPrimordialQueryTime();

                                query.RemoveAt(i);
                                Form1.fail1++;
                                Form1.success1--;
                            }
                        }
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////////////
                /////
                ////////////////////////////////////////////////////////////////////////////////////////////
                else if (InProgress[0].getCompleteTime() == 0)
                {
                    if (query.Count > 0)
                    {

                        for (int i = 0; i < query.Count; i++)
                        {
                            if (query[i].getQueryTime() < 0)
                            {
                                Form1.counter_time_in_query1++;
                                Form1.average_time_in_query1 += query[i].getPrimordialQueryTime();

                                query.RemoveAt(i);
                                Form1.fail1++;
                                Form1.success1--;
                            }
                        }

                        InProgress.Clear();
                        Form1.counter_time_in_smo1++;
                        Form1.average_time_in_SMO1 += query[0].getCompleteTime();

                        Form1.counter_time_in_query1++;
                        Form1.average_time_in_query1 += (query[0].getPrimordialQueryTime() - query[0].getQueryTime());

                        InProgress.Add(query[0]);
                        query.RemoveAt(0);
                        removeOrders(0);
                    }
                    else if (query.Count <= 0)
                    {
                        InProgress.Clear();
                    }
                }
            }
            }
        }
    }
    

