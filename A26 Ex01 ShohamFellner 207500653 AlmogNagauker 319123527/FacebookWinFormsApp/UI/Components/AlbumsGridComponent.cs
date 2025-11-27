using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class AlbumsGridComponent : UserControl
    {
        private FacebookObjectCollection<Album> m_Albums;
        private readonly List<PictureBox> m_PictureBoxes = new List<PictureBox>();

        public AlbumsGridComponent(FacebookObjectCollection<Album> i_Albums)
        {
            InitializeComponent();
            m_Albums = i_Albums;

            Populate();
        }

        public void Populate()
        {
            if (m_Albums != null)
            {
                int index = 0;
                foreach (Album album in m_Albums)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = album.PictureThumbURL;
                    pictureBox.Name = index.ToString();
                    pictureBox.Margin = new Padding(4);
                    pictureBox.Size = new System.Drawing.Size(72, 72);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 

                    m_PictureBoxes.Add(pictureBox);

                    pictureContainer.Controls.Add(pictureBox);
                }
                this.Dock = DockStyle.Top;

                this.Height = pictureContainer.Bottom + 8;
            }
        }
    }
}
