using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Renko_MeteCro
{
    public class MCData
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
        private int WM_GETTEXT = 0x0D;


        private System.Threading.Timer m_timer;

        private string m_titleMC = string.Empty;
        private string m_targetClassName = string.Empty;

        private IntPtr m_intPtr;

        private Queue<string> m_marketInfoQueue = null;

        //定时器获取文本

        public MCData(string titleMC, string targetEditHandel)
        {
            try
            {
                m_titleMC = titleMC;
                m_targetClassName = targetEditHandel;
                m_marketInfoQueue = new Queue<string>();
                //寻找窗口，不然抛出异常直接无法运行
                FindWindow f = new FindWindow((IntPtr)Convert.ToInt32(titleMC, 16), targetEditHandel);
                m_intPtr = f.FoundHandle;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void Start()
        {
            //设定开启定时器发消息
            m_timer = new System.Threading.Timer(new System.Threading.TimerCallback(tick), null, 0, 10);

        }

        void tick(object o)
        {
            const int buffer_size = 1024;
            StringBuilder buffer = new StringBuilder(buffer_size);
            SendMessage(m_intPtr, WM_GETTEXT, buffer_size, buffer);
            string str = buffer.ToString();
            if(str != "" && str != null) m_marketInfoQueue.Enqueue(str);
        }


        public string GetNextMCEditOutInfo()
        {
            string str = string.Empty;
            if (m_marketInfoQueue.Count <= 0)
            {
                return str;
            }
            else
            {
                return m_marketInfoQueue.Dequeue();
            }
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~MCData()
        {
            m_timer.Dispose();
        }
    }
}
