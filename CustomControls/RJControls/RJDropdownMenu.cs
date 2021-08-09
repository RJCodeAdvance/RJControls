using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace RJCodeAdvance.RJControls
{
    public class RJDropdownMenu : ContextMenuStrip
    {
        //Fields
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.Empty;//No color, The default color is set in the MenuRenderer class
        private Color primaryColor = Color.Empty;//No color, The default color is set in the MenuRenderer class

        private Bitmap menuItemHeaderSize;

        //Constructor
        public RJDropdownMenu(IContainer container)
            : base(container)
        {

        }

        //Properties
        //Optionally, hide the properties in the toolbox to avoid the problem of displaying and/or 
        //saving control property changes in the designer at design time in Visual Studio.
        //If the problem I mention does not occur you can expose the properties and manipulate them from the toolbox.
        //[Browsable(false)]
        [Category("RJ Code Advance")]
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu = value; }
        }

        //[Browsable(false)]
        [Category("RJ Code Advance")]
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }

        //[Browsable(false)]
        [Category("RJ Code Advance")]
        public Color MenuItemTextColor
        {
            get { return menuItemTextColor; }
            set { menuItemTextColor = value; }
        }

        //[Browsable(false)]
        [Category("RJ Code Advance")]
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set { primaryColor = value; }
        }

        //Private methods
        private void LoadMenuItemHeight()
        {
            if (isMainMenu)
                menuItemHeaderSize = new Bitmap(25, 45);
            else menuItemHeaderSize = new Bitmap(20, menuItemHeight);

            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;

                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                        {
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItemL4.Image == null) menuItemL4.Image = menuItemHeaderSize;
                            ///Level 5++
                        }
                    }
                }
            }
        }

        //Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
                LoadMenuItemHeight();
            }
        }
    }
}
