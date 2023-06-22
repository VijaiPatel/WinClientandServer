namespace WinClient
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
            btnSignIn = new Button();
            btnSend = new Button();
            txtNick = new TextBox();
            txtMessageHistory = new TextBox();
            txtMessage = new TextBox();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(692, 33);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(692, 560);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtNick
            // 
            txtNick.Location = new Point(105, 33);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(581, 23);
            txtNick.TabIndex = 2;
            // 
            // txtMessageHistory
            // 
            txtMessageHistory.Location = new Point(105, 107);
            txtMessageHistory.Multiline = true;
            txtMessageHistory.Name = "txtMessageHistory";
            txtMessageHistory.ReadOnly = true;
            txtMessageHistory.Size = new Size(581, 418);
            txtMessageHistory.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(105, 561);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(581, 23);
            txtMessage.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(692, 107);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(16, 418);
            vScrollBar1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Nick";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(label1);
            Controls.Add(vScrollBar1);
            Controls.Add(txtMessage);
            Controls.Add(txtMessageHistory);
            Controls.Add(txtNick);
            Controls.Add(btnSend);
            Controls.Add(btnSignIn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Button btnSend;
        private TextBox txtNick;
        private TextBox txtMessageHistory;
        private TextBox txtMessage;
        private VScrollBar vScrollBar1;
        private Label label1;
    }
}