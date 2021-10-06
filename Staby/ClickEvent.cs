using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staby
{
    public static class ClickEvent
    {
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        public static void Click(int x, Point lastUnMove)
        {
            
            if (x == 1)
            {
                Debug.WriteLine("Left click");
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, lastUnMove.X, lastUnMove.Y, 0, 0);
            }
            else if (x == 2)
            {
                Debug.WriteLine("right click");
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, lastUnMove.X, lastUnMove.Y, 0, 0);
            }
            else if (x == 3)
            {
                Debug.WriteLine("double click");
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, lastUnMove.X, lastUnMove.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, lastUnMove.X, lastUnMove.Y, 0, 0);
            }
            else if (x == 4)
            {
                Debug.WriteLine("Drag click");
                mouse_event(MOUSEEVENTF_LEFTDOWN, lastUnMove.X, lastUnMove.Y, 0, 0);
            }
            else if (x == 5)
            {
                Debug.WriteLine("Drop click");
                mouse_event(MOUSEEVENTF_LEFTUP, lastUnMove.X, lastUnMove.Y, 0, 0);

            }
            else { }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
    }
}
