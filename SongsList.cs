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
    public partial class SongsList : Form
    {
        public SongsList()
        {
            InitializeComponent();
        }

        private void btnSongInfo(object sender, EventArgs e)
        {
            SongInfo frm = new SongInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
