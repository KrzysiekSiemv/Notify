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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (titleNotify.Text != "" && textNotify.Text != "" && timeoutValue.Value != 0)
            {
                var ustawienia = Properties.Settings.Default;
                ustawienia.pathToIcon = pathToIcon.Text;
                ustawienia.titleNotify = titleNotify.Text;
                ustawienia.textNotify = textNotify.Text;
                ustawienia.timeout = (int)timeoutValue.Value;
                ustawienia.showTime = addTime.Checked;
                ustawienia.Save();
            }
            else
                MessageBox.Show("Pole tytułu oraz tekstu nie może być puste, a czas powiadomienia nie może być zerowy.", "Pola wymagane są puste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pathToIcon.Text = openFileDialog1.FileName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var ustawienia = Properties.Settings.Default;
            pathToIcon.Text = ustawienia.pathToIcon;
            titleNotify.Text = ustawienia.titleNotify;
            textNotify.Text = ustawienia.textNotify;
            timeoutValue.Value = ustawienia.timeout;
            addTime.Checked = ustawienia.showTime;
        }
    }
}
