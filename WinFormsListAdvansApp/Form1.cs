namespace WinFormsListAdvansApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            bool state = !checkedListBox1.GetItemChecked(index);
            checkedListBox1.SetItemChecked(index, state);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;

            timer.Interval = 100;

            if (timer.Enabled)
            {
                timer.Stop();
                ((Button)sender).Text = "Start";
            }
            else
            {
                timer.Start();
                ((Button)sender).Text = "Stop";
            }

            
        }
    }
}
