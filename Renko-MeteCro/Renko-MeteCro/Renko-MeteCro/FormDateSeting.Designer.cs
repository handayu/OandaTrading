namespace Renko_MeteCro
{
    partial class FormDateSeting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_first = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_last = new System.Windows.Forms.DateTimePicker();
            this.radioButton_focusLast = new System.Windows.Forms.RadioButton();
            this.radioButton_focusfirst = new System.Windows.Forms.RadioButton();
            this.radioButton_nofocus = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ps = new System.Windows.Forms.Label();
            this.richTextBox_mcCommandLineStr = new System.Windows.Forms.RichTextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ProductCommandLines = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_BackDayNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选定起始日:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选定终点日:";
            // 
            // dateTimePicker_first
            // 
            this.dateTimePicker_first.Location = new System.Drawing.Point(103, 23);
            this.dateTimePicker_first.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_first.Name = "dateTimePicker_first";
            this.dateTimePicker_first.Size = new System.Drawing.Size(166, 21);
            this.dateTimePicker_first.TabIndex = 2;
            this.dateTimePicker_first.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_last
            // 
            this.dateTimePicker_last.Location = new System.Drawing.Point(359, 18);
            this.dateTimePicker_last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_last.Name = "dateTimePicker_last";
            this.dateTimePicker_last.Size = new System.Drawing.Size(166, 21);
            this.dateTimePicker_last.TabIndex = 3;
            // 
            // radioButton_focusLast
            // 
            this.radioButton_focusLast.AutoSize = true;
            this.radioButton_focusLast.Location = new System.Drawing.Point(19, 73);
            this.radioButton_focusLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_focusLast.Name = "radioButton_focusLast";
            this.radioButton_focusLast.Size = new System.Drawing.Size(191, 16);
            this.radioButton_focusLast.TabIndex = 4;
            this.radioButton_focusLast.TabStop = true;
            this.radioButton_focusLast.Text = "固定终点,起始日往前步长为1日";
            this.radioButton_focusLast.UseVisualStyleBackColor = true;
            this.radioButton_focusLast.CheckedChanged += new System.EventHandler(this.radioButton_focusLast_CheckedChanged);
            // 
            // radioButton_focusfirst
            // 
            this.radioButton_focusfirst.AutoSize = true;
            this.radioButton_focusfirst.Location = new System.Drawing.Point(19, 101);
            this.radioButton_focusfirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_focusfirst.Name = "radioButton_focusfirst";
            this.radioButton_focusfirst.Size = new System.Drawing.Size(191, 16);
            this.radioButton_focusfirst.TabIndex = 5;
            this.radioButton_focusfirst.TabStop = true;
            this.radioButton_focusfirst.Text = "固定起点,终点日往后步长为1日";
            this.radioButton_focusfirst.UseVisualStyleBackColor = true;
            this.radioButton_focusfirst.CheckedChanged += new System.EventHandler(this.radioButton_focusfirst_CheckedChanged);
            // 
            // radioButton_nofocus
            // 
            this.radioButton_nofocus.AutoSize = true;
            this.radioButton_nofocus.Location = new System.Drawing.Point(19, 130);
            this.radioButton_nofocus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_nofocus.Name = "radioButton_nofocus";
            this.radioButton_nofocus.Size = new System.Drawing.Size(179, 16);
            this.radioButton_nofocus.TabIndex = 6;
            this.radioButton_nofocus.TabStop = true;
            this.radioButton_nofocus.Text = "起点终点同时往后,步长为1日";
            this.radioButton_nofocus.UseVisualStyleBackColor = true;
            this.radioButton_nofocus.CheckedChanged += new System.EventHandler(this.radioButton_nofocus_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "说明:";
            // 
            // label_ps
            // 
            this.label_ps.AutoSize = true;
            this.label_ps.Location = new System.Drawing.Point(59, 159);
            this.label_ps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ps.Name = "label_ps";
            this.label_ps.Size = new System.Drawing.Size(47, 12);
            this.label_ps.TabIndex = 8;
            this.label_ps.Text = "-------";
            // 
            // richTextBox_mcCommandLineStr
            // 
            this.richTextBox_mcCommandLineStr.Location = new System.Drawing.Point(9, 282);
            this.richTextBox_mcCommandLineStr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_mcCommandLineStr.Name = "richTextBox_mcCommandLineStr";
            this.richTextBox_mcCommandLineStr.Size = new System.Drawing.Size(569, 41);
            this.richTextBox_mcCommandLineStr.TabIndex = 9;
            this.richTextBox_mcCommandLineStr.Text = "";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(393, 326);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(71, 27);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(489, 326);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(71, 27);
            this.button_Confirm.TabIndex = 11;
            this.button_Confirm.Text = "确认";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_last);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(568, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "起始区间";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(569, 128);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ProductCommandLines);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_BackDayNum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(8, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(569, 59);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "回测多少组(天)";
            // 
            // button_ProductCommandLines
            // 
            this.button_ProductCommandLines.BackColor = System.Drawing.Color.Red;
            this.button_ProductCommandLines.Location = new System.Drawing.Point(366, 19);
            this.button_ProductCommandLines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ProductCommandLines.Name = "button_ProductCommandLines";
            this.button_ProductCommandLines.Size = new System.Drawing.Size(186, 27);
            this.button_ProductCommandLines.TabIndex = 12;
            this.button_ProductCommandLines.Text = "立即生成MC-Command指令";
            this.button_ProductCommandLines.UseVisualStyleBackColor = false;
            this.button_ProductCommandLines.Click += new System.EventHandler(this.button_ProductCommandLines_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "组(天)";
            // 
            // textBox_BackDayNum
            // 
            this.textBox_BackDayNum.Location = new System.Drawing.Point(65, 23);
            this.textBox_BackDayNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BackDayNum.Name = "textBox_BackDayNum";
            this.textBox_BackDayNum.Size = new System.Drawing.Size(165, 21);
            this.textBox_BackDayNum.TabIndex = 1;
            this.textBox_BackDayNum.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "回测组:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(9, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(521, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "例:.csy dnum=1, name=CFFEX.IF HOT, df=MCTrader, res=1 min,from=12/31/2018, to=1/5/" +
    "2019";
            // 
            // FormDateSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 370);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.richTextBox_mcCommandLineStr);
            this.Controls.Add(this.label_ps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_nofocus);
            this.Controls.Add(this.radioButton_focusfirst);
            this.Controls.Add(this.radioButton_focusLast);
            this.Controls.Add(this.dateTimePicker_first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDateSeting";
            this.Text = "回测日期规则设定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_first;
        private System.Windows.Forms.DateTimePicker dateTimePicker_last;
        private System.Windows.Forms.RadioButton radioButton_focusLast;
        private System.Windows.Forms.RadioButton radioButton_focusfirst;
        private System.Windows.Forms.RadioButton radioButton_nofocus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ps;
        private System.Windows.Forms.RichTextBox richTextBox_mcCommandLineStr;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_BackDayNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ProductCommandLines;
        private System.Windows.Forms.Label label6;
    }
}