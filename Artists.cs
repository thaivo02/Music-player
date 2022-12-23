using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using NAudio.SoundFont;
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
        public static Guna2ImageRadioButton button = null;
        public static int index = 0;
        public Artists()
        {
            InitializeComponent();
        }

        private void btnInfo(object sender, EventArgs e)
        {
            button = (Guna2ImageRadioButton)sender;
            if (button.Name.Length > 10)
                index = 10 + (int)button.Name[10] - 48;
            else index = (int)button.Name[9] - 48;
            var frm = Program.host.Services.GetRequiredService<ArtistInfo>();
            frm.Init(DockStyle.Fill, false, true);
            this.panMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
