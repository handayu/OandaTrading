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
            this.textBox_TestCommandLine = new System.Windows.Forms.TextBox();
            this.textBox_CommandLineHandle = new System.Windows.Forms.TextBox();
            this.button_SendCommandLines = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_GetOutPutContent = new System.Windows.Forms.Button();
            this.button_SendNullStr = new System.Windows.Forms.Button();
            this.textBox_OutputHandle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DateSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DataSource = new System.Windows.Forms.TextBox();
            this.textBox_Ins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_ClickTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.button_ClickTest);
            this.groupBox1.Controls.Add(this.textBox_TestCommandLine);
            this.groupBox1.Controls.Add(this.textBox_CommandLineHandle);
            this.groupBox1.Controls.Add(this.button_SendCommandLines);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(233, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multicharts-CommandLine设置";
            // 
            // textBox_TestCommandLine
            // 
            this.textBox_TestCommandLine.Location = new System.Drawing.Point(76, 57);
            this.textBox_TestCommandLine.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCommandLine.Name = "textBox_TestCommandLine";
            this.textBox_TestCommandLine.Size = new System.Drawing.Size(152, 21);
            this.textBox_TestCommandLine.TabIndex = 4;
            this.textBox_TestCommandLine.Text = ".isy";
            // 
            // textBox_CommandLineHandle
            // 
            this.textBox_CommandLineHandle.Location = new System.Drawing.Point(158, 25);
            this.textBox_CommandLineHandle.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CommandLineHandle.Name = "textBox_CommandLineHandle";
            this.textBox_CommandLineHandle.Size = new System.Drawing.Size(70, 21);
            this.textBox_CommandLineHandle.TabIndex = 3;
            // 
            // button_SendCommandLines
            // 
            this.button_SendCommandLines.Location = new System.Drawing.Point(15, 83);
            this.button_SendCommandLines.Margin = new System.Windows.Forms.Padding(2);
            this.button_SendCommandLines.Name = "button_SendCommandLines";
            this.button_SendCommandLines.Size = new System.Drawing.Size(116, 27);
            this.button_SendCommandLines.TabIndex = 2;
            this.button_SendCommandLines.Text = "SendMessage-Str";
            this.button_SendCommandLines.UseVisualStyleBackColor = true;
            this.button_SendCommandLines.Click += new System.EventHandler(this.button_SendCommandLines_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "测试信息:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "CommandLine-Combox句柄:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.button_GetOutPutContent);
            this.groupBox2.Controls.Add(this.button_SendNullStr);
            this.groupBox2.Controls.Add(this.textBox_OutputHandle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(256, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(233, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MultiCharts-公式编辑器设置";
            // 
            // button_GetOutPutContent
            // 
            this.button_GetOutPutContent.Location = new System.Drawing.Point(127, 87);
            this.button_GetOutPutContent.Margin = new System.Windows.Forms.Padding(2);
            this.button_GetOutPutContent.Name = "button_GetOutPutContent";
            this.button_GetOutPutContent.Size = new System.Drawing.Size(95, 23);
            this.button_GetOutPutContent.TabIndex = 7;
            this.button_GetOutPutContent.Text = "获取输出内容";
            this.button_GetOutPutContent.UseVisualStyleBackColor = true;
            this.button_GetOutPutContent.Click += new System.EventHandler(this.button_GetOutPutContent_Click);
            // 
            // button_SendNullStr
            // 
            this.button_SendNullStr.Location = new System.Drawing.Point(13, 87);
            this.button_SendNullStr.Margin = new System.Windows.Forms.Padding(2);
            this.button_SendNullStr.Name = "button_SendNullStr";
            this.button_SendNullStr.Size = new System.Drawing.Size(113, 23);
            this.button_SendNullStr.TabIndex = 6;
            this.button_SendNullStr.Text = "发送空字符串清空";
            this.button_SendNullStr.UseVisualStyleBackColor = true;
            this.button_SendNullStr.Click += new System.EventHandler(this.button_SendNullStr_Click);
            // 
            // textBox_OutputHandle
            // 
            this.textBox_OutputHandle.Location = new System.Drawing.Point(19, 51);
            this.textBox_OutputHandle.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_OutputHandle.Name = "textBox_OutputHandle";
            this.textBox_OutputHandle.Size = new System.Drawing.Size(186, 21);
            this.textBox_OutputHandle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "公式编辑器输出句柄:";
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
            this.groupBox3.Location = new System.Drawing.Point(8, 132);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(481, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试的品种设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(67, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "其他的设定由Multicharts默认处理，包括Renko图，周期为tic等，\r\n设定一次就可以了......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "PS:";
            // 
            // button_DateSet
            // 
            this.button_DateSet.Location = new System.Drawing.Point(334, 22);
            this.button_DateSet.Margin = new System.Windows.Forms.Padding(2);
            this.button_DateSet.Name = "button_DateSet";
            this.button_DateSet.Size = new System.Drawing.Size(76, 18);
            this.button_DateSet.TabIndex = 5;
            this.button_DateSet.Text = "区间设定";
            this.button_DateSet.UseVisualStyleBackColor = true;
            this.button_DateSet.Click += new System.EventHandler(this.button_DateSet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "回测区间设置:";
            // 
            // textBox_DataSource
            // 
            this.textBox_DataSource.Location = new System.Drawing.Point(67, 49);
            this.textBox_DataSource.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DataSource.Name = "textBox_DataSource";
            this.textBox_DataSource.Size = new System.Drawing.Size(149, 21);
            this.textBox_DataSource.TabIndex = 3;
            this.textBox_DataSource.Text = "MCTrader";
            // 
            // textBox_Ins
            // 
            this.textBox_Ins.Location = new System.Drawing.Point(67, 21);
            this.textBox_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Ins.Name = "textBox_Ins";
            this.textBox_Ins.Size = new System.Drawing.Size(149, 21);
            this.textBox_Ins.TabIndex = 2;
            this.textBox_Ins.Text = "CFFEX.IF HOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据源:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "品种:";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(8, 249);
            this.richTextBox_log.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(483, 131);
            this.richTextBox_log.TabIndex = 3;
            this.richTextBox_log.Text = "设定-回测-日志开启......";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Brown;
            this.button_Start.Location = new System.Drawing.Point(8, 386);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(480, 56);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "启动循环回测";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_ClickTest
            // 
            this.button_ClickTest.Location = new System.Drawing.Point(135, 82);
            this.button_ClickTest.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClickTest.Name = "button_ClickTest";
            this.button_ClickTest.Size = new System.Drawing.Size(82, 27);
            this.button_ClickTest.TabIndex = 5;
            this.button_ClickTest.Text = "Test-Click";
            this.button_ClickTest.UseVisualStyleBackColor = true;
            this.button_ClickTest.Click += new System.EventHandler(this.button_ClickTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 454);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "砖图-蒙特克罗测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
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
        private System.Windows.Forms.Button button_GetOutPutContent;
        private System.Windows.Forms.Button button_SendNullStr;
        private System.Windows.Forms.TextBox textBox_OutputHandle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_ClickTest;
    }
}

