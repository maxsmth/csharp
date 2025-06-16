using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
    public partial class Form1 : Form
    {   
        private int elapsedTimeInTenthSeconds = 0;
        private int currentBackgroundIndex = 0;
        private Image[] backgroundImages;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgrounds();
            ApplyTransparency();
        }
        private void InitializeBackgrounds()
        {
            try
            {
                backgroundImages = new Image[]
                {
                    Properties.Resources.bg1,
                    Properties.Resources.bg2,
                    Properties.Resources.bg3
                };

                if (backgroundImages.Length > 0 && backgroundImages[0] != null)
                {
                    this.BackgroundImage = backgroundImages[currentBackgroundIndex];
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображений: " + ex.Message);
            }
        }

        private void ApplyTransparency()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            labelTime.BackColor = Color.Transparent;
            btnStartStop.BackColor = Color.Transparent;
            btnReset.BackColor = Color.Transparent;
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "ПУСК")
            {
                btnStartStop.Text = "СТОП";
                timerMain.Start();
            }
            else
            {
                btnStartStop.Text = "ПУСК";
                timerMain.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerMain.Stop();
            elapsedTimeInTenthSeconds = 0;
            labelTime.Text = FormatTime();
            btnStartStop.Text = "ПУСК";

            if (backgroundImages != null && backgroundImages.Length > 0)
            {
                currentBackgroundIndex = (currentBackgroundIndex + 1) % backgroundImages.Length;
                this.BackgroundImage = backgroundImages[currentBackgroundIndex];
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            elapsedTimeInTenthSeconds++;
            labelTime.Text = FormatTime();
        }

        private string FormatTime()
        {
            int tenths = elapsedTimeInTenthSeconds % 10;
            int totalSeconds = elapsedTimeInTenthSeconds / 10;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            if (minutes >= 100)
            {
                minutes = 0;
                elapsedTimeInTenthSeconds = 0;
            }

            return $"{minutes:00}:{seconds:00}.{tenths}";
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
