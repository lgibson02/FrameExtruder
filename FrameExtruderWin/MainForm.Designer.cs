namespace FrameExtruderWin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbSaveUnextrudedCopies = new System.Windows.Forms.CheckBox();
            this.PbColorBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbColorOpacity = new System.Windows.Forms.TextBox();
            this.BtnSelectBgColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbSpacing = new System.Windows.Forms.TextBox();
            this.TbMargin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSelectManually = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PbDrag = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // TbWidth
            // 
            this.TbWidth.Location = new System.Drawing.Point(81, 24);
            this.TbWidth.Name = "TbWidth";
            this.TbWidth.Size = new System.Drawing.Size(44, 20);
            this.TbWidth.TabIndex = 0;
            this.TbWidth.Text = "16";
            this.TbWidth.TextChanged += new System.EventHandler(this.TbWidth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame Width:";
            // 
            // TbHeight
            // 
            this.TbHeight.Location = new System.Drawing.Point(81, 53);
            this.TbHeight.Name = "TbHeight";
            this.TbHeight.Size = new System.Drawing.Size(44, 20);
            this.TbHeight.TabIndex = 4;
            this.TbHeight.Text = "16";
            this.TbHeight.TextChanged += new System.EventHandler(this.TbHeight_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbSaveUnextrudedCopies);
            this.groupBox1.Controls.Add(this.PbColorBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbColorOpacity);
            this.groupBox1.Controls.Add(this.BtnSelectBgColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbSpacing);
            this.groupBox1.Controls.Add(this.TbMargin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbHeight);
            this.groupBox1.Controls.Add(this.TbWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extrusion Options";
            // 
            // CbSaveUnextrudedCopies
            // 
            this.CbSaveUnextrudedCopies.AutoSize = true;
            this.CbSaveUnextrudedCopies.Checked = true;
            this.CbSaveUnextrudedCopies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbSaveUnextrudedCopies.Location = new System.Drawing.Point(76, 156);
            this.CbSaveUnextrudedCopies.Name = "CbSaveUnextrudedCopies";
            this.CbSaveUnextrudedCopies.Size = new System.Drawing.Size(161, 17);
            this.CbSaveUnextrudedCopies.TabIndex = 15;
            this.CbSaveUnextrudedCopies.Text = "Save Copy Of Original Sheet";
            this.CbSaveUnextrudedCopies.UseVisualStyleBackColor = true;
            this.CbSaveUnextrudedCopies.CheckedChanged += new System.EventHandler(this.CbSaveUnextrudedCopies_CheckedChanged);
            // 
            // PbColorBox
            // 
            this.PbColorBox.BackColor = System.Drawing.Color.White;
            this.PbColorBox.BackgroundImage = global::FrameExtruderWin.Properties.Resources.back;
            this.PbColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbColorBox.Location = new System.Drawing.Point(75, 93);
            this.PbColorBox.Name = "PbColorBox";
            this.PbColorBox.Size = new System.Drawing.Size(50, 50);
            this.PbColorBox.TabIndex = 14;
            this.PbColorBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Opacity:";
            // 
            // TbColorOpacity
            // 
            this.TbColorOpacity.Location = new System.Drawing.Point(185, 123);
            this.TbColorOpacity.Name = "TbColorOpacity";
            this.TbColorOpacity.Size = new System.Drawing.Size(44, 20);
            this.TbColorOpacity.TabIndex = 12;
            this.TbColorOpacity.Text = "0";
            this.TbColorOpacity.TextChanged += new System.EventHandler(this.TbColorOpacity_TextChanged);
            // 
            // BtnSelectBgColor
            // 
            this.BtnSelectBgColor.Location = new System.Drawing.Point(131, 94);
            this.BtnSelectBgColor.Name = "BtnSelectBgColor";
            this.BtnSelectBgColor.Size = new System.Drawing.Size(98, 23);
            this.BtnSelectBgColor.TabIndex = 11;
            this.BtnSelectBgColor.Text = "Select Color";
            this.BtnSelectBgColor.UseVisualStyleBackColor = true;
            this.BtnSelectBgColor.Click += new System.EventHandler(this.BtnSelectBgColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Back Color:";
            // 
            // TbSpacing
            // 
            this.TbSpacing.Location = new System.Drawing.Point(185, 53);
            this.TbSpacing.Name = "TbSpacing";
            this.TbSpacing.Size = new System.Drawing.Size(44, 20);
            this.TbSpacing.TabIndex = 8;
            this.TbSpacing.Text = "0";
            this.TbSpacing.TextChanged += new System.EventHandler(this.TbSpacing_TextChanged);
            // 
            // TbMargin
            // 
            this.TbMargin.Location = new System.Drawing.Point(185, 24);
            this.TbMargin.Name = "TbMargin";
            this.TbMargin.Size = new System.Drawing.Size(44, 20);
            this.TbMargin.TabIndex = 7;
            this.TbMargin.Text = "0";
            this.TbMargin.TextChanged += new System.EventHandler(this.TbMargin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Spacing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Margin:";
            // 
            // BtnSelectManually
            // 
            this.BtnSelectManually.Location = new System.Drawing.Point(92, 483);
            this.BtnSelectManually.Name = "BtnSelectManually";
            this.BtnSelectManually.Size = new System.Drawing.Size(101, 23);
            this.BtnSelectManually.TabIndex = 7;
            this.BtnSelectManually.Text = "Select Manually";
            this.BtnSelectManually.UseVisualStyleBackColor = true;
            this.BtnSelectManually.Click += new System.EventHandler(this.BtnSelectManually_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(134, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "or";
            // 
            // PbDrag
            // 
            this.PbDrag.Image = global::FrameExtruderWin.Properties.Resources.drag;
            this.PbDrag.Location = new System.Drawing.Point(15, 205);
            this.PbDrag.Name = "PbDrag";
            this.PbDrag.Size = new System.Drawing.Size(256, 256);
            this.PbDrag.TabIndex = 6;
            this.PbDrag.TabStop = false;
            this.PbDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbDrag_DragDrop);
            this.PbDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbDrag_DragEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSelectManually);
            this.Controls.Add(this.PbDrag);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Frame Extruder";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PbDrag;
        private System.Windows.Forms.Button BtnSelectManually;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSpacing;
        private System.Windows.Forms.TextBox TbMargin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSelectBgColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbColorOpacity;
        private System.Windows.Forms.PictureBox PbColorBox;
        private System.Windows.Forms.CheckBox CbSaveUnextrudedCopies;
    }
}