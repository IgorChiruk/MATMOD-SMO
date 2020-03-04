using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace kr1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        smo SMO;
        smo2 SMO2;

        //Коэфициенты sleep_time - время остаовки потока, n-кол-во потоков, m-кол-во мест в очереди каждого потока l-интенсивность потока заявок , time - время
        int sleep_time = 0, time =0;
        int n, m;
        double l;


        // 3 массива с экспонентоциальным распределением
        double[] rnd_l = new double[1000000];
        double[] rnd_obr = new double[1000000];
        double[] rnd_T = new double[1000000];

        //ver_otkaza - вероятность отказа, lambda-кол-во всего запускаемых заявок L-кол-во заявок в ед. времени k- целое кол-во заявок в ед. времени
        double ver_otkaza_1 = 0,ver_otkaza_2=0;
        double L = 0, k = 0;
        int lambda = 0,lambda_quality=0;

        double ordersInSMO1 = 0, ordersInSMO2 = 0;
        double ordersInQuery1 = 0, ordersInQuery2 = 0;
        double busyCanals1 = 0, busyCanals2 = 0;

        //счетчики рандома
        int r_l = 0, r_obr = 0, r_T = 0;

        public static int success1 = 0, fail1 = 0;
        public static int success2 = 0, fail2 = 0;

        public static double average_time_in_SMO1 = 0;
        public static double average_time_in_query1 = 0;
        public static double counter_time_in_smo1 = 0;
        public static double counter_time_in_query1 = 0;

        public static double average_time_in_SMO2 = 0;
        public static double average_time_in_query2 = 0;
        public static double counter_time_in_smo2 = 0;
        public static double counter_time_in_query2 = 0;
        public Form1()
        {
            InitializeComponent();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sleep_time = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            success1 = 0; fail1 = 0;
            success2 = 0; fail2 = 0;
            lambda = 0;
            ordersInSMO1 = 0;
            ordersInSMO2 = 0;
            ordersInQuery1 = 0;
            ordersInQuery2 = 0;
            busyCanals1 = 0;
            busyCanals2 = 0;

            n = Convert.ToInt32(textBox_n.Text);
            m = Convert.ToInt32(textBox_m.Text);
            l = Convert.ToDouble(textBox_l.Text);
            lambda_quality = Convert.ToInt32(textBox_lambda.Text);

            SMO = new smo(n, m);
            SMO2 = new smo2(n, m);


            if (n >= 0 & m >= 0 & l >= 0)
            {               
                for(int i = 0; i < 10000; i++)
                {
                    rnd_l[i] = ExponentialDistribution(l);
                }

                for (int i = 0; i < 10000; i++)
                {
                    rnd_obr[i] = ExponentialDistribution(l);
                }

                for (int i = 0; i < 10000; i++)
                {
                    rnd_T[i] = ExponentialDistribution(l);
                }
            }

            start();
        }


        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        private double nextT()
        {
            if (r_T > 9999) { r_T = 0; }
            r_T++;
            return rnd_T[r_T - 1];
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        private double nextl()
        {
            if (r_l > 9999) { r_l = 0; }
            r_l++;
            return rnd_l[r_l - 1];
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        private double nextobr()
        {
            if (r_obr > 9999) { r_obr = 0; }
            r_obr++;
            return rnd_obr[r_obr - 1];
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        private void start()
        {
            while (lambda < lambda_quality)
            {
                time++;
                Generate();
                calculateFailChanse();

                ordersInSMO1 += (double)SMO.OrdersInSMO();
                ordersInSMO2 += (double)SMO2.OrdersInSMO();

                ordersInQuery1 += (double)SMO.OrdersInQuery();
                ordersInQuery2 += (double)SMO2.OrdersInQuery();

                textBox_MidleQualityOrdersInSMO1.Text = (ordersInSMO1 / (double)time).ToString();
                textBox_MidleQualityOrdersInSMO2.Text = (ordersInSMO2 / (double)time).ToString();

                textBox_MidleQualityOrdersInQuery1.Text = (ordersInQuery1 / (double)time).ToString();
                textBox_MidleQualityOrdersInQuery2.Text = (ordersInQuery2 / (double)time).ToString();

                textBox_averageTimeInSMO1.Text = (average_time_in_SMO1 / counter_time_in_smo1).ToString();
                textBox_averageTimeInSMO2.Text = (average_time_in_SMO2 / counter_time_in_smo2).ToString();

                textBox_averageTimeInQuery1.Text = (average_time_in_query1/counter_time_in_query1).ToString();
                textBox_averageTimeInQuery2.Text = (average_time_in_query2 / counter_time_in_query2).ToString();

                busyCanals1 += (double)SMO.AverageBusyCanals();
                busyCanals2 += (double)SMO2.AverageBusyCanals();

                textBox_averageTimeOfBusyCanals1.Text=(busyCanals1 / (double)time).ToString();
                textBox_averageTimeOfBusyCanals2.Text =(busyCanals2 / (double)time).ToString();

                this.Refresh();               
            }
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        private void Generate()
        {
            if (lambda == 0)
            {
                L = nextl();               
                k = k + L;
                int i = (int)Math.Truncate(k);
                k -= i;
                lambda += i;
                orderPush(i);            
            }

            else if (lambda > 0)
            {
                SMO.dec(1);
                SMO2.dec(1);
                L = nextl();
                k = k + L;
                int i = (int)Math.Truncate(k);
                k -= i;
                lambda += i;
                orderPush(i);             
            }
            Thread.Sleep(sleep_time);       
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

        private void orderPush(int i) 
        {
            while (i >= 1)
            {            
                if (SMO.incomingOrder(new Order(nextT(), nextobr()))) { success1++; }
                else { fail1++; }
                if (SMO2.incomingOrder(new Order(nextT(), nextobr()))) { success2++; }
                else { fail2++; }
                i--;
            }
        }




        private void calculateFailChanse() 
        {
            if (lambda != 0) 
            { 
                ver_otkaza_1 = (double)fail1 / (double)lambda;
                ver_otkaza_2 = (double)fail2 / (double)lambda;
            }
           
            textBox_ver_otkaza1.Text = ver_otkaza_1.ToString();
            textBox_ver_otkaza2.Text = ver_otkaza_2.ToString();
        }

        private double ExponentialDistribution(double l)
        {                   
            double λ = l;    // Параметр экспоненциального распределения
            double z = 0;
            z = -Math.Log(rand.NextDouble()) / λ;
            return z;
        }

    }
}
