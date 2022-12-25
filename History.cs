using Muzic.Database.Entity;
using Muzic.Repositories.MusicRepositories;
using System.Data;

namespace Muzic
{
    public partial class History : Form
    {
        private readonly IMusicRepository _musicRepository;
        public static List<Music> Musics = new List<Music>();
        public History(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
            InitializeComponent();
            Musics = _musicRepository.GetAll().ToList();
            DataTable _dataTable = new DataTable();
            //dataGrid.DataSource = Musics;
            var i = 0;
            Musics.ForEach(e =>
            {
                int f = e.Frequency;
                DateTime time = DateTime.Now.AddMilliseconds(e.Timestamp).ToLocalTime();
                string name = e.MusicName;
                if (f > 0) dataGrid.Rows.Add(f, time, name);
                else dataGrid.Rows.Add(f, "", name);
                i += 1;
            });
        }
    }
}
