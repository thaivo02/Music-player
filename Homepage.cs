using Microsoft.Extensions.DependencyInjection;
using NAudio.Wave;

namespace Muzic
{
    public partial class Homepage : Form
    {
        public static WaveOutEvent wo = new WaveOutEvent();
        public static AudioFileReader af = new AudioFileReader(@"Songs\\Ed Sheeran - Shape Of You.mp3");
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public Homepage()
        {
            InitializeComponent();
            var form = Program.host.Services.GetRequiredService<Discover>();
            form.Init(DockStyle.Fill, false, true);
            this.panMain.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (btnRandom.BackColor == Color.HotPink) btnRandom.BackColor = Color.Transparent;
            else btnRandom.BackColor = Color.HotPink;
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (btnLoop.BackColor == Color.HotPink) btnLoop.BackColor = Color.Transparent;
            else btnLoop.BackColor = Color.HotPink;
        }
        private void btnTrend_Click(object sender, EventArgs e)
        {
            Artists frm = new Artists() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            var frm = Program.host.Services.GetRequiredService<Discover>();
            frm.Init(DockStyle.Fill, false, true);
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            Genre frm = new Genre() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            Top frm = new Top() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        public static void LoadMusic(WaveOutEvent w, AudioFileReader a)
        {
            wo.Init(a);
            wo.Volume = trackVol.Value / 100f;
            labTime_end.Text = String.Format("{0:00}:{1:00}", (int)a.TotalTime.TotalMinutes, af.TotalTime.Seconds);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            LoadMusic(wo, af);
        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Checked = !btnPause.Checked;
            var closing = false;
            wo.PlaybackStopped += (s, a) => { if (closing) { wo.Dispose(); af.Dispose(); } };
            if (btnPause.Checked) wo.Play();
            else wo.Stop();
            if (wo.PlaybackState.ToString() == "Playing") progressTimer.Start();
            else progressTimer.Stop();
            this.FormClosing += (s, a) => { closing = true; wo.Stop(); };
        }

        private void trackVol_Scroll(object sender, ScrollEventArgs e)
        {
            wo.Volume = trackVol.Value / 100f;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan currentTime = (wo.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : af.CurrentTime;
                //trackBar.Value = Math.Min(trackBar.Maximum, (int)(100 * currentTime.TotalSeconds / inputStream.TotalTime.TotalSeconds));
                labTime_start.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                progressBar.Minimum = 0;

                progressBar.Maximum = (int)(af.TotalTime.TotalSeconds);
                if (progressBar.Value <= progressBar.Maximum)
                    progressBar.Value = (int)(af.CurrentTime.TotalSeconds);
            }
            catch
            {
                progressTimer.Stop();
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnSound.Checked = !btnSound.Checked;
            if (btnSound.Checked) wo.Volume = trackVol.Value = 0;
            else
            {
                trackVol.Value = 10;
                wo.Volume = trackVol.Value / 100f;
            }
        }
    }
}