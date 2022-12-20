using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Muzic
{
    public partial class SongsList : Form
    {
        public SongsList()
        {
            InitializeComponent();
        }

        private void btnSongInfo(object sender, EventArgs e)
        {
            SongInfo frm = Program.host.Services.GetRequiredService<SongInfo>();
            frm.Init();
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
