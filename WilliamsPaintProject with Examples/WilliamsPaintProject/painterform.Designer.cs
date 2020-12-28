
namespace WilliamsPaintProject
{
    partial class f1PaintProject
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.cbxShapes = new System.Windows.Forms.ComboBox();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.gbShapes = new System.Windows.Forms.GroupBox();
            this.gbxColors = new System.Windows.Forms.GroupBox();
            this.rbtnBlack = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnYellow = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.btnClearDrawing = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbAdvMode = new System.Windows.Forms.CheckBox();
            this.gbxSizes = new System.Windows.Forms.GroupBox();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnMed = new System.Windows.Forms.RadioButton();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.rbtnTiny = new System.Windows.Forms.RadioButton();
            this.gbShapes.SuspendLayout();
            this.gbxColors.SuspendLayout();
            this.gbxSizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(218, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(853, 580);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // cbxShapes
            // 
            this.cbxShapes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxShapes.FormattingEnabled = true;
            this.cbxShapes.Items.AddRange(new object[] {
            "Brush",
            "Straight-Line",
            "Rectangle",
            "Ellipse"});
            this.cbxShapes.Location = new System.Drawing.Point(6, 19);
            this.cbxShapes.Name = "cbxShapes";
            this.cbxShapes.Size = new System.Drawing.Size(188, 21);
            this.cbxShapes.TabIndex = 1;
            this.cbxShapes.Text = "Brush";
            this.cbxShapes.SelectedIndexChanged += new System.EventHandler(this.cbxShapes_SelectedIndexChanged);
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Location = new System.Drawing.Point(6, 46);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(142, 17);
            this.cbFill.TabIndex = 2;
            this.cbFill.Text = "Fill ( for Rect and Ellipse)";
            this.cbFill.UseVisualStyleBackColor = true;
            this.cbFill.CheckedChanged += new System.EventHandler(this.cbFill_CheckedChanged);
            // 
            // gbShapes
            // 
            this.gbShapes.Controls.Add(this.cbxShapes);
            this.gbShapes.Controls.Add(this.cbFill);
            this.gbShapes.Location = new System.Drawing.Point(12, 12);
            this.gbShapes.Name = "gbShapes";
            this.gbShapes.Size = new System.Drawing.Size(200, 73);
            this.gbShapes.TabIndex = 3;
            this.gbShapes.TabStop = false;
            this.gbShapes.Text = "Shapes";
            // 
            // gbxColors
            // 
            this.gbxColors.Controls.Add(this.rbtnBlack);
            this.gbxColors.Controls.Add(this.rbtnBlue);
            this.gbxColors.Controls.Add(this.rbtnGreen);
            this.gbxColors.Controls.Add(this.rbtnYellow);
            this.gbxColors.Controls.Add(this.rbtnRed);
            this.gbxColors.Location = new System.Drawing.Point(12, 91);
            this.gbxColors.Name = "gbxColors";
            this.gbxColors.Size = new System.Drawing.Size(200, 141);
            this.gbxColors.TabIndex = 4;
            this.gbxColors.TabStop = false;
            this.gbxColors.Text = "Colors";
            // 
            // rbtnBlack
            // 
            this.rbtnBlack.AutoSize = true;
            this.rbtnBlack.Checked = true;
            this.rbtnBlack.Location = new System.Drawing.Point(7, 115);
            this.rbtnBlack.Name = "rbtnBlack";
            this.rbtnBlack.Size = new System.Drawing.Size(52, 17);
            this.rbtnBlack.TabIndex = 4;
            this.rbtnBlack.TabStop = true;
            this.rbtnBlack.Text = "Black";
            this.rbtnBlack.UseVisualStyleBackColor = true;
            this.rbtnBlack.CheckedChanged += new System.EventHandler(this.updateColor);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(7, 91);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(46, 17);
            this.rbtnBlue.TabIndex = 3;
            this.rbtnBlue.Text = "Blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.updateColor);
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(7, 67);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(54, 17);
            this.rbtnGreen.TabIndex = 2;
            this.rbtnGreen.Text = "Green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.updateColor);
            // 
            // rbtnYellow
            // 
            this.rbtnYellow.AutoSize = true;
            this.rbtnYellow.Location = new System.Drawing.Point(7, 43);
            this.rbtnYellow.Name = "rbtnYellow";
            this.rbtnYellow.Size = new System.Drawing.Size(56, 17);
            this.rbtnYellow.TabIndex = 1;
            this.rbtnYellow.Text = "Yellow";
            this.rbtnYellow.UseVisualStyleBackColor = true;
            this.rbtnYellow.CheckedChanged += new System.EventHandler(this.updateColor);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(6, 19);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.updateColor);
            // 
            // btnClearDrawing
            // 
            this.btnClearDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearDrawing.Location = new System.Drawing.Point(100, 568);
            this.btnClearDrawing.Name = "btnClearDrawing";
            this.btnClearDrawing.Size = new System.Drawing.Size(112, 24);
            this.btnClearDrawing.TabIndex = 5;
            this.btnClearDrawing.Text = "Clear Drawing";
            this.btnClearDrawing.UseVisualStyleBackColor = true;
            this.btnClearDrawing.Click += new System.EventHandler(this.btnClearDrawing_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(12, 568);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(82, 24);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help!";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cbAdvMode
            // 
            this.cbAdvMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAdvMode.AutoSize = true;
            this.cbAdvMode.Location = new System.Drawing.Point(12, 545);
            this.cbAdvMode.Name = "cbAdvMode";
            this.cbAdvMode.Size = new System.Drawing.Size(105, 17);
            this.cbAdvMode.TabIndex = 5;
            this.cbAdvMode.Text = "Advanced Mode";
            this.cbAdvMode.UseVisualStyleBackColor = true;
            this.cbAdvMode.Visible = false;
            // 
            // gbxSizes
            // 
            this.gbxSizes.Controls.Add(this.rbtnLarge);
            this.gbxSizes.Controls.Add(this.rbtnMed);
            this.gbxSizes.Controls.Add(this.rbtnSmall);
            this.gbxSizes.Controls.Add(this.rbtnTiny);
            this.gbxSizes.Location = new System.Drawing.Point(11, 238);
            this.gbxSizes.Name = "gbxSizes";
            this.gbxSizes.Size = new System.Drawing.Size(201, 117);
            this.gbxSizes.TabIndex = 7;
            this.gbxSizes.TabStop = false;
            this.gbxSizes.Text = "Sizes";
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(8, 91);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rbtnLarge.TabIndex = 3;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            this.rbtnLarge.CheckedChanged += new System.EventHandler(this.updateSize);
            // 
            // rbtnMed
            // 
            this.rbtnMed.AutoSize = true;
            this.rbtnMed.Location = new System.Drawing.Point(8, 67);
            this.rbtnMed.Name = "rbtnMed";
            this.rbtnMed.Size = new System.Drawing.Size(62, 17);
            this.rbtnMed.TabIndex = 2;
            this.rbtnMed.TabStop = true;
            this.rbtnMed.Text = "Medium";
            this.rbtnMed.UseVisualStyleBackColor = true;
            this.rbtnMed.CheckedChanged += new System.EventHandler(this.updateSize);
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Checked = true;
            this.rbtnSmall.Location = new System.Drawing.Point(8, 44);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rbtnSmall.TabIndex = 1;
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.CheckedChanged += new System.EventHandler(this.updateSize);
            // 
            // rbtnTiny
            // 
            this.rbtnTiny.AutoSize = true;
            this.rbtnTiny.Location = new System.Drawing.Point(8, 20);
            this.rbtnTiny.Name = "rbtnTiny";
            this.rbtnTiny.Size = new System.Drawing.Size(45, 17);
            this.rbtnTiny.TabIndex = 0;
            this.rbtnTiny.TabStop = true;
            this.rbtnTiny.Text = "Tiny";
            this.rbtnTiny.UseVisualStyleBackColor = true;
            this.rbtnTiny.CheckedChanged += new System.EventHandler(this.updateSize);
            // 
            // f1PaintProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 604);
            this.Controls.Add(this.gbxSizes);
            this.Controls.Add(this.cbAdvMode);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClearDrawing);
            this.Controls.Add(this.gbxColors);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.gbShapes);
            this.Name = "f1PaintProject";
            this.Text = "William\'s Paint Project";
            this.gbShapes.ResumeLayout(false);
            this.gbShapes.PerformLayout();
            this.gbxColors.ResumeLayout(false);
            this.gbxColors.PerformLayout();
            this.gbxSizes.ResumeLayout(false);
            this.gbxSizes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.ComboBox cbxShapes;
        private System.Windows.Forms.CheckBox cbFill;
        private System.Windows.Forms.GroupBox gbShapes;
        private System.Windows.Forms.GroupBox gbxColors;
        private System.Windows.Forms.Button btnClearDrawing;
        private System.Windows.Forms.RadioButton rbtnBlack;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnYellow;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbAdvMode;
        private System.Windows.Forms.GroupBox gbxSizes;
        private System.Windows.Forms.RadioButton rbtnMed;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.RadioButton rbtnTiny;
        private System.Windows.Forms.RadioButton rbtnLarge;
    }
}

