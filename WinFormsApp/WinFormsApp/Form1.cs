namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
           var response = await User.GetAll();
            richTextBox1.Text = User.FormatJson(response);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var response = await User.Get(textSearch.Text);
            richTextBox1.Text = User.FormatJson(response);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}