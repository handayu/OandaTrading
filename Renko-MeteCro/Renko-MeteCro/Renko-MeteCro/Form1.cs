using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renko_MeteCro
{
    public partial class Form1 : Form
    {
        private List<string> m_commandLists = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_DateSet_Click(object sender, EventArgs e)
        {
            if(this.textBox_Ins.Text == "")
            {
                MessageBox.Show("请先设置品种...");
                return;
            }

            if (this.textBox_DataSource.Text == "")
            {
                MessageBox.Show("请先设置数据源...");
                return;
            }

            string ins = this.textBox_Ins.Text;
            string dataSource = this.textBox_DataSource.Text;

            FormDateSeting s = new FormDateSeting(ins,dataSource);
            s.ShowDialog();

            this.m_commandLists = s.COMMANDLISTS;

            if(this.m_commandLists == null || this.m_commandLists.Count <= 0 )
            {
                MessageBox.Show("设置的回测日期模式(NMC-CommandLine为空),请注意重新设置...");
                SetLog("设置的回测日期模式(NMC-CommandLine为空),请注意重新设置...");
            }

            if(this.m_commandLists != null && this.m_commandLists.Count > 0)
            {

            }
        }


        private void SetLog(string str)
        {
            this.richTextBox_log.AppendText("\n" + DateTime.Now.ToString() + ":" + "\n" + "  " + str);
        }

        private void button_SendCommandLines_Click(object sender, EventArgs e)
        {
            //
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_CommandLineHandle.Text,16);
            CommandLinesHooker hooker = new CommandLinesHooker(handle);
            hooker.SendMessageCommandLine(this.textBox_TestCommandLine.Text);
        }

        private void button_SendNullStr_Click(object sender, EventArgs e)
        {

        }

        private void button_GetOutPutContent_Click(object sender, EventArgs e)
        {

        }
    }
}
