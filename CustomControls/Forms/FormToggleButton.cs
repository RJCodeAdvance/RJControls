using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Testing
{
    public partial class FormToggleButton : Form
    {
        public FormToggleButton()
        {
            InitializeComponent();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked == true)
            {
                this.BackColor = Color.FromArgb(31, 28, 47);
                foreach (var item in this.Controls)
                {
                    if (item is Label)
                    {
                        Label lbl = (Label)item;
                        lbl.ForeColor = Color.FromArgb(170, 175, 182);
                    }

                }
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 250, 253);
                foreach (var item in this.Controls)
                {
                    if (item is Label)
                    {
                        Label lbl = (Label)item;
                        lbl.ForeColor = Color.Gray;
                    }

                }
            }
        }

        private void rjToggleButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton6.Checked == true)
            {
                this.BackColor = Color.FromArgb(31, 28, 47);
                foreach (var item in this.Controls)
                {
                    if (item is Label)
                    {
                        Label lbl = (Label)item;
                        lbl.ForeColor = Color.FromArgb(170, 175, 182);
                    }

                }
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 250, 253);
                foreach (var item in this.Controls)
                {
                    if (item is Label)
                    {
                        Label lbl = (Label)item;
                        lbl.ForeColor = Color.Gray;
                    }

                }
            }
        }
    }
}
