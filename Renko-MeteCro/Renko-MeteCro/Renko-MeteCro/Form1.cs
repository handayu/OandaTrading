using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private MCDataLooper m_looper = null;
        private CommandLinesHooker m_CommandLineHooker = null;

        private bool m_switchTrade = false;

        private FormChart m_chart = null;

        private List<string> m_commandLists = new List<string>();

        public Form1()
        {
            InitializeComponent();

            this.button_Stop.Enabled = false;
            this.button_Stop.BackColor = Color.DarkGray;
        }

        private void button_DateSet_Click(object sender, EventArgs e)
        {
            if (this.textBox_Ins.Text == "")
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

            FormDateSeting s = new FormDateSeting(ins, dataSource);
            s.ShowDialog();

            this.m_commandLists = s.COMMANDLISTS;

            if (this.m_commandLists == null || this.m_commandLists.Count <= 0)
            {
                MessageBox.Show("设置的回测日期模式(NMC-CommandLine为空),请注意重新设置...");
                SetLog("设置的回测日期模式(NMC-CommandLine为空),请注意重新设置...");
            }

            if (this.m_commandLists != null && this.m_commandLists.Count > 0)
            {

            }
        }


        private void SetLog(string str)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(SetLog), str);
                return;
            }

            //让文本框获取焦点，不过注释这行也能达到效果
            richTextBox_log.Focus();
            //设置光标的位置到文本尾   
            richTextBox_log.Select(richTextBox_log.TextLength, 0);
            //滚动到控件光标处   
            richTextBox_log.ScrollToCaret();

            this.richTextBox_log.AppendText("\n" + DateTime.Now.ToString() + ":" + "\n" + "  " + str);
        }

        private void button_SendCommandLines_Click(object sender, EventArgs e)
        {
            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_CommandLineHandle.Text, 16);
                CommandLinesHooker hooker = new CommandLinesHooker(handle);
                hooker.SendMessageCommandLine(this.textBox_TestCommandLine.Text);

                if (m_CommandLineHooker == null)
                {
                    m_CommandLineHooker = new CommandLinesHooker(handle);
                }

                SetLog("已测试完命令Combox输入，请检查MC-CommandCombox...");
            }
            catch(Exception ex)
            {
                SetLog(string.Format("测试完命令Combox输入发生异常,请检查句柄可能的错误:{0}...",ex.Message));
            }
        }

        private void button_SendNullStr_Click(object sender, EventArgs e)
        {
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_OutputHandle.Text, 16);
            McOutPutWndHooker hooker = new McOutPutWndHooker(handle);
            hooker.SendMessageToOutPutWnd("");

            if (m_looper == null)
            {
                m_looper = new MCDataLooper(handle);
            }

            SetLog("已测试完清空输出窗口，请检查MC输出窗口...");

        }

        private void button_GetOutPutContent_Click(object sender, EventArgs e)
        {
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_OutputHandle.Text, 16);
            McOutPutWndHooker hooker = new McOutPutWndHooker(handle);
            string result = hooker.SendMessageToHoldOutPutMessage();

            if (m_looper == null)
            {
                m_looper = new MCDataLooper(handle);
            }

            SetLog("已测试完获取输出窗口的当前信息，请检查，信息如下...");
            this.richTextBox_log.AppendText("\n" + result);
        }


        private void button_Start_Click(object sender, EventArgs e)
        {
            //判断主引擎
            if (m_looper == null)
            {
                MessageBox.Show("还未测试通过Output窗口Hooker，请先通过测试...");
                SetLog("还未测试通过Output窗口Hooker，请先通过测试...");
                return;
            }
            SetLog("主引擎通过测试-成功...");

            //判断CommandHooker测试引擎
            if (m_CommandLineHooker == null)
            {
                MessageBox.Show("还未测试通过CommandHooker测试，请先通过测试...");
                SetLog("还未测试通过ComandLineHooker，请先通过测试...");
                return;
            }

            SetLog("CommandLineHooker通过测试-成功...");

            //判断是否有指令集
            if (m_commandLists == null || m_commandLists.Count <= 0)
            {
                MessageBox.Show("还未设置要回测的时间区间，请先设置区间...");
                SetLog("还未设置要回测的时间区间，请先设置区间...");
                return;
            }
            SetLog("M_commandLists设置完毕-成功...");

            //弹出图线窗口
            m_chart = new FormChart();
            m_chart.Show();
            m_chart.TopMost = true;
            SetLog("图线阵列通过测试-成功...");


            //订阅两个事件
            m_looper.EventReceiveOutPutData += m_chart.ReceiveOutPutData;
            m_looper.EventCanNextCommandLine += M_looper_EventCanNextCommandLine;
            SetLog("主引擎事件订阅通过-成功...");


            //启动循环
            m_looper.Start();
            SetLog("启动主引擎通过-成功...");

            //发送第一条CommandLine指令
            SetLog("准备发送第一条CommandLine指令...");
            //if(m_commandLists == null || m_commandLists.Count <= 0)
            //{
            //    SetLog("CommandList为空，请先添加回测区间时间规则...");
            //    return;
            //};

            //
            //m_CommandLineHooker.SendMessageCommandLine(m_commandLists[0]);
            //因为主图引用附图的原因，主图tick和附图砖要是相同的时间区间长度，所以主图dnum=1,dnum=2都要同时改变
            m_CommandLineHooker.SendMessageCommandLine(".csy dnum=2,from=12/31/2018, to=1/5/2019");
            m_CommandLineHooker.SendMessageCommandLine(".csy dnum=1,from=12/31/2018, to=1/5/2019");

            //记得要在这里发送Click事件，否则图标不会拉出来MC
            m_CommandLineHooker.SendMessageClick();

            SetLog("发送第一条CommandLine指令-成功，进入循环...");

            this.button_Start.Enabled = false;
            this.button_Start.BackColor = Color.DarkGray;


            this.button_Stop.Enabled = true;
            this.button_Stop.BackColor = Color.Red;

            m_switchTrade = true;
        }

        /// <summary>
        /// 继续处理下一条Command指令
        /// </summary>
        private void M_looper_EventCanNextCommandLine()
        {
            if (m_switchTrade == false) return;
            //始终取第一条去发送处理，最后把这条记录删除掉
            if (m_commandLists.Count > 0)
            {
                //因为主图引用附图的原因，主图tick和附图砖要是相同的时间区间长度，所以主图dnum=1,dnum=2都要同时改变
                //在这里把commandLIne的dnum后1改为2同步一起再发送一遍
                //.csy dnum=2,from=12/31/2018,to=1/5/2019
                string commandLine = m_commandLists[0];
                string commandLine2 = string.Empty;

                for(int i = 0;i< commandLine.Length;i++)
                {
                    if(i == 10)
                    {
                        commandLine2 = commandLine2 + '2';
                    }
                    else
                    {
                        commandLine2 = commandLine2 + commandLine[i];
                    }
                }

                m_CommandLineHooker.SendMessageCommandLine(commandLine2);
                m_CommandLineHooker.SendMessageCommandLine(commandLine);


                SetLog(string.Format("发送CommandLine指令:{0}-成功，继续下一个区间回测...", commandLine));

                m_commandLists.RemoveAt(0);
            }
        }

        private void button_ClickTest_Click(object sender, EventArgs e)
        {
            //
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_CommandLineHandle.Text, 16);
            CommandLinesHooker hooker = new CommandLinesHooker(handle);
            hooker.SendMessageClick();

            if (m_CommandLineHooker == null)
            {
                m_CommandLineHooker = new CommandLinesHooker(handle);
            }

            SetLog("已测试完命令Combox点击，请检查MC-CommandCombox...");
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            //< add key = "CommandLineHandle" value = ""/>
            //< add key = "MCOutPutHandle" value = ""/>
            //< add key = "CommandLineTest" value = ""/>    
            //< add key = "Instrument" value = ""/>           
            //< add key = "DataSource" value = ""/>

            ConfigurationManager.AppSettings["CommandLineHandle"] = this.textBox_CommandLineHandle.Text;
            ConfigurationManager.AppSettings["MCOutPutHandle"] = this.textBox_OutputHandle.Text;
            ConfigurationManager.AppSettings["CommandLineTest"] = this.textBox_TestCommandLine.Text;
            ConfigurationManager.AppSettings["Instrument"] = this.textBox_Ins.Text;
            ConfigurationManager.AppSettings["DataSource"] = this.textBox_DataSource.Text;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //< add key = "CommandLineHandle" value = ""/>
            //< add key = "MCOutPutHandle" value = ""/>
            //< add key = "CommandLineTest" value = ""/>    
            //< add key = "Instrument" value = ""/>           
            //< add key = "DataSource" value = ""/>

            this.textBox_CommandLineHandle.Text = ConfigurationManager.AppSettings["CommandLineHandle"];
            this.textBox_OutputHandle.Text = ConfigurationManager.AppSettings["MCOutPutHandle"];
            this.textBox_TestCommandLine.Text = ConfigurationManager.AppSettings["CommandLineTest"];
            this.textBox_Ins.Text = ConfigurationManager.AppSettings["Instrument"];
            this.textBox_DataSource.Text = ConfigurationManager.AppSettings["DataSource"];
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if(m_switchTrade)
            {
                m_switchTrade = false;
            }
            else
            {
                m_switchTrade = true;

                //始终取第一条去发送处理，最后把这条记录删除掉
                if (m_commandLists.Count > 0)
                {
                    string commandLine = m_commandLists[0];
                    m_CommandLineHooker.SendMessageCommandLine(commandLine);

                    SetLog(string.Format("继续发送CommandLine指令:{0}-成功，继续下一个区间回测...", commandLine));

                    m_commandLists.RemoveAt(0);
                }
            }
        }
    }
}
