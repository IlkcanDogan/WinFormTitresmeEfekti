namespace TitresenmeEfekti
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTitrestir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitrestir
            // 
            this.btnTitrestir.Location = new System.Drawing.Point(52, 50);
            this.btnTitrestir.Name = "btnTitrestir";
            this.btnTitrestir.Size = new System.Drawing.Size(194, 101);
            this.btnTitrestir.TabIndex = 0;
            this.btnTitrestir.Text = "Titreştir";
            this.btnTitrestir.UseVisualStyleBackColor = true;
            this.btnTitrestir.Click += new System.EventHandler(this.btnTitrestir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 213);
            this.Controls.Add(this.btnTitrestir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitrestir;
    }
}

