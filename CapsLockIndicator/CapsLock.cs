using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapsLockIndicator
{
    public partial class CapsLock : Form
    {
        #region DLL Imports

        [DllImport("user32.dll")]
        internal static extern short GetKeyState(int keyCode); //current state of CapsLock


        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        #endregion

        static bool showBaloonTip = true;
        private const int VK_CAPITAL = 0x14;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        globalKeyboardHook gkh = new globalKeyboardHook();


        public CapsLock()
        {
            InitializeComponent();

            try
            {
                showBaloonTip = showBaloonTipToolStripMenuItem.Checked;

                Caps_Check();

                //windows hook
                gkh.HookedKeys.Add(Keys.CapsLock);                
                gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //toggle the icon depending on the Caps Lock state
        private void Caps_Check()
        {
            if (Console.CapsLock)
            {
                l_C_Status.BackColor = Color.Green;
                l_C_Status.Text = "ON";
                this.Icon = new Icon("ON.ico", new Size(32, 32));
                trayIndicator.Icon = new Icon("ON.ico", new Size(32, 32));
                trayIndicator.Text = "Caps Lock is ON";
                trayIndicator.BalloonTipTitle = "Caps Lock is ON";
                trayIndicator.BalloonTipText = "ON";
                if (showBaloonTip)
                {
                    trayIndicator.ShowBalloonTip(2000);
                }
            }
            else
            {
                l_C_Status.BackColor = Color.Red;
                l_C_Status.Text = "OFF";
                this.Icon = new Icon("OFF.ico", new Size(32, 32));
                trayIndicator.Icon = new Icon("OFF.ico", new Size(32, 32));
                trayIndicator.Text = "Caps Lock is OFF";
                trayIndicator.BalloonTipTitle = "Caps Lock is OFF";
                trayIndicator.BalloonTipText = "OFF";
                if (showBaloonTip)
                {
                    trayIndicator.ShowBalloonTip(2000);
                }
            }

        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gkh.unhook();
            this.Dispose();
            Application.Exit();
            this.Close();
        }

        private void showBaloonTipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showBaloonTipToolStripMenuItem.Checked)
                showBaloonTip = true;
            else
                showBaloonTip = false;
        }

        //toggle caps lock by double clicking on the icon
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            keybd_event((byte)VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event((byte)VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            Caps_Check();
        }

      
        //key press handlers
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {            
            Caps_Check();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Down");
            e.Handled = true;
        }

        void gkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Press");
            e.Handled = true;
        }

    }
}