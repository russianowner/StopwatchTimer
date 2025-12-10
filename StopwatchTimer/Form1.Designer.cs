namespace StopwatchTimer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStopwatch;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Button btnStartStopwatch;
        private System.Windows.Forms.Button btnPauseStopwatch;
        private System.Windows.Forms.Button btnResetStopwatch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnPauseTimer;
        private System.Windows.Forms.Button btnResetTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStopwatch = new System.Windows.Forms.TabPage();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.btnStartStopwatch = new System.Windows.Forms.Button();
            this.btnPauseStopwatch = new System.Windows.Forms.Button();
            this.btnResetStopwatch = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnPauseTimer = new System.Windows.Forms.Button();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Stopwatch / Timer";
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Controls.Add(this.tabStopwatch);
            this.tabControl1.Controls.Add(this.tabTimer);
            this.tabStopwatch.Text = "Stopwatch";
            this.tabStopwatch.Controls.Add(this.lblStopwatch);
            this.tabStopwatch.Controls.Add(this.btnStartStopwatch);
            this.tabStopwatch.Controls.Add(this.btnPauseStopwatch);
            this.tabStopwatch.Controls.Add(this.btnResetStopwatch);
            this.lblStopwatch.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblStopwatch.Text = "00:00:00.00";
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Location = new System.Drawing.Point(50, 30);
            this.btnStartStopwatch.Text = "Start";
            this.btnStartStopwatch.Location = new System.Drawing.Point(50, 100);
            this.btnStartStopwatch.Size = new System.Drawing.Size(75, 30);
            this.btnStartStopwatch.Click += new System.EventHandler(this.btnStartStopwatch_Click);
            this.btnPauseStopwatch.Text = "Pause";
            this.btnPauseStopwatch.Location = new System.Drawing.Point(140, 100);
            this.btnPauseStopwatch.Size = new System.Drawing.Size(75, 30);
            this.btnPauseStopwatch.Click += new System.EventHandler(this.btnPauseStopwatch_Click);
            this.btnResetStopwatch.Text = "Reset";
            this.btnResetStopwatch.Location = new System.Drawing.Point(230, 100);
            this.btnResetStopwatch.Size = new System.Drawing.Size(75, 30);
            this.btnResetStopwatch.Click += new System.EventHandler(this.btnResetStopwatch_Click);
            this.tabTimer.Text = "Timer";
            this.tabTimer.Controls.Add(this.lblTimer);
            this.tabTimer.Controls.Add(this.numHours);
            this.tabTimer.Controls.Add(this.numMinutes);
            this.tabTimer.Controls.Add(this.numSeconds);
            this.tabTimer.Controls.Add(this.btnStartTimer);
            this.tabTimer.Controls.Add(this.btnPauseTimer);
            this.tabTimer.Controls.Add(this.btnResetTimer);
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(50, 30);
            this.numHours.Location = new System.Drawing.Point(50, 90);
            this.numHours.Maximum = 23;
            this.numHours.Size = new System.Drawing.Size(50, 25);
            this.numMinutes.Location = new System.Drawing.Point(110, 90);
            this.numMinutes.Maximum = 59;
            this.numMinutes.Size = new System.Drawing.Size(50, 25);
            this.numSeconds.Location = new System.Drawing.Point(170, 90);
            this.numSeconds.Maximum = 59;
            this.numSeconds.Size = new System.Drawing.Size(50, 25);
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.Location = new System.Drawing.Point(50, 130);
            this.btnStartTimer.Size = new System.Drawing.Size(75, 30);
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            this.btnPauseTimer.Text = "Pause";
            this.btnPauseTimer.Location = new System.Drawing.Point(140, 130);
            this.btnPauseTimer.Size = new System.Drawing.Size(75, 30);
            this.btnPauseTimer.Click += new System.EventHandler(this.btnPauseTimer_Click);
            this.btnResetTimer.Text = "Reset";
            this.btnResetTimer.Location = new System.Drawing.Point(230, 130);
            this.btnResetTimer.Size = new System.Drawing.Size(75, 30);
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            this.Controls.Add(this.tabControl1);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
