using System.Media;

namespace Muzic
{
    public partial class Homepage : Form
    {
        private MusicPlayer musicPlayer = new MusicPlayer();

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
            Discover form = new Discover() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Checked = !btnPause.Checked;
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    ofd.Filter = "Mp3 Files| *.mp3";
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        musicPlayer.open(ofd.FileName);
            //    }
            //}
            //musicPlayer.play();
            //SoundPlayer soundPlayer = new SoundPlayer(@"../Songs/Alan Walker - Alone.mp3");
            //soundPlayer.Play();
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
            Discover frm = new Discover() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
    }
}