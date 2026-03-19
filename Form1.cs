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
            // 1. 문자열 정제 (Trim)
            var text = TextInputBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(text))
            {
                // 2. 타임스탬프 추가
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                string message = $"[{timestamp}] {text}";

                // 리스트 출력
                TextOutputBox.Items.Add(message);

                // 입력창 초기화
                TextInputBox.Clear();
                TextInputBox.Focus();

                // 3. 메시지 카운트 업데이트
                int count = TextOutputBox.Items.Count;
                CountLabel.Text = $"현재 대화: {count}개";
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