using System;

namespace kr1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_lambda = new System.Windows.Forms.TextBox();
            this.label_lambda = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_l = new System.Windows.Forms.TextBox();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_averageTimeOfBusyCanals2 = new System.Windows.Forms.TextBox();
            this.textBox_averageTimeOfBusyCanals1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_averageTimeInQuery2 = new System.Windows.Forms.TextBox();
            this.textBox_averageTimeInQuery1 = new System.Windows.Forms.TextBox();
            this.textBox_averageTimeInSMO2 = new System.Windows.Forms.TextBox();
            this.textBox_averageTimeInSMO1 = new System.Windows.Forms.TextBox();
            this.label_averageTimeInSMO = new System.Windows.Forms.Label();
            this.textBox_MidleQualityOrdersInQuery2 = new System.Windows.Forms.TextBox();
            this.textBox_MidleQualityOrdersInQuery1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MidleQualityOrdersInSMO2 = new System.Windows.Forms.TextBox();
            this.textBox_MidleQualityOrdersInSMO1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ver_otkaza2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ver_otkaza1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_lambda);
            this.groupBox1.Controls.Add(this.label_lambda);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_l);
            this.groupBox1.Controls.Add(this.textBox_m);
            this.groupBox1.Controls.Add(this.textBox_n);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox_lambda
            // 
            this.textBox_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_lambda.Location = new System.Drawing.Point(142, 199);
            this.textBox_lambda.Name = "textBox_lambda";
            this.textBox_lambda.Size = new System.Drawing.Size(94, 26);
            this.textBox_lambda.TabIndex = 8;
            this.textBox_lambda.Text = "1000";
            // 
            // label_lambda
            // 
            this.label_lambda.AutoSize = true;
            this.label_lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lambda.Location = new System.Drawing.Point(10, 202);
            this.label_lambda.Name = "label_lambda";
            this.label_lambda.Size = new System.Drawing.Size(126, 20);
            this.label_lambda.TabIndex = 7;
            this.label_lambda.Text = "Кол-во заявок=";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(44, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ускорить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(44, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_l
            // 
            this.textBox_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_l.Location = new System.Drawing.Point(44, 89);
            this.textBox_l.Name = "textBox_l";
            this.textBox_l.Size = new System.Drawing.Size(182, 26);
            this.textBox_l.TabIndex = 5;
            this.textBox_l.Text = "инетнсивность";
            this.textBox_l.Click += new System.EventHandler(this.textBox_l_click);
            // 
            // textBox_m
            // 
            this.textBox_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_m.Location = new System.Drawing.Point(44, 53);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(182, 26);
            this.textBox_m.TabIndex = 4;
            this.textBox_m.Text = "кол-во мест в очереди";
            this.textBox_m.Click += new System.EventHandler(this.textBox_m_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_n.Location = new System.Drawing.Point(44, 15);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(182, 26);
            this.textBox_n.TabIndex = 3;
            this.textBox_n.Text = "кол-во каналов";
            this.textBox_n.Click += new System.EventHandler(this.textBox_n_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "λ=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "m=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "n=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_averageTimeOfBusyCanals2);
            this.groupBox2.Controls.Add(this.textBox_averageTimeOfBusyCanals1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_averageTimeInQuery2);
            this.groupBox2.Controls.Add(this.textBox_averageTimeInQuery1);
            this.groupBox2.Controls.Add(this.textBox_averageTimeInSMO2);
            this.groupBox2.Controls.Add(this.textBox_averageTimeInSMO1);
            this.groupBox2.Controls.Add(this.label_averageTimeInSMO);
            this.groupBox2.Controls.Add(this.textBox_MidleQualityOrdersInQuery2);
            this.groupBox2.Controls.Add(this.textBox_MidleQualityOrdersInQuery1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_MidleQualityOrdersInSMO2);
            this.groupBox2.Controls.Add(this.textBox_MidleQualityOrdersInSMO1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_ver_otkaza2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ver_otkaza1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(478, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox_averageTimeOfBusyCanals2
            // 
            this.textBox_averageTimeOfBusyCanals2.Location = new System.Drawing.Point(170, 330);
            this.textBox_averageTimeOfBusyCanals2.Name = "textBox_averageTimeOfBusyCanals2";
            this.textBox_averageTimeOfBusyCanals2.ReadOnly = true;
            this.textBox_averageTimeOfBusyCanals2.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeOfBusyCanals2.TabIndex = 20;
            // 
            // textBox_averageTimeOfBusyCanals1
            // 
            this.textBox_averageTimeOfBusyCanals1.Location = new System.Drawing.Point(6, 330);
            this.textBox_averageTimeOfBusyCanals1.Name = "textBox_averageTimeOfBusyCanals1";
            this.textBox_averageTimeOfBusyCanals1.ReadOnly = true;
            this.textBox_averageTimeOfBusyCanals1.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeOfBusyCanals1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Среднее число занятых каналов:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Среднее время пребывания заявки в очереди:";
            // 
            // textBox_averageTimeInQuery2
            // 
            this.textBox_averageTimeInQuery2.Location = new System.Drawing.Point(170, 278);
            this.textBox_averageTimeInQuery2.Name = "textBox_averageTimeInQuery2";
            this.textBox_averageTimeInQuery2.ReadOnly = true;
            this.textBox_averageTimeInQuery2.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeInQuery2.TabIndex = 16;
            // 
            // textBox_averageTimeInQuery1
            // 
            this.textBox_averageTimeInQuery1.Location = new System.Drawing.Point(6, 278);
            this.textBox_averageTimeInQuery1.Name = "textBox_averageTimeInQuery1";
            this.textBox_averageTimeInQuery1.ReadOnly = true;
            this.textBox_averageTimeInQuery1.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeInQuery1.TabIndex = 15;
            // 
            // textBox_averageTimeInSMO2
            // 
            this.textBox_averageTimeInSMO2.Location = new System.Drawing.Point(170, 230);
            this.textBox_averageTimeInSMO2.Name = "textBox_averageTimeInSMO2";
            this.textBox_averageTimeInSMO2.ReadOnly = true;
            this.textBox_averageTimeInSMO2.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeInSMO2.TabIndex = 14;
            // 
            // textBox_averageTimeInSMO1
            // 
            this.textBox_averageTimeInSMO1.Location = new System.Drawing.Point(6, 230);
            this.textBox_averageTimeInSMO1.Name = "textBox_averageTimeInSMO1";
            this.textBox_averageTimeInSMO1.ReadOnly = true;
            this.textBox_averageTimeInSMO1.Size = new System.Drawing.Size(100, 20);
            this.textBox_averageTimeInSMO1.TabIndex = 13;
            // 
            // label_averageTimeInSMO
            // 
            this.label_averageTimeInSMO.AutoSize = true;
            this.label_averageTimeInSMO.Location = new System.Drawing.Point(42, 207);
            this.label_averageTimeInSMO.Name = "label_averageTimeInSMO";
            this.label_averageTimeInSMO.Size = new System.Drawing.Size(228, 13);
            this.label_averageTimeInSMO.TabIndex = 12;
            this.label_averageTimeInSMO.Text = "Среднее время пребывания заявки в СМО:";
            // 
            // textBox_MidleQualityOrdersInQuery2
            // 
            this.textBox_MidleQualityOrdersInQuery2.Location = new System.Drawing.Point(170, 181);
            this.textBox_MidleQualityOrdersInQuery2.Name = "textBox_MidleQualityOrdersInQuery2";
            this.textBox_MidleQualityOrdersInQuery2.Size = new System.Drawing.Size(100, 20);
            this.textBox_MidleQualityOrdersInQuery2.TabIndex = 11;
            // 
            // textBox_MidleQualityOrdersInQuery1
            // 
            this.textBox_MidleQualityOrdersInQuery1.Location = new System.Drawing.Point(6, 179);
            this.textBox_MidleQualityOrdersInQuery1.Name = "textBox_MidleQualityOrdersInQuery1";
            this.textBox_MidleQualityOrdersInQuery1.Size = new System.Drawing.Size(100, 20);
            this.textBox_MidleQualityOrdersInQuery1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Среднее число заявок в очереди:";
            // 
            // textBox_MidleQualityOrdersInSMO2
            // 
            this.textBox_MidleQualityOrdersInSMO2.Location = new System.Drawing.Point(170, 133);
            this.textBox_MidleQualityOrdersInSMO2.Name = "textBox_MidleQualityOrdersInSMO2";
            this.textBox_MidleQualityOrdersInSMO2.Size = new System.Drawing.Size(100, 20);
            this.textBox_MidleQualityOrdersInSMO2.TabIndex = 8;
            // 
            // textBox_MidleQualityOrdersInSMO1
            // 
            this.textBox_MidleQualityOrdersInSMO1.Location = new System.Drawing.Point(6, 133);
            this.textBox_MidleQualityOrdersInSMO1.Name = "textBox_MidleQualityOrdersInSMO1";
            this.textBox_MidleQualityOrdersInSMO1.Size = new System.Drawing.Size(100, 20);
            this.textBox_MidleQualityOrdersInSMO1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Среднее число заявок в СМО:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "СМО 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "СМО 1";
            // 
            // textBox_ver_otkaza2
            // 
            this.textBox_ver_otkaza2.Location = new System.Drawing.Point(157, 42);
            this.textBox_ver_otkaza2.Name = "textBox_ver_otkaza2";
            this.textBox_ver_otkaza2.ReadOnly = true;
            this.textBox_ver_otkaza2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ver_otkaza2.Size = new System.Drawing.Size(147, 20);
            this.textBox_ver_otkaza2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Вероятность оказа 2 СМО:";
            // 
            // textBox_ver_otkaza1
            // 
            this.textBox_ver_otkaza1.Enabled = false;
            this.textBox_ver_otkaza1.Location = new System.Drawing.Point(157, 12);
            this.textBox_ver_otkaza1.Name = "textBox_ver_otkaza1";
            this.textBox_ver_otkaza1.ReadOnly = true;
            this.textBox_ver_otkaza1.Size = new System.Drawing.Size(147, 20);
            this.textBox_ver_otkaza1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вероятность оказа 1 СМО:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox_n_Click(object sender, EventArgs e)
        {
            textBox_n.Text = "";
        }

        private void textBox_m_Click(object sender, EventArgs e)
        {
            textBox_m.Text = "";
        }

        private void textBox_l_click(object sender, EventArgs e)
        {
            textBox_l.Text = "";
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_l;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ver_otkaza1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_ver_otkaza2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_lambda;
        private System.Windows.Forms.Label label_lambda;
        private System.Windows.Forms.TextBox textBox_MidleQualityOrdersInQuery2;
        private System.Windows.Forms.TextBox textBox_MidleQualityOrdersInQuery1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MidleQualityOrdersInSMO2;
        private System.Windows.Forms.TextBox textBox_MidleQualityOrdersInSMO1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_averageTimeOfBusyCanals2;
        private System.Windows.Forms.TextBox textBox_averageTimeOfBusyCanals1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_averageTimeInQuery2;
        private System.Windows.Forms.TextBox textBox_averageTimeInQuery1;
        private System.Windows.Forms.TextBox textBox_averageTimeInSMO2;
        private System.Windows.Forms.TextBox textBox_averageTimeInSMO1;
        private System.Windows.Forms.Label label_averageTimeInSMO;
    }
}

