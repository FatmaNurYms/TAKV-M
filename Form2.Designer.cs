namespace PROJECT1
{
    partial class Form2
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
            DayContainer = new FlowLayoutPanel();
            buttonPrevious = new Button();
            buttonNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelDATE = new Label();
            panel1 = new Panel();
            labelName = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DayContainer
            // 
            DayContainer.Location = new Point(9, 132);
            DayContainer.Name = "DayContainer";
            DayContainer.Size = new Size(1234, 746);
            DayContainer.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.FromArgb(255, 192, 128);
            buttonPrevious.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrevious.Location = new Point(975, 896);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(94, 30);
            buttonPrevious.TabIndex = 1;
            buttonPrevious.Text = "previous";
            buttonPrevious.UseVisualStyleBackColor = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(255, 192, 128);
            buttonNext.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.Location = new Point(1091, 896);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 29);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 92);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 3;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(228, 92);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(404, 92);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 5;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(567, 92);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 6;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(753, 92);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 7;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(937, 92);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 8;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1105, 92);
            label7.Name = "label7";
            label7.Size = new Size(95, 24);
            label7.TabIndex = 9;
            label7.Text = "Saturday";
            // 
            // labelDATE
            // 
            labelDATE.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDATE.Location = new Point(415, 32);
            labelDATE.Name = "labelDATE";
            labelDATE.Size = new Size(403, 36);
            labelDATE.TabIndex = 10;
            labelDATE.Text = "MONTH YEAR";
            labelDATE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(labelName);
            panel1.Location = new Point(1249, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 746);
            panel1.TabIndex = 11;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Imprint MT Shadow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.WhiteSmoke;
            labelName.Location = new Point(24, 67);
            labelName.Name = "labelName";
            labelName.Size = new Size(131, 21);
            labelName.TabIndex = 4;
            labelName.Text = "SCHEDULE:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(24, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 544);
            listBox1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1602, 972);
            Controls.Add(panel1);
            Controls.Add(labelDATE);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(DayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel DayContainer;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelDATE;
        private Panel panel1;
        private ListBox listBox1;
        private Label labelName;
    }
}