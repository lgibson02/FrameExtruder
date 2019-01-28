namespace FrameExtruderWin
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.LbProgress = new System.Windows.Forms.Label();
            this.MainWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(13, 12);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(305, 23);
            this.Bar.TabIndex = 0;
            this.Bar.UseWaitCursor = true;
            // 
            // LbProgress
            // 
            this.LbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbProgress.AutoSize = true;
            this.LbProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbProgress.Location = new System.Drawing.Point(154, 16);
            this.LbProgress.Name = "LbProgress";
            this.LbProgress.Size = new System.Drawing.Size(23, 15);
            this.LbProgress.TabIndex = 1;
            this.LbProgress.Text = "0%";
            this.LbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWorker
            // 
            this.MainWorker.WorkerReportsProgress = true;
            this.MainWorker.WorkerSupportsCancellation = true;
            this.MainWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MainWorker_ProgressChanged);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 46);
            this.Controls.Add(this.LbProgress);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgressForm";
            this.Text = "Please Wait...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Label LbProgress;
        private System.ComponentModel.BackgroundWorker MainWorker;
    }
}