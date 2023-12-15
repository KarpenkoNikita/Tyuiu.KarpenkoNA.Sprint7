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
    public partial class FormMain_KNA : Form
    {
        public FormMain_KNA()
        {
            InitializeComponent();
        }

        private void buttonHelp_KNA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
