using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renko_MeteCro
{
    public partial class FormChart : Form
    {
        private int m_backTestNum = 0;

        public FormChart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 原始的output输出的数据传到这里处理并显示
        /// </summary>
        /// <param name="mcData"></param>
        public void ReceiveOutPutData(string mcData)
        {
            if (mcData == "" || mcData == null) return;

            if(this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(ReceiveOutPutData),mcData);
                return;
            }

            string[] array = mcData.Split('\n');
            List<string> arrayList = array.ToList();
            List<double> profitList = new List<double>();
            foreach(string s in arrayList)
            {
                double data = 0.00;
                double.TryParse(s, out data);
                profitList.Add(data);

                Debug.WriteLine(data);
            }

            //最后一条有/n
            if(profitList.Count > 0)
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
            for(int i = 0;i<profitList.Count;i++)
            {
                this.chart1.Series[m_backTestNum.ToString()].Points.AddXY(i, profitList[i]);
            }
        }
    }
}
