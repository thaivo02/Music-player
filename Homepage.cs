using Microsoft.Extensions.DependencyInjection;
using NAudio.Wave;
using System.Drawing.Drawing2D;

namespace Muzic
{
    public partial class Homepage : Form
    {
        public static WaveOutEvent wo = new WaveOutEvent();
        public static AudioFileReader af = new AudioFileReader(@"Songs\\Lost frequencies - Back To You.mp3");
        public static int CurrentIndex = 0;
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
            btnRandom.Checked = !btnRandom.Checked;
            if (btnRandom.Checked) btnRandom.BackColor = Color.Transparent;
            else btnRandom.BackColor = Color.HotPink;
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            btnLoop.Checked = !btnLoop.Checked;
            if (btnLoop.Checked) btnLoop.BackColor = Color.Transparent;
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
            var random = new Random();
            var index = random.Next(Discover.Musics.Count);
            if (btnRandom.Checked)
            {
                index = Math.Max(0, CurrentIndex - 1);
                CurrentIndex = index;
            }
            labPlaying_name.Text = Discover.Musics[index].MusicName;
            var artist = Discover.Artists.First(e => e.ArtistId == Discover.Musics[index].ArtistId);
            labPlaying_singer.Text = artist.ArtistName;
            LoadMusic(Discover.Musics[index].URL + ".mp3");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(Discover.Musics.Count);
            if (btnRandom.Checked)
            {
                index = Math.Min(Discover.Musics.Count, CurrentIndex + 1);
                CurrentIndex = index;
            }
            labPlaying_name.Text = Discover.Musics[index].MusicName;
            var artist = Discover.Artists.First(e => e.ArtistId == Discover.Musics[index].ArtistId);
            labPlaying_singer.Text = artist.ArtistName;
            LoadMusic(Discover.Musics[index].URL + ".mp3");
        }

        private void initSound(AudioFileReader af)
        {
            wo.Init(af);
            labTime_end.Text = String.Format("{0:00}:{1:00}", (int)af.TotalTime.TotalMinutes, af.TotalTime.Seconds);
        }

        public static void LoadMusic(string url)
        {
            btnPause.Checked = false;
            wo.Stop();
            af = new AudioFileReader(url);
            wo.Init(af);
            labTime_end.Text = String.Format("{0:00}:{1:00}", (int)af.TotalTime.TotalMinutes, af.TotalTime.Seconds);
            progressTimer.Stop();
            btnPause.Checked = true;
            wo.Play();
            progressTimer.Start();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            wo.Init(af);
            labTime_end.Text = String.Format("{0:00}:{1:00}", (int)af.TotalTime.TotalMinutes, af.TotalTime.Seconds);
            wo.Volume = trackVol.Value / 100f;
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
            FormClosing += (s, a) => { closing = true; wo.Stop(); };
        }

        private void trackVol_Scroll(object sender, ScrollEventArgs e)
        {
            wo.Volume = trackVol.Value / 100f;
            btnSound.Checked =  (trackVol.Value > 0) ?  false : true;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan currentTime = (wo.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : af.CurrentTime;
                //progressBar.Value = Math.Min(progressBar.Maximum, (int)(100 * currentTime.TotalSeconds / af.TotalTime.TotalSeconds));
                labTime_start.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                progressBar.Minimum = 0;

                progressBar.Maximum = (int)(af.TotalTime.TotalSeconds);
                if (progressBar.Value <= progressBar.Maximum)
                    progressBar.Value = (int)(af.CurrentTime.TotalSeconds);
                if (progressBar.Value == progressBar.Maximum) btnPause.Checked = false;
                angle += 2;
                Invalidate();
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

        private void btnSongInfo(object sender, EventArgs e)
        {
            SongInfo frm = new SongInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private int cx = 36, cy = 36, rx = 72, ry = 72;

        private float angle;

        private void btnNew_playlist_Click(object sender, EventArgs e)
        {
            NewPlaylist newPlaylist = new NewPlaylist();
            newPlaylist.Show();

        }

        public static Bitmap image = new Bitmap(@"Homepage\Songs\backtoyou.jpg");

        public Image RoundCorners(Bitmap StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                return RoundedImage;
            }
        }
          
        private void rotateCD(object sender, PaintEventArgs e)
        {
            Image RoundedImage = RoundCorners(image, 250, Color.Transparent);
            Graphics g = e.Graphics;

            g.RotateTransform(angle, MatrixOrder.Append);
            g.TranslateTransform(cx, cy, MatrixOrder.Append);
            g.DrawImage(RoundedImage, -rx / 2, -ry / 2, rx, ry);
        }
    }
}