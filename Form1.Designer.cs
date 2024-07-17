
namespace DijitalSaatForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelsaaat = new System.Windows.Forms.Label();
            this.labeldk = new System.Windows.Forms.Label();
            this.labelsaniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelsaaat
            // 
            this.labelsaaat.AutoSize = true;
            this.labelsaaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaaat.Location = new System.Drawing.Point(289, 164);
            this.labelsaaat.Name = "labelsaaat";
            this.labelsaaat.Size = new System.Drawing.Size(49, 32);
            this.labelsaaat.TabIndex = 0;
            this.labelsaaat.Text = "00";
            // 
            // labeldk
            // 
            this.labeldk.AutoSize = true;
            this.labeldk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldk.Location = new System.Drawing.Point(497, 164);
            this.labeldk.Name = "labeldk";
            this.labeldk.Size = new System.Drawing.Size(49, 32);
            this.labeldk.TabIndex = 1;
            this.labeldk.Text = "00";
            // 
            // labelsaniye
            // 
            this.labelsaniye.AutoSize = true;
            this.labelsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaniye.Location = new System.Drawing.Point(719, 164);
            this.labelsaniye.Name = "labelsaniye";
            this.labelsaniye.Size = new System.Drawing.Size(49, 32);
            this.labelsaniye.TabIndex = 2;
            this.labelsaniye.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 516);
            this.Controls.Add(this.labelsaniye);
            this.Controls.Add(this.labeldk);
            this.Controls.Add(this.labelsaaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelsaaat;
        private System.Windows.Forms.Label labeldk;
        private System.Windows.Forms.Label labelsaniye;
    }
}

