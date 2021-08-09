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
   public class RJCircularPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        //Constructor
        public RJCircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor2
        {
            get { return borderColor2; }
            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public DashStyle BorderLineStyle
        {
            get { return borderLineStyle; }
            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public float GradientAngle
        {
            get { return gradientAngle; }
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                //Set rounded region 
                this.Region = new Region(pathRegion);

                //Drawing
                graph.DrawEllipse(penSmooth, rectContourSmooth);//Draw contour smoothing
                if (borderSize > 0) //Draw border
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
