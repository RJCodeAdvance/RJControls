using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
            label1.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextChanged
        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox7__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Changed");
        }
    }
}
