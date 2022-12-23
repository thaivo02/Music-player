using Muzic.Database.Entity;
using Muzic.Repositories.PlaylistRepositories;

namespace Muzic
{
    public partial class NewPlaylist : Form
    {
        private readonly IPlaylistRepository _playlistRepository;
        public NewPlaylist(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
            InitializeComponent();
        }

        private void btnPlaylist_create_Click(object sender, EventArgs e)
        {
            var playlist = txtPlaylist_name.Text;
            _playlistRepository.Add(new Playlist()
            {
                PlaylistName = playlist
            });
            _playlistRepository.SaveChanges();
        }
    }
}
