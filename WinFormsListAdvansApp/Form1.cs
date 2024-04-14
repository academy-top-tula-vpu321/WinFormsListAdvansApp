namespace WinFormsListAdvansApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
