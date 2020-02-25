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

        //Коэфициенты sleep_time - время остаовки потока, n-кол-во потоков, m-кол-во мест в очереди каждого потока l-интенсивность потока заявок 
        int sleep_time = 1000;
        int n, m;
        double l;

        // 3 массива с экспонентоциальным распределением
        double[] rnd_l = new double[1000000];
        double[] rnd_obr = new double[1000000];
        double[] rnd_T = new double[1000000];

        //ver_otkaza - вероятность отказа, lambda-кол-во всего запускаемых заявок L-кол-во заявок в ед. времени k- целое кол-во заявок в ед. времени
        double ver_otkaza = 0;
        double L = 0, k = 0;
        int lambda = 0;

        //счетчики рандома
        int r_l = 0, r_obr = 0, r_T = 0;

        public static int success = 0, fail = 0;

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
            n = Convert.ToInt32(textBox_n.Text);
            m = Convert.ToInt32(textBox_m.Text);
            l = Convert.ToDouble(textBox_l.Text);
            
            SMO = new smo(n, m);


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

            while (lambda < 1000)
            {
                Generate();
                calculateFailChanse();
                this.Refresh();
            }


        }

        private double nextT()
        {
            if (r_T > 9999) { r_T = 0; }
            r_T++;
            return rnd_T[r_T - 1];
        }

        private double nextl()
        {
            if (r_l > 9999) { r_l = 0; }
            r_l++;
            return rnd_l[r_l - 1];
        }

        private double nextobr()
        {
            if (r_obr > 9999) { r_obr = 0; }
            r_obr++;
            return rnd_obr[r_obr - 1];
        }


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
                L = nextl();
                k = k + L;
                int i = (int)Math.Truncate(k);
                k -= i;
                lambda += i;
                orderPush(i);             
            }
            Thread.Sleep(sleep_time);          
        }

        private void orderPush(int i) 
        {
            while (i >= 1)
            {
                order O = new order(nextT(), nextobr());
                if (SMO.incomingOrder(O)) { success++; }
                else { fail++; }
                i--;
            }
        }




        private void calculateFailChanse() 
        {
            if (lambda != 0) { ver_otkaza = fail / lambda; }
           
            textBox_ver_otkaza.Text = ver_otkaza.ToString();
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
