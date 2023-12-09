namespace PROJECT1
{
    partial class UserControlDAYS
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            labeldays = new Label();
            SuspendLayout();
            // 
            // labeldays
            // 
            labeldays.AutoSize = true;
            labeldays.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            labeldays.Location = new Point(13, 13);
            labeldays.Name = "labeldays";
            labeldays.Size = new Size(36, 22);
            labeldays.TabIndex = 0;
            labeldays.Text = "00";
            // 
            // UserControlDAYS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(labeldays);
            Name = "UserControlDAYS";
            Size = new Size(169, 120);
            Click += UserControlDAYS_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeldays;
    }
}
