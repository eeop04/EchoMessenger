namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = TextInputBox.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                TextOutputBox.Items.Add(text);
                TextInputBox.Clear();
                TextInputBox.Focus();
            }
        }

        private void TextInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ChatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
