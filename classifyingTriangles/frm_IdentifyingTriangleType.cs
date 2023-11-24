using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classifyingTriangles
{
    public partial class frm_IdentifyingTriangleType : Form
    {
        public frm_IdentifyingTriangleType()
        {
            InitializeComponent();
        }
        private void btn_CheckType_Click(object sender, EventArgs e)
        {
            txt_ReturnMessage.Text = classifyingTriangles.Component.Helper.Helper_frm_IdentifyingTriangleType.
                                     checkTriangleTye(txt_Side1.Text, txt_Side2.Text, txt_Side3.Text);
            btn_CheckType.Focus();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Side1.Text =string.Empty;
            txt_Side2.Text = string.Empty;
            txt_Side3.Text = string.Empty;
            txt_ReturnMessage.Text = string.Empty;
        }
    }
}
