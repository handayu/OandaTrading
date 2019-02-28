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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ClickTest = new System.Windows.Forms.Button();
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
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TestCOmmandLineNew = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer_AutoXY = new System.Windows.Forms.Timer(this.components);
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(228, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(233, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multicharts-CommandLine设置";
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
            this.button_DateSet.Location = new System.Drawing.Point(204, 32);
            this.button_DateSet.Margin = new System.Windows.Forms.Padding(2);
            this.button_DateSet.Name = "button_DateSet";
            this.button_DateSet.Size = new System.Drawing.Size(115, 25);
            this.button_DateSet.TabIndex = 5;
            this.button_DateSet.Text = "区间设定";
            this.button_DateSet.UseVisualStyleBackColor = true;
            this.button_DateSet.Click += new System.EventHandler(this.button_DateSet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "回测区间设置:";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox_log.ForeColor = System.Drawing.Color.Red;
            this.richTextBox_log.Location = new System.Drawing.Point(8, 249);
            this.richTextBox_log.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(483, 131);
            this.richTextBox_log.TabIndex = 3;
            this.richTextBox_log.Text = resources.GetString("richTextBox_log.Text");
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.DarkRed;
            this.button_Start.Location = new System.Drawing.Point(8, 386);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(228, 56);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "启动";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.Brown;
            this.button_Stop.Location = new System.Drawing.Point(256, 385);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(228, 56);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "暂停/继续";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.button_Clear);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBoxY);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox_TestCOmmandLineNew);
            this.groupBox4.Controls.Add(this.textBoxX);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(11, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(233, 120);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multicharts-CommandLine设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Test-Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Test_EnterClick);
            // 
            // textBox_TestCOmmandLineNew
            // 
            this.textBox_TestCOmmandLineNew.Location = new System.Drawing.Point(76, 63);
            this.textBox_TestCOmmandLineNew.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCOmmandLineNew.Name = "textBox_TestCOmmandLineNew";
            this.textBox_TestCOmmandLineNew.Size = new System.Drawing.Size(152, 21);
            this.textBox_TestCOmmandLineNew.TabIndex = 4;
            this.textBox_TestCOmmandLineNew.Text = ".csy dnum=1,from=12/31/2018, to=1/5/2019";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(147, 16);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(70, 21);
            this.textBoxX.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "SendCopyBoard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSendCopyBoard_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "测试信息:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "CommandLine-ComboxX:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(147, 40);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(70, 21);
            this.textBoxY.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "CommandLine-ComboxY:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 87);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "AutoXY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Auto_XYClick);
            // 
            // timer_AutoXY
            // 
            this.timer_AutoXY.Enabled = true;
            this.timer_AutoXY.Interval = 4000;
            this.timer_AutoXY.Tick += new System.EventHandler(this.Timer_AutoXY_TimerEvent);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(195, 86);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(33, 27);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.ClearXY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_Stop);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_TestCOmmandLineNew;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer_AutoXY;
        private System.Windows.Forms.Button button_Clear;
    }
}

