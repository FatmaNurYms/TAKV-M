namespace PROJECT1
{
    partial class LOGIN
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
            buttonCreate = new Button();
            textBox1 = new TextBox();
            labelName = new Label();
            labelTitle = new Label();
            panel1 = new Panel();
            buttonJoin = new Button();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.SaddleBrown;
            buttonCreate.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(350, 204);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 37);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "CREATE";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(83, 154);
            labelName.Name = "labelName";
            labelName.Size = new Size(102, 21);
            labelName.TabIndex = 3;
            labelName.Text = "Username:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(88, 84);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(405, 35);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "WELCOME TO MEETING APP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Location = new Point(88, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 1);
            panel1.TabIndex = 6;
            // 
            // buttonJoin
            // 
            buttonJoin.BackColor = Color.SaddleBrown;
            buttonJoin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJoin.ForeColor = SystemColors.ButtonHighlight;
            buttonJoin.Location = new Point(211, 204);
            buttonJoin.Name = "buttonJoin";
            buttonJoin.Size = new Size(112, 37);
            buttonJoin.TabIndex = 7;
            buttonJoin.Text = "JOİN";
            buttonJoin.UseVisualStyleBackColor = false;
            buttonJoin.Click += buttonJoin_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(581, 307);
            Controls.Add(buttonJoin);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBox1);
            Controls.Add(buttonCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += LOGIN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBox1;
        private Label labelName;
        private Label labelTitle;
        private Panel panel1;
        private Button buttonJoin;
    }
}