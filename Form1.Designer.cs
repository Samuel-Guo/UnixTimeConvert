﻿namespace UnixTime
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tStamp = new System.Windows.Forms.TextBox();
            this.tToTime = new System.Windows.Forms.TextBox();
            this.tTime = new System.Windows.Forms.TextBox();
            this.tToStamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 28);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tStamp
            // 
            this.tStamp.Location = new System.Drawing.Point(204, 116);
            this.tStamp.Name = "tStamp";
            this.tStamp.Size = new System.Drawing.Size(186, 28);
            this.tStamp.TabIndex = 2;
            this.tStamp.TextChanged += new System.EventHandler(this.TStamp_TextChanged);
            // 
            // tToTime
            // 
            this.tToTime.Location = new System.Drawing.Point(421, 116);
            this.tToTime.Name = "tToTime";
            this.tToTime.Size = new System.Drawing.Size(186, 28);
            this.tToTime.TabIndex = 2;
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(204, 196);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(186, 28);
            this.tTime.TabIndex = 2;
            this.tTime.TextChanged += new System.EventHandler(this.TTime_TextChanged);
            // 
            // tToStamp
            // 
            this.tToStamp.Location = new System.Drawing.Point(421, 196);
            this.tToStamp.Name = "tToStamp";
            this.tToStamp.Size = new System.Drawing.Size(186, 28);
            this.tToStamp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unix To DateTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "DateTime to Unix";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "go?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tToStamp);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.tToTime);
            this.Controls.Add(this.tStamp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tStamp;
        private System.Windows.Forms.TextBox tToTime;
        private System.Windows.Forms.TextBox tTime;
        private System.Windows.Forms.TextBox tToStamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

