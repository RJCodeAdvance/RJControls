namespace CustomControls.Testing
{
    partial class FormMiniatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiniatura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rjProgressBar5 = new CustomControls.RJControls.RJProgressBar();
            this.rjProgressBar4 = new CustomControls.RJControls.RJProgressBar();
            this.rjProgressBar3 = new CustomControls.RJControls.RJProgressBar();
            this.rjProgressBar2 = new CustomControls.RJControls.RJProgressBar();
            this.rjProgressBar1 = new CustomControls.RJControls.RJProgressBar();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(174)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 80);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1091, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom ProgressBar - C# WinForm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(130, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 46);
            this.label2.TabIndex = 37;
            this.label2.Text = "Left value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(103, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 38;
            this.label3.Text = "Right value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(77, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 46);
            this.label4.TabIndex = 39;
            this.label4.Text = "Center value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(76, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 46);
            this.label5.TabIndex = 40;
            this.label5.Text = "Slidind value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(24, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 46);
            this.label6.TabIndex = 41;
            this.label6.Text = "Show NO value";
            // 
            // rjProgressBar5
            // 
            this.rjProgressBar5.ChannelColor = System.Drawing.Color.LightSlateGray;
            this.rjProgressBar5.ChannelHeight = 30;
            this.rjProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar5.ForeBackColor = System.Drawing.Color.WhiteSmoke;
            this.rjProgressBar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjProgressBar5.Location = new System.Drawing.Point(327, 637);
            this.rjProgressBar5.Name = "rjProgressBar5";
            this.rjProgressBar5.ShowMaximun = false;
            this.rjProgressBar5.ShowValue = CustomControls.RJControls.TextPosition.None;
            this.rjProgressBar5.Size = new System.Drawing.Size(843, 51);
            this.rjProgressBar5.SliderColor = System.Drawing.Color.MediumSeaGreen;
            this.rjProgressBar5.SliderHeight = 30;
            this.rjProgressBar5.SymbolAfter = "";
            this.rjProgressBar5.SymbolBefore = "";
            this.rjProgressBar5.TabIndex = 36;
            this.rjProgressBar5.Value = 20;
            // 
            // rjProgressBar4
            // 
            this.rjProgressBar4.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar4.ChannelHeight = 20;
            this.rjProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar4.ForeBackColor = System.Drawing.Color.CornflowerBlue;
            this.rjProgressBar4.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar4.Location = new System.Drawing.Point(327, 496);
            this.rjProgressBar4.Maximum = 500;
            this.rjProgressBar4.Name = "rjProgressBar4";
            this.rjProgressBar4.ShowMaximun = false;
            this.rjProgressBar4.ShowValue = CustomControls.RJControls.TextPosition.Sliding;
            this.rjProgressBar4.Size = new System.Drawing.Size(843, 108);
            this.rjProgressBar4.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjProgressBar4.SliderHeight = 50;
            this.rjProgressBar4.SymbolAfter = "";
            this.rjProgressBar4.SymbolBefore = "$";
            this.rjProgressBar4.TabIndex = 35;
            this.rjProgressBar4.Value = 384;
            // 
            // rjProgressBar3
            // 
            this.rjProgressBar3.ChannelColor = System.Drawing.Color.Navy;
            this.rjProgressBar3.ChannelHeight = 50;
            this.rjProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar3.ForeBackColor = System.Drawing.Color.WhiteSmoke;
            this.rjProgressBar3.ForeColor = System.Drawing.Color.Salmon;
            this.rjProgressBar3.Location = new System.Drawing.Point(327, 350);
            this.rjProgressBar3.MarqueeAnimationSpeed = 0;
            this.rjProgressBar3.Maximum = 1280;
            this.rjProgressBar3.Name = "rjProgressBar3";
            this.rjProgressBar3.ShowMaximun = true;
            this.rjProgressBar3.ShowValue = CustomControls.RJControls.TextPosition.Center;
            this.rjProgressBar3.Size = new System.Drawing.Size(843, 104);
            this.rjProgressBar3.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjProgressBar3.SliderHeight = 30;
            this.rjProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rjProgressBar3.SymbolAfter = "";
            this.rjProgressBar3.SymbolBefore = "$";
            this.rjProgressBar3.TabIndex = 34;
            this.rjProgressBar3.Value = 498;
            // 
            // rjProgressBar2
            // 
            this.rjProgressBar2.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(132)))));
            this.rjProgressBar2.ChannelHeight = 20;
            this.rjProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar2.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjProgressBar2.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar2.Location = new System.Drawing.Point(327, 241);
            this.rjProgressBar2.Name = "rjProgressBar2";
            this.rjProgressBar2.ShowMaximun = false;
            this.rjProgressBar2.ShowValue = CustomControls.RJControls.TextPosition.Right;
            this.rjProgressBar2.Size = new System.Drawing.Size(843, 83);
            this.rjProgressBar2.SliderColor = System.Drawing.Color.DeepPink;
            this.rjProgressBar2.SliderHeight = 20;
            this.rjProgressBar2.SymbolAfter = "%";
            this.rjProgressBar2.SymbolBefore = "";
            this.rjProgressBar2.TabIndex = 33;
            this.rjProgressBar2.Value = 74;
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar1.ChannelHeight = 20;
            this.rjProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.WhiteSmoke;
            this.rjProgressBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rjProgressBar1.Location = new System.Drawing.Point(327, 123);
            this.rjProgressBar1.Maximum = 200;
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = true;
            this.rjProgressBar1.ShowValue = CustomControls.RJControls.TextPosition.Left;
            this.rjProgressBar1.Size = new System.Drawing.Size(843, 98);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rjProgressBar1.SliderHeight = 40;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 32;
            this.rjProgressBar1.Value = 70;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 86);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(118, 40);
            this.rjButton1.TabIndex = 42;
            this.rjButton1.Text = "Start";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMiniatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1278, 730);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjProgressBar5);
            this.Controls.Add(this.rjProgressBar4);
            this.Controls.Add(this.rjProgressBar3);
            this.Controls.Add(this.rjProgressBar2);
            this.Controls.Add(this.rjProgressBar1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMiniatura";
            this.Text = "Custom Controls";
            this.Load += new System.EventHandler(this.FormMiniatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RJControls.RJProgressBar rjProgressBar5;
        private RJControls.RJProgressBar rjProgressBar4;
        private RJControls.RJProgressBar rjProgressBar3;
        private RJControls.RJProgressBar rjProgressBar2;
        private RJControls.RJProgressBar rjProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RJControls.RJButton rjButton1;
        private System.Windows.Forms.Timer timer1;
    }
}