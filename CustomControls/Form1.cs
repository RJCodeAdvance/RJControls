using CustomControls.RJControls;
using CustomControls.Testing;
using Microsoft.Win32;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //rjTextBox1.Texts = "animal";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            rjDropdownMenu2.PrimaryColor = Color.CornflowerBlue;
            rjDropdownMenu6.PrimaryColor = Color.Orange;
            rjDropdownMenu7.PrimaryColor = Color.MediumSeaGreen;          

            rjDropdownMenu3.PrimaryColor = Color.SeaGreen;
            rjDropdownMenu3.MenuItemTextColor = Color.SeaGreen;
            rjDropdownMenu3.MenuItemHeight = 30;

            rjDropdownMenu4.PrimaryColor = Color.HotPink;
            rjDropdownMenu4.MenuItemHeight = 25;

            rjDropdownMenu5.PrimaryColor = Color.Gold;
            rjDropdownMenu5.MenuItemTextColor = Color.SteelBlue;
            rjDropdownMenu5.MenuItemHeight = 50;

            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu2.IsMainMenu = true;
            rjDropdownMenu6.IsMainMenu = true;
            rjDropdownMenu7.IsMainMenu = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu3.Show(rjButton1, rjButton1.Width, 0);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu4.Show(rjButton2, rjButton2.Width, 0);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            rjDropdownMenu5.Show(rjButton3, rjButton3.Width, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(rjDropdownMenu1, sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(rjDropdownMenu2, sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu2(rjDropdownMenu6, sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu2(rjDropdownMenu7, sender);
           
        }

        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void Open_DropdownMenu2(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(72, 52, 183);
                else ctrl.BackColor = Color.FromArgb(24, 24, 36);

            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rjTextBox1.Texts);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rjTextBox1.PlaceholderText);
        }
    }
}
