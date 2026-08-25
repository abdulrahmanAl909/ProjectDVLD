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
    public partial class frmShowL : Form
    {
        int _LocalID = -1;
        public frmShowL(int LocalID)
        {
            InitializeComponent();

            this._LocalID = LocalID;
        }

        private void frmShowL_Load(object sender, EventArgs e)
        {
            ctrlL1.LoadDataForLocalApplication(_LocalID);
        }
    }
}
