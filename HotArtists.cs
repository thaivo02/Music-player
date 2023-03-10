using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace Muzic
{
    public partial class HotArtists : Form
    {
        public static Guna2ImageRadioButton button = new Guna2ImageRadioButton();
        public static int index = 0;
        public HotArtists()
        {
            InitializeComponent();
        }

        public void btnInfo(object sender, EventArgs e)
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
