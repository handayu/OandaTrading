using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace Renko_MeteCro
{
    class FindWindow
    {
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

        private delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        private string m_classname;

        private IntPtr m_hWnd;
        public IntPtr FoundHandle
        {
            get { return m_hWnd; }
        }

        public FindWindow(IntPtr hwndParent, string classname)
        {
            m_hWnd = IntPtr.Zero;
            m_classname = classname;
            FindChildClassHwnd(hwndParent, IntPtr.Zero);
        }


        private bool FindChildClassHwnd(IntPtr hwndParent, IntPtr lParam)
        {
            EnumWindowProc childProc = new EnumWindowProc(FindChildClassHwnd);
            IntPtr hwnd = FindWindowEx(hwndParent, IntPtr.Zero, this.m_classname, string.Empty);
            if (hwnd != IntPtr.Zero)
            {
                this.m_hWnd = hwnd; // found: save it
                return false; // stop enumerating
            }
            EnumChildWindows(hwndParent, childProc, IntPtr.Zero); // recurse  redo FindChildClassHwnd
            return true;// keep looking
        }
    }
}

