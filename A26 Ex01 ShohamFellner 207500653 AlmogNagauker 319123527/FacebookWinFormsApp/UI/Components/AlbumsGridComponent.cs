using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class AlbumsGridComponent : UserControl, IPopulateable<FacebookObjectCollection<Album>>
    {
        private readonly List<PictureBox> r_PictureBoxes = new List<PictureBox>();

        public AlbumsGridComponent()
        {
            InitializeComponent();
        }

        public void Populate(FacebookObjectCollection<Album> i_Albums)
        {
            if (i_Albums != null)
            {
                int index = 0;
                foreach (Album album in i_Albums)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = album.PictureThumbURL;
                    pictureBox.Name = index.ToString();
                    pictureBox.Margin = new Padding(4);
                    pictureBox.Size = new System.Drawing.Size(72, 72);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 

                    r_PictureBoxes.Add(pictureBox);

                    pictureContainer.Controls.Add(pictureBox);
                }
                this.Dock = DockStyle.Top;

                this.Height = pictureContainer.Bottom + 8;
            }
        }
    }
}
