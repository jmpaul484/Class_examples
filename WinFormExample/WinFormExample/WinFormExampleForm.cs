namespace WinFormExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.Text = InfoTextBox.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            InfoTextBox.Clear();
            
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
