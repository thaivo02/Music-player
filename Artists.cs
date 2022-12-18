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
    public partial class Artists : Form
    {
        public Artists()
        {
            InitializeComponent();
        }

        private void btnInfo(object sender, EventArgs e)
        {
            ArtistInfo frm = new ArtistInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
