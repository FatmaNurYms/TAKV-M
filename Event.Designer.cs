namespace PROJECT1
{
    partial class Event
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            labelName = new Label();
            richTextBoxComment = new RichTextBox();
            textBoxTitle = new TextBox();
            buttonSave = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(29, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 523);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(richTextBoxComment);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 433);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "EXPLANATION";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox2.Location = new Point(169, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(68, 31);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox1.Location = new Point(95, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(68, 31);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 249);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 6;
            label2.Text = "Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 127);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 5;
            label1.Text = "Comment:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(220, 67);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 21);
            labelName.TabIndex = 4;
            labelName.Text = "Title:";
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(301, 125);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(331, 245);
            richTextBoxComment.TabIndex = 3;
            richTextBoxComment.Text = "";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(301, 65);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(331, 30);
            textBoxTitle.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.SaddleBrown;
            buttonSave.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = SystemColors.ButtonHighlight;
            buttonSave.Location = new Point(560, 458);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 37);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(794, 581);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Event";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxComment;
        private TextBox textBoxTitle;
        private Button buttonSave;
        private Label label1;
        private Label labelName;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}