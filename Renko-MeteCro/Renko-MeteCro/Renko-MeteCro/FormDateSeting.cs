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
    public partial class FormDateSeting : Form
    {
        private string m_ins = string.Empty;
        private string m_dataSource = string.Empty;

        private List<string> m_mcCommandLineList = new List<string>();

        public List<string> COMMANDLISTS
        {
            get;
            set;
        }

        public FormDateSeting()
        {
            InitializeComponent();
        }

        public FormDateSeting(string ins ,string dataSource)
        {
            InitializeComponent();

            m_ins = ins;

            m_dataSource = dataSource;
        }

        private void radioButton_focusLast_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton_focusLast.Checked)
            {
                this.label_ps.Text = "例如:上一组回测区间2018/09/01-2018/10/01,下一组回测为2018/08/31-2018/10/01,往前N组(天)";
            }
        }

        private void radioButton_focusfirst_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_focusfirst.Checked)
            {
                this.label_ps.Text = "例如:上一组回测区间2018/09/01-2018/10/01,下一组回测为2018/08/31-2018/10/02,往后N组(天)";
            }
        }

        private void radioButton_nofocus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_nofocus.Checked)
            {
                this.label_ps.Text = "例如:上一组回测区间2018/09/01-2018/10/01,下一组回测为2018/09/02-2018/10/02,平移N组(天)";
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            //CommandList赋值给属性，退出

            this.Close();
        }

        private void button_ProductCommandLines_Click(object sender, EventArgs e)
        {
            if(!radioButton_focusLast.Checked && !radioButton_focusfirst.Checked && 
                !radioButton_nofocus.Checked)
            {
                MessageBox.Show("请选择回测的区间模式...");
                return;
            }

            if(this.textBox_BackDayNum.Text == "")
            {
                MessageBox.Show("请填写回测多少组(天)...");
                return;
            }

            //MC-Command指令实例:".csy dnum=1, name=CFFEX.IF HOT, df=MCTrader, res=1 min,from=12/31/2018, to=1/5/2019"
            DateTime startDate = this.dateTimePicker_first.Value;
            DateTime endDate = this.dateTimePicker_last.Value;

            //固定终点，起始日往前推算N天生成N组CommandLine指令
            if(this.radioButton_focusLast.Checked)
            {
                //string daysNum = this.textBox_BackDayNum.Text

                //DateTime newStartDate = startDate.AddDays()
            }

            //固定起点，终点日往后推算N天生成N组CommandLine指令
            if (this.radioButton_focusLast.Checked)
            {

            }

            //平移起点和终点，同时往后推算N天生成N组CommandLine指令
            if (this.radioButton_focusLast.Checked)
            {

            }

        }
    }
}
