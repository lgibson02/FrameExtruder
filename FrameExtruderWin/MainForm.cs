using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrameExtruderWin {
    public partial class MainForm : Form {
        int FrameWidth = 16;
        int FrameHeight = 16;
        int SheetMargin = 0;
        int Spacing = 0;
        Color Background = Color.Transparent;
        bool SaveUnextrudedCopies = true;

        public MainForm() {
            InitializeComponent();
            PbDrag.AllowDrop = true;
        }

        private void PbDrag_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            BeginExtrusion(files);
        }

        private void BtnSelectManually_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;
            if(fd.ShowDialog() == DialogResult.OK) {
                BeginExtrusion(fd.FileNames);
            }
        }

        public void BeginExtrusion(string[] files) {
            Bitmap[] sheets = new Bitmap[files.Length];
            for (int i = 0; i < files.Length; i++) {
                if(!File.Exists(files[i])) {
                    MessageBox.Show(this, $"File not found: {files[i]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    sheets[i] = new Bitmap(files[i]);
                } catch (System.ArgumentException) {
                    MessageBox.Show(this, $"Please only use the following file types: (.png, .jpg, .bmp, .gif).\nFile unsupported or corrupted: {files[i]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result;
            if (SaveUnextrudedCopies) {
                result = DialogResult.OK;
            } else {
                result = MessageBox.Show(this, "Be aware that each file selected will be overwritten with it's extruded version and the orignal will be lost. Press cancel to abort extrusion.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (result == DialogResult.OK) {
                ProgressForm progress = new ProgressForm("Extruding...", (BackgroundWorker worker) => { return Program.ExtrudeSheets(sheets, files, FrameWidth, FrameHeight, SheetMargin, Spacing, Background, SaveUnextrudedCopies, worker); }, OnExtrusionFinish);
                progress.Show(this);
                Enabled = false;
            }
        }

        private void OnExtrusionFinish(RunWorkerCompletedEventArgs e) {
            Enabled = true;
            if(!e.Cancelled && e.Error == null) {
                MessageBox.Show(this, "Extrusion was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null) {
                MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PbDrag_DragEnter(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false); // only allow accessible files
            if (files == null) {
                e.Effect = DragDropEffects.None;
            } else {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PbDrag_DragLeave(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.None;
        }

        private void BtnSelectBgColor_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                Background = cd.Color;
                UpdateBackgroundColor();
            }
        }

        private void UpdateBackgroundColor() {
            // draw color box to show selected background color...
            Bitmap bm = global::FrameExtruderWin.Properties.Resources.back;
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(new SolidBrush(Background), 0, 0, bm.Width, bm.Height);
            PbColorBox.Image = bm;
            g.Dispose();
            // set opacity text field...
            TbColorOpacity.Text = Background.A.ToString();
        }

        private void TbColorOpacity_TextChanged(object sender, EventArgs e) {
            int opacity = Background.A;
            if (!int.TryParse(TbColorOpacity.Text, out opacity)) {
                TbColorOpacity.BackColor = Color.RosyBrown;
                return;
            }
            if (opacity >= 256 || opacity < 0) {
                TbColorOpacity.BackColor = Color.RosyBrown;
                return;
            }
            TbColorOpacity.BackColor = SystemColors.Window;
            Background = Color.FromArgb(opacity, Background);
            UpdateBackgroundColor();
        }

        private void TbWidth_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TbWidth.Text, out FrameWidth)) {
                TbWidth.BackColor = SystemColors.Window;
            } else {
                TbWidth.BackColor = Color.RosyBrown;
            }
        }

        private void TbHeight_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TbHeight.Text, out FrameHeight)) {
                TbHeight.BackColor = SystemColors.Window;
            } else {
                TbHeight.BackColor = Color.RosyBrown;
            }
        }

        private void TbMargin_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TbMargin.Text, out SheetMargin)) {
                TbMargin.BackColor = SystemColors.Window;
            } else {
                TbMargin.BackColor = Color.RosyBrown;
            }
        }

        private void TbSpacing_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(TbSpacing.Text, out Spacing)) {
                TbSpacing.BackColor = SystemColors.Window;
            } else {
                TbSpacing.BackColor = Color.RosyBrown;
            }
        }

        private void CbSaveUnextrudedCopies_CheckedChanged(object sender, EventArgs e) {
            SaveUnextrudedCopies = !SaveUnextrudedCopies;
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            // bring to front
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

    }
}
