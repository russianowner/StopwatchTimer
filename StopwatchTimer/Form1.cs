#nullable disable
using System.Diagnostics;

namespace StopwatchTimer
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer uiTimer;
        private TimeSpan countdownTime;
        private bool timerRunning = false;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            uiTimer = new System.Windows.Forms.Timer();
            uiTimer.Interval = 100;
            uiTimer.Tick += UiTimer_Tick;
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabStopwatch)
            {
                lblStopwatch.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (tabControl1.SelectedTab == tabTimer)
            {
                if (timerRunning)
                {
                    if (countdownTime.TotalMilliseconds > 0)
                    {
                        countdownTime = countdownTime - TimeSpan.FromMilliseconds(100);
                        lblTimer.Text = countdownTime.ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        timerRunning = false;
                        uiTimer.Stop();
                        MessageBox.Show("Время вышло!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnStartStopwatch_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            uiTimer.Start();
        }

        private void btnPauseStopwatch_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btnResetStopwatch_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lblStopwatch.Text = "00:00:00.00";
        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                countdownTime = new TimeSpan((int)numHours.Value, (int)numMinutes.Value, (int)numSeconds.Value);
                timerRunning = true;
                uiTimer.Start();
            }
        }
        private void btnPauseTimer_Click(object sender, EventArgs e)
        {
            timerRunning = false;
        }
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            timerRunning = false;
            countdownTime = TimeSpan.Zero;
            lblTimer.Text = "00:00:00";
        }
    }
}
