using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class Form1 : Form
    {
        private Timer timer;

        // mouse_event API'si için gerekli sabitler
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // mouse_event API'sini tanımlayın
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
            timer = new Timer(TimerCallback, null, Timeout.Infinite, Timeout.Infinite);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Timer'ı 5 dakika (300000 ms) aralıklarla çalışacak şekilde başlat
            timer.Change(0, 300000);
        }

        private void TimerCallback(object state)
        {
            // Mevcut fare pozisyonunu al
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;

            // Sol tıklama gönder
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
