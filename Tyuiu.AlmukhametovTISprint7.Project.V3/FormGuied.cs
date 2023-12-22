using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AlmukhametovTI.Sprint7.Project.V3.Lib;

namespace Tyuiu.AlmukhametovTISprint7.Project.V3
{
    public partial class FormGuied : Form
    {
        public FormGuied()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemHelp_ATI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuItemBack_ATI_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
