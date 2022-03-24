using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Testing
{
    public partial class FormMiniatura : Form
    {
        public FormMiniatura()
        {
            InitializeComponent();
        }

        private void FormMiniatura_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rjProgressBar1.Value < rjProgressBar1.Maximum)
                rjProgressBar1.Value++;
            if (rjProgressBar2.Value < rjProgressBar2.Maximum)
                rjProgressBar2.Value++;
            if (rjProgressBar3.Value < rjProgressBar3.Maximum)
                rjProgressBar3.Value++;
            if (rjProgressBar4.Value < rjProgressBar4.Maximum)
                rjProgressBar4.Value++;
            if (rjProgressBar5.Value < rjProgressBar5.Maximum)
                rjProgressBar5.Value++;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjProgressBar1.Value = 0;
            rjProgressBar2.Value = 0;
            rjProgressBar3.Value = 0;
            rjProgressBar4.Value = 0;
            rjProgressBar5.Value = 0;
            timer1.Start();
        }
    }
}