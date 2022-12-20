using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muzic.Database.Entity;
using Muzic.Repositories.MusicRepositories;

namespace Muzic
{
    public partial class SongInfo : Form
    {
        private readonly IMusicRepository _musicRepository;
        public SongInfo(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
            InitializeComponent();
            var music = Discover.Musics[Homepage.CurrentIndex];
            string text = System.IO.File.ReadAllText(Discover.Musics[Homepage.CurrentIndex].Lyric+".txt");
            labLyrics.Text = text;
            this.guna2HtmlLabel1.Text = music.MusicName;
            this.guna2HtmlLabel6.Text = Discover.Artists.First(e => e.ArtistId == music.ArtistId).ArtistName;
            var request1 = WebRequest.Create(music.Thumbnail);
            using (var response = request1.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                this.guna2ImageButton1.Image = (Bitmap) Image.FromStream(stream);
            }

            this.txtCmt1.Text = music.Comment;
        }

        public void Init()
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var comment = this.txtComment.Text;
            if (comment != null)
            {
                var music = Discover.Musics[Homepage.CurrentIndex];
                music.Comment = comment;
                _musicRepository.Update(music);
                _musicRepository.SaveChanges();
                this.txtCmt1.Text = comment;
            }
        }
    }
}
