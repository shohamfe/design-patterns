using BasicFacebookFeatures.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.UI.Forms
{
    public partial class BioForm : Component
    {
        public BioForm()
        {
            //BioManager bioManager = new BioManager(loggedInUser);

            //// 2. Get the processed data (DTO)
            //BioDetails details = bioManager.GetBioDetails();

            //// 3. Inject data into the form
            //BioForm bioForm = new BioForm(details);

            //bioForm.ShowDialog();
            InitializeComponent();
        }

        public BioForm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
