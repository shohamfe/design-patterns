using BasicFacebookFeatures.Interfaces;
using BasicFacebookFeatures.Logic.Managers;
using BasicFacebookFeatures.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI.Components
{
    public partial class TitledGridComponent : UserControl, IPopulateable<TitledGridDetails>
    {

        private const int k_MaxHeight = 300;

        public TitledGridComponent()
        {
            InitializeComponent();
        }

        public void Populate(TitledGridDetails i_Data)
        {
            if (i_Data != null && i_Data.RawData != null && i_Data.RawData.Count > 0)
            {
                TitleLabel.Text = i_Data.Title;

                cleanGrid();

                // TODO: add suspend layout usage in the rest of the code
                ItemsGrid.SuspendLayout();

                foreach (GridItemDetails itemDetails in i_Data.Items)
                {
                    GridItemComponent gridItem = new GridItemComponent();

                    gridItem.Populate(itemDetails);

                    ItemsGrid.Controls.Add(gridItem);
                }

                ItemsGrid.ResumeLayout();

                fitToContent();
            }
            else
            {
                removeComponent();
            }
        }

        private void cleanGrid()
        {
            foreach (Control ctrl in ItemsGrid.Controls)
            {
                ctrl.Dispose();
            }

            ItemsGrid.Controls.Clear();
        }

        private void removeComponent()
        {
            cleanGrid();

            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }

            this.Dispose();
        }

        private void fitToContent()
        {
            Size preferredSize = ItemsGrid.GetPreferredSize(new Size(ItemsGrid.Width, 0));

            int titleHeight = TitleLabel.Bottom;
            int requiredHeight = titleHeight + preferredSize.Height + ItemsGrid.Padding.Bottom + 5;

            if (requiredHeight >= k_MaxHeight)
            {
                this.Height = k_MaxHeight;
            }
            else
            {
                this.Height = requiredHeight;
            }
        }
    }
}
