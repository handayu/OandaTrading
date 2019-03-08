using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutPutHookerAccountSeries
{
    public partial class Form1 : Form
    {
        private MCDataLooper m_looper = null;
        private int m_backTestNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SendNullStr_Click(object sender, EventArgs e)
        {
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_OutputHandle.Text, 16);
            McOutPutWndHooker hooker = new McOutPutWndHooker(handle);
            hooker.SendMessageToOutPutWnd("");

            int timer = int.MinValue;
            int.TryParse(this.textBox_timer.Text, out timer);


            if (m_looper == null)
            {
                m_looper = new MCDataLooper(handle, timer);
            }
        }

        private void button_GetOutPutContent_Click(object sender, EventArgs e)
        {
            IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_OutputHandle.Text, 16);
            McOutPutWndHooker hooker = new McOutPutWndHooker(handle);
            string result = hooker.SendMessageToHoldOutPutMessage();

            int timer = int.MinValue;
            int.TryParse(this.textBox_timer.Text, out timer);


            if (m_looper == null)
            {
                m_looper = new MCDataLooper(handle, timer);
            }

            this.richTextBox1.AppendText("\n" + result);
        }

        private void Start_Looping(object sender, EventArgs e)
        {
            if (m_looper != null)
            {
                m_looper.EventReceiveOutPutData += M_looper_EventReceiveOutPutData;
                m_looper.Start();
            }
        }

        private void M_looper_EventReceiveOutPutData(string mcData)
        {
            if (mcData == "" || mcData == null) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(M_looper_EventReceiveOutPutData), mcData);
                return;
            }

            string[] array = mcData.Split('\n');
            List<string> arrayList = array.ToList();
            List<double> profitList = new List<double>();
            foreach (string s in arrayList)
            {
                double data = 0.00;
                double.TryParse(s, out data);
                profitList.Add(data);
            }

            //最后一条有/n
            if (profitList.Count > 0)
            {
                profitList.RemoveAt(profitList.Count - 1);
            }
            //回来的数据只要盈亏点数即可，其余的全部不要都可以。只看整体。

            //数据要拆分成List然后添加进去，因为基本和时间没有关系，我们只看
            //总体的资金曲线的整体布局，所以横坐标用自然数数列即可。
            //把mc获取回来的数据简单的分为[1，盈亏]即可。

            m_backTestNum = m_backTestNum + 1;

            //1.增加一条线。
            System.Windows.Forms.DataVisualization.Charting.Series serieNum = new System.Windows.Forms.DataVisualization.Charting.Series();
            serieNum.ChartArea = "ChartArea1";
            serieNum.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //serieNum.Legend = "Legend1";
            serieNum.Name = m_backTestNum.ToString();
            this.chart1.Series.Add(serieNum);

            //2.把数据加进去即可。
            for (int i = 0; i < profitList.Count; i++)
            {
                this.chart1.Series[m_backTestNum.ToString()].Points.AddXY(i, profitList[i]);
            }
        }

        private void TextChange_ChangeTimeSpan(object sender, EventArgs e)
        {
            string text = this.textBox_timer.Text;
            int timer = int.MinValue;
            int.TryParse(text, out timer);

            if(this.m_looper != null && timer > 0)
            {
                m_looper.ChangedTimerSpan(timer);
            }
        }
    }
}
