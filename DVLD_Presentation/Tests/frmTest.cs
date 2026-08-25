using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmTest : Form
    {
        int _LpaclID = -1;
        public frmTest(int LocalID)
        {
            InitializeComponent();

            _LpaclID = LocalID;
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LpaclID);
        }


    }
}
