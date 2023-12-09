namespace PROJECT1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCode = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(193, 90);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(268, 27);
            textBoxCode.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(193, 151);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(268, 27);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 90);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 7;
            label2.Text = "Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 151);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SaddleBrown;
            buttonLogin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(349, 215);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 37);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "LOGİN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(563, 307);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(textBoxCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCode;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
    }
}