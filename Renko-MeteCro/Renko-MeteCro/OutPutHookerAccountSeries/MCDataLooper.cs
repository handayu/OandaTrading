using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace OutPutHookerAccountSeries
{
    public class MCDataLooper
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        private const int WM_SETTEXT = 0x000C;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
        private int WM_GETTEXT = 0x0D;

        private System.Threading.Timer m_timer = null;
        private System.Threading.Timer m_timerBackCal = null;

        private IntPtr m_intPtr;

        private int m_timeInt = int.MinValue;

        /// <summary>
        /// 收到数据事件，通知给外部
        /// </summary>
        /// <param name="data"></param>
        public delegate void ReceiveOutPutDataHandle(string data);
        public event ReceiveOutPutDataHandle EventReceiveOutPutData;

        /// <summary>
        /// 可以继续下一条指令操作，通知给外部
        /// </summary>
        public delegate void CanNextCommandLineHandle();
        public event CanNextCommandLineHandle EventCanNextCommandLine;

        /// <summary>
        /// 倒计时
        /// </summary>
        public delegate void CalLeftTimerHandle(int leftTime);
        public event CalLeftTimerHandle EventCalLeftTimer;

        //定时器获取文本

        public MCDataLooper(IntPtr outPutHandle,int timerInt)
        {
            try
            {
                m_intPtr = outPutHandle;
                m_timeInt = timerInt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void Start()
        {
            //设定开启定时器发消息
            m_timer = new System.Threading.Timer(new System.Threading.TimerCallback(tick), null, 0, m_timeInt);

        }

        public void ChangedTimerSpan(int timer)
        {
            if(m_timer != null)
            {
                m_timer.Change(0, timer);
            }
        }

        private void tick(object o)
        {

            const int buffer_size = 65536;
            StringBuilder buffer = new StringBuilder(buffer_size);
            SendMessage(m_intPtr, WM_GETTEXT, buffer_size, buffer);
            string str = buffer.ToString();

            //if (str == "" || str == null) return;

            //2.清空输出窗口
            SendMessage(m_intPtr, WM_SETTEXT, IntPtr.Zero, "");

            //3.发布收到数据事件
            RaiseReceiveDataEvent(str);

        }


        /// <summary>
        /// 发起接受数据事件
        /// </summary>
        /// <param name="data"></param>
        private void RaiseReceiveDataEvent(string data)
        {
            if (data == "" || data == null) return;
            if (EventReceiveOutPutData != null)
            {
                EventReceiveOutPutData(data);
            }
        }

        /// <summary>
        /// 发起下一条指令事件
        /// </summary>
        private void RaiseNextCommandLineEvent()
        {
            if (EventCanNextCommandLine != null)
            {
                EventCanNextCommandLine();
            }
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~MCDataLooper()
        {
            //m_timer.Dispose();
        }
    }
}
