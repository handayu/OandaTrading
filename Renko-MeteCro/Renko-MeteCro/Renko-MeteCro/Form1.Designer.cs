namespace Renko_MeteCro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ins = new System.Windows.Forms.TextBox();
            this.textBox_DataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DateSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_SendCommandLines = new System.Windows.Forms.Button();
            this.textBox_CommandLineHandle = new System.Windows.Forms.TextBox();
            this.textBox_TestCommandLine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_OutputHandle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_SendNullStr = new System.Windows.Forms.Button();
            this.button_GetOutPutContent = new System.Windows.Forms.Button();
            this.textBox_GetOutPutInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.textBox_TestCommandLine);
            this.groupBox1.Controls.Add(this.textBox_CommandLineHandle);
            this.groupBox1.Controls.Add(this.button_SendCommandLines);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multicharts-CommandLine设置";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.textBox_GetOutPutInfo);
            this.groupBox2.Controls.Add(this.button_GetOutPutContent);
            this.groupBox2.Controls.Add(this.button_SendNullStr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_OutputHandle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MultiCharts-公式编辑器设置";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button_DateSet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_DataSource);
            this.groupBox3.Controls.Add(this.textBox_Ins);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试的品种设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "品种:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据源:";
            // 
            // textBox_Ins
            // 
            this.textBox_Ins.Location = new System.Drawing.Point(100, 32);
            this.textBox_Ins.Name = "textBox_Ins";
            this.textBox_Ins.Size = new System.Drawing.Size(221, 28);
            this.textBox_Ins.TabIndex = 2;
            this.textBox_Ins.Text = "CFFEX.IF HOT";
            // 
            // textBox_DataSource
            // 
            this.textBox_DataSource.Location = new System.Drawing.Point(100, 73);
            this.textBox_DataSource.Name = "textBox_DataSource";
            this.textBox_DataSource.Size = new System.Drawing.Size(221, 28);
            this.textBox_DataSource.TabIndex = 3;
            this.textBox_DataSource.Text = "MCTrader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "回测区间设置:";
            // 
            // button_DateSet
            // 
            this.button_DateSet.Location = new System.Drawing.Point(501, 33);
            this.button_DateSet.Name = "button_DateSet";
            this.button_DateSet.Size = new System.Drawing.Size(114, 27);
            this.button_DateSet.TabIndex = 5;
            this.button_DateSet.Text = "区间设定";
            this.button_DateSet.UseVisualStyleBackColor = true;
            this.button_DateSet.Click += new System.EventHandler(this.button_DateSet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "PS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(100, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "其他的设定由Multicharts默认处理，包括Renko图，周期为tic等，\r\n设定一次就可以了......";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(12, 374);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(722, 195);
            this.richTextBox_log.TabIndex = 3;
            this.richTextBox_log.Text = "设定-回测-日志开启......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "CommandLine-Combox句柄:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "测试信息:";
            // 
            // button_SendCommandLines
            // 
            this.button_SendCommandLines.Location = new System.Drawing.Point(83, 123);
            this.button_SendCommandLines.Name = "button_SendCommandLines";
            this.button_SendCommandLines.Size = new System.Drawing.Size(249, 41);
            this.button_SendCommandLines.TabIndex = 2;
            this.button_SendCommandLines.Text = "SendMessage-Str";
            this.button_SendCommandLines.UseVisualStyleBackColor = true;
            this.button_SendCommandLines.Click += new System.EventHandler(this.button_SendCommandLines_Click);
            // 
            // textBox_CommandLineHandle
            // 
            this.textBox_CommandLineHandle.Location = new System.Drawing.Point(237, 38);
            this.textBox_CommandLineHandle.Name = "textBox_CommandLineHandle";
            this.textBox_CommandLineHandle.Size = new System.Drawing.Size(103, 28);
            this.textBox_CommandLineHandle.TabIndex = 3;
            // 
            // textBox_TestCommandLine
            // 
            this.textBox_TestCommandLine.Location = new System.Drawing.Point(114, 85);
            this.textBox_TestCommandLine.Name = "textBox_TestCommandLine";
            this.textBox_TestCommandLine.Size = new System.Drawing.Size(226, 28);
            this.textBox_TestCommandLine.TabIndex = 4;
            this.textBox_TestCommandLine.Text = "TestCommandLineString";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "公式编辑器输出句柄:";
            // 
            // textBox_OutputHandle
            // 
            this.textBox_OutputHandle.Location = new System.Drawing.Point(29, 62);
            this.textBox_OutputHandle.Name = "textBox_OutputHandle";
            this.textBox_OutputHandle.Size = new System.Drawing.Size(277, 28);
            this.textBox_OutputHandle.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "获取信息:";
            // 
            // button_SendNullStr
            // 
            this.button_SendNullStr.Location = new System.Drawing.Point(19, 130);
            this.button_SendNullStr.Name = "button_SendNullStr";
            this.button_SendNullStr.Size = new System.Drawing.Size(170, 34);
            this.button_SendNullStr.TabIndex = 6;
            this.button_SendNullStr.Text = "发送空字符串清空";
            this.button_SendNullStr.UseVisualStyleBackColor = true;
            this.button_SendNullStr.Click += new System.EventHandler(this.button_SendNullStr_Click);
            // 
            // button_GetOutPutContent
            // 
            this.button_GetOutPutContent.Location = new System.Drawing.Point(191, 130);
            this.button_GetOutPutContent.Name = "button_GetOutPutContent";
            this.button_GetOutPutContent.Size = new System.Drawing.Size(142, 34);
            this.button_GetOutPutContent.TabIndex = 7;
            this.button_GetOutPutContent.Text = "获取输出内容";
            this.button_GetOutPutContent.UseVisualStyleBackColor = true;
            this.button_GetOutPutContent.Click += new System.EventHandler(this.button_GetOutPutContent_Click);
            // 
            // textBox_GetOutPutInfo
            // 
            this.textBox_GetOutPutInfo.Location = new System.Drawing.Point(120, 96);
            this.textBox_GetOutPutInfo.Name = "textBox_GetOutPutInfo";
            this.textBox_GetOutPutInfo.ReadOnly = true;
            this.textBox_GetOutPutInfo.Size = new System.Drawing.Size(186, 28);
            this.textBox_GetOutPutInfo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(757, 581);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "砖图-蒙特克罗测试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DateSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DataSource;
        private System.Windows.Forms.TextBox textBox_Ins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TestCommandLine;
        private System.Windows.Forms.TextBox textBox_CommandLineHandle;
        private System.Windows.Forms.Button button_SendCommandLines;
        private System.Windows.Forms.TextBox textBox_GetOutPutInfo;
        private System.Windows.Forms.Button button_GetOutPutContent;
        private System.Windows.Forms.Button button_SendNullStr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_OutputHandle;
        private System.Windows.Forms.Label label8;
    }
}

