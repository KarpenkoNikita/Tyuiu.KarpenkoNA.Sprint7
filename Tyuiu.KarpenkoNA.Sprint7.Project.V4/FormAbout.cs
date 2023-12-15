using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint7.Project.V4.Lib;

namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonClose_KNA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
