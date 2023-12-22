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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_ATI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
