using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FrameExtruderWin {
    public partial class ProgressForm : Form {
        public delegate bool DoWorkCallback(BackgroundWorker work);

        public ProgressForm(string title, DoWorkCallback work, Action<RunWorkerCompletedEventArgs> finish) {
            InitializeComponent();
            Text = title;
            MainWorker.DoWork += (object sender, DoWorkEventArgs e) => { e.Cancel = !work(MainWorker); } ;
            MainWorker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e)  => { Close(); finish(e);};
            MainWorker.RunWorkerAsync();
        }

        private void MainWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            Bar.Value = e.ProgressPercentage;
            LbProgress.Text = e.ProgressPercentage + "%";
        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(MainWorker.IsBusy) {
                e.Cancel = true;
                if (!MainWorker.CancellationPending) {
                    MainWorker.CancelAsync();
                    Enabled = false;
                    Text = "Cancelling...";
                }
            }

        }
    }
}
