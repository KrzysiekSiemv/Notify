using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showMeInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            var ustawienia = Properties.Settings.Default;
            if (!ustawienia.firstRun)
            {
                notifyIcon1.BalloonTipTitle = "Program działa!";
                notifyIcon1.BalloonTipText = "Wciśnij 2 razy na ikonę dzwonka, aby pokazało się powiadomienie. Naciśnij prawy przycisk myszy na ikonę, aby wyłączyć program lub włączyć ustawienia powiadomienia";

                notifyIcon1.ShowBalloonTip(4000);
                ustawienia.firstRun = true;
                ustawienia.Save();
            } 
        }

        private void showBallon(object sender, MouseEventArgs e)
        {
            var ustawienia = Properties.Settings.Default;
            notifyIcon1.BalloonTipTitle = ustawienia.titleNotify;
            if (ustawienia.showTime)
                notifyIcon1.BalloonTipText = ustawienia.textNotify + DateTime.Now;
            else
                notifyIcon1.BalloonTipText = ustawienia.textNotify;
            if (ustawienia.pathToIcon != "")
                notifyIcon1.Icon = new Icon(ustawienia.pathToIcon);

            notifyIcon1.ShowBalloonTip(ustawienia.timeout);
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
