using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Renko_MeteCro
{
    public class CommandLinesHooker
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        private const int WM_SETTEXT = 0x000C;
        private IntPtr m_intPtr;

        public CommandLinesHooker(IntPtr ptr)
        {
            //初始化CommandLine的窗口句柄
            m_intPtr = ptr;
        }

        public void SendMessageCommandLine(string messageInfo)
        {
            SendMessage(m_intPtr, WM_SETTEXT, IntPtr.Zero, messageInfo);
        }

    }
}
