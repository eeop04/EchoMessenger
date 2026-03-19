namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextInputBtn = new Button();
            Chat = new Label();
            TextOutputBox = new ListBox();
            TextInputBox = new TextBox();
            AllChat = new Button();
            T1Chat = new Button();
            T2Chat = new Button();
            CountLabel = new Label();
            SuspendLayout();
            // 
            // TextInputBtn
            // 
            TextInputBtn.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TextInputBtn.Location = new Point(645, 371);
            TextInputBtn.Name = "TextInputBtn";
            TextInputBtn.Size = new Size(114, 49);
            TextInputBtn.TabIndex = 0;
            TextInputBtn.Text = "↲";
            TextInputBtn.UseVisualStyleBackColor = true;
            TextInputBtn.Click += button1_Click;
            // 
            // Chat
            // 
            Chat.AutoSize = true;
            Chat.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Chat.Location = new Point(36, 28);
            Chat.Name = "Chat";
            Chat.Size = new Size(51, 25);
            Chat.TabIndex = 1;
            Chat.Text = "Chat";
            // 
            // TextOutputBox
            // 
            TextOutputBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TextOutputBox.FormattingEnabled = true;
            TextOutputBox.Location = new Point(36, 109);
            TextOutputBox.Name = "TextOutputBox";
            TextOutputBox.Size = new Size(720, 256);
            TextOutputBox.TabIndex = 2;
            TextOutputBox.SelectedIndexChanged += ChatBox_SelectedIndexChanged;
            // 
            // TextInputBox
            // 
            TextInputBox.Location = new Point(36, 389);
            TextInputBox.Name = "TextInputBox";
            TextInputBox.Size = new Size(603, 27);
            TextInputBox.TabIndex = 3;
            TextInputBox.TextChanged += textBox1_TextChanged;
            TextInputBox.KeyDown += TextInputBox_KeyDown;
            // 
            // AllChat
            // 
            AllChat.Location = new Point(57, 74);
            AllChat.Name = "AllChat";
            AllChat.Size = new Size(94, 29);
            AllChat.TabIndex = 4;
            AllChat.Text = "전체";
            AllChat.UseVisualStyleBackColor = true;
            // 
            // T1Chat
            // 
            T1Chat.Location = new Point(167, 74);
            T1Chat.Name = "T1Chat";
            T1Chat.Size = new Size(94, 29);
            T1Chat.TabIndex = 5;
            T1Chat.Text = "팀1";
            T1Chat.UseVisualStyleBackColor = true;
            // 
            // T2Chat
            // 
            T2Chat.Location = new Point(277, 74);
            T2Chat.Name = "T2Chat";
            T2Chat.Size = new Size(94, 29);
            T2Chat.TabIndex = 6;
            T2Chat.Text = "팀2";
            T2Chat.UseVisualStyleBackColor = true;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(692, 81);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(0, 20);
            CountLabel.TabIndex = 7;
            CountLabel.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(CountLabel);
            Controls.Add(T2Chat);
            Controls.Add(T1Chat);
            Controls.Add(AllChat);
            Controls.Add(TextInputBox);
            Controls.Add(TextOutputBox);
            Controls.Add(Chat);
            Controls.Add(TextInputBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TextInputBtn;
        private Label Chat;
        private ListBox TextOutputBox;
        private TextBox TextInputBox;
        private Button AllChat;
        private Button T1Chat;
        private Button T2Chat;
        private Label CountLabel;
    }
}
