using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzic
{
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void btnSongsList(object sender, EventArgs e)
        {
            SongsList frm = new SongsList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
