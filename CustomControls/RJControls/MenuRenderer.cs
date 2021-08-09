using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RJCodeAdvance.RJControls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        //Fields
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;

        //Constructor
        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
            : base(new MenuColorTable(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            if (isMainMenu)
            {
                arrowThickness = 3;
                if (textColor == Color.Empty) //Set Default Color
                    this.textColor = Color.Gainsboro;
                else//Set custom text color 
                    this.textColor = textColor;
            }
            else
            {
                arrowThickness = 2;
                if (textColor == Color.Empty) //Set Default Color
                    this.textColor = Color.DimGray;
                else//Set custom text color
                    this.textColor = textColor;
            }
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }

    }
}
