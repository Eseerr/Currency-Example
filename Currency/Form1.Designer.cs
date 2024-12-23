namespace Currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboKur = new System.Windows.Forms.ComboBox();
            this.butonCevir = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lblkur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboKur
            // 
            this.comboKur.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboKur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKur.FormattingEnabled = true;
            this.comboKur.Items.AddRange(new object[] {
            "USD",
            "EURO"});
            this.comboKur.Location = new System.Drawing.Point(60, 52);
            this.comboKur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboKur.Name = "comboKur";
            this.comboKur.Size = new System.Drawing.Size(91, 23);
            this.comboKur.TabIndex = 0;
            // 
            // butonCevir
            // 
            this.butonCevir.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonCevir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butonCevir.Location = new System.Drawing.Point(60, 134);
            this.butonCevir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butonCevir.Name = "butonCevir";
            this.butonCevir.Size = new System.Drawing.Size(91, 23);
            this.butonCevir.TabIndex = 2;
            this.butonCevir.Text = "Çevir";
            this.butonCevir.UseVisualStyleBackColor = true;
            this.butonCevir.Click += new System.EventHandler(this.butonCevir_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(60, 97);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(91, 23);
            this.txtMiktar.TabIndex = 1;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsonuc.Location = new System.Drawing.Point(57, 205);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(47, 15);
            this.lblsonuc.TabIndex = 3;
            this.lblsonuc.Text = "label1";
            // 
            // lblkur
            // 
            this.lblkur.AutoSize = true;
            this.lblkur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkur.Location = new System.Drawing.Point(57, 174);
            this.lblkur.Name = "lblkur";
            this.lblkur.Size = new System.Drawing.Size(47, 15);
            this.lblkur.TabIndex = 3;
            this.lblkur.Text = "label1";
            this.lblkur.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 256);
            this.Controls.Add(this.lblkur);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.butonCevir);
            this.Controls.Add(this.comboKur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Döviz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKur;
        private System.Windows.Forms.Button butonCevir;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lblkur;
    }
}

