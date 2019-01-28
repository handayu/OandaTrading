using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renko_MeteCro
{
    public class CommandLinesHooker
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

        private const int WM_SETTEXT = 0x000C;
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_SYSKEYUP = 0x0105;
        private const int WM_SETFOCUS = 0x0007;
        private IntPtr m_intPtr;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetForegroundWindow(IntPtr hWnd); //WINAPI 设置当前活动窗体的句柄
        public CommandLinesHooker(IntPtr ptr)
        {
            //初始化CommandLine的窗口句柄
            m_intPtr = ptr;
        }

        /// <summary>
        /// 发送WM_SETTEXT消息
        /// </summary>
        /// <param name="messageInfo"></param>
        public void SendMessageCommandLine(string messageInfo)
        {
            SendMessage(m_intPtr, WM_SETTEXT, IntPtr.Zero, messageInfo);

            //
            SetForegroundWindow(m_intPtr);

            SendMessage(m_intPtr, WM_SETFOCUS, IntPtr.Zero, "");
            //
            SendKeys.SendWait("{ENTER}"); //模拟键盘输入ENTER
        }

        /// <summary>
        /// 发送Click消息
        /// </summary>
        public void SendMessageClick()
        {
            //SendKeys.Send("{ENTER}"); //模拟键盘输入ENTER
        }
    }
}
