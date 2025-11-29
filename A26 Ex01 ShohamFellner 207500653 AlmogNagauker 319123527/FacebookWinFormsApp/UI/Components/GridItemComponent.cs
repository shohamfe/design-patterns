using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Models;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Logic.Managers
{
    public partial class GridItemComponent : UserControl, IPopulatable<GridItemDetails>
    {
        public GridItemComponent()
        {
            InitializeComponent();
        }

        public void Populate(GridItemDetails i_Details)
        {
            if (i_Details != null)
            {
                PictureBox.ImageLocation = i_Details.ImageUrl;
                TitleLabel.Text = i_Details.Label;

                this.Dock = DockStyle.Top;
                this.BringToFront();
            }
        }
    }
}
