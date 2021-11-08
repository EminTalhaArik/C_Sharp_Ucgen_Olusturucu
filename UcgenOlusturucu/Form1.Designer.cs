
namespace UcgenOlusturucu
{
    partial class frm_yildizOlusturucu
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
            this.lbl_tur = new System.Windows.Forms.Label();
            this.cbx_turler = new System.Windows.Forms.ComboBox();
            this.btn_yildizOlustur = new System.Windows.Forms.Button();
            this.lbx_yildiz = new System.Windows.Forms.ListBox();
            this.tbx_satirSayisi = new System.Windows.Forms.TextBox();
            this.lbl_satir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Location = new System.Drawing.Point(43, 20);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(42, 17);
            this.lbl_tur.TabIndex = 0;
            this.lbl_tur.Text = "Tür : ";
            // 
            // cbx_turler
            // 
            this.cbx_turler.FormattingEnabled = true;
            this.cbx_turler.Items.AddRange(new object[] {
            "Dik Üçgen",
            "Eşkenar Üçgen",
            "Ters Üçgen",
            "Baklava Dilimi",
            "Ev",
            "Kare"});
            this.cbx_turler.Location = new System.Drawing.Point(119, 17);
            this.cbx_turler.Name = "cbx_turler";
            this.cbx_turler.Size = new System.Drawing.Size(182, 24);
            this.cbx_turler.TabIndex = 1;
            this.cbx_turler.SelectedIndexChanged += new System.EventHandler(this.cbx_turler_SelectedIndexChanged);
            // 
            // btn_yildizOlustur
            // 
            this.btn_yildizOlustur.Enabled = false;
            this.btn_yildizOlustur.Location = new System.Drawing.Point(351, 14);
            this.btn_yildizOlustur.Name = "btn_yildizOlustur";
            this.btn_yildizOlustur.Size = new System.Drawing.Size(75, 55);
            this.btn_yildizOlustur.TabIndex = 3;
            this.btn_yildizOlustur.Text = "Oluştur";
            this.btn_yildizOlustur.UseVisualStyleBackColor = true;
            this.btn_yildizOlustur.Click += new System.EventHandler(this.btn_yildizOlustur_Click);
            // 
            // lbx_yildiz
            // 
            this.lbx_yildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbx_yildiz.FormattingEnabled = true;
            this.lbx_yildiz.ItemHeight = 25;
            this.lbx_yildiz.Location = new System.Drawing.Point(12, 88);
            this.lbx_yildiz.Name = "lbx_yildiz";
            this.lbx_yildiz.Size = new System.Drawing.Size(514, 329);
            this.lbx_yildiz.TabIndex = 4;
            // 
            // tbx_satirSayisi
            // 
            this.tbx_satirSayisi.Location = new System.Drawing.Point(119, 47);
            this.tbx_satirSayisi.Name = "tbx_satirSayisi";
            this.tbx_satirSayisi.Size = new System.Drawing.Size(121, 22);
            this.tbx_satirSayisi.TabIndex = 2;
            this.tbx_satirSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_satirSayisi_KeyPress);
            // 
            // lbl_satir
            // 
            this.lbl_satir.AutoSize = true;
            this.lbl_satir.Location = new System.Drawing.Point(43, 52);
            this.lbl_satir.Name = "lbl_satir";
            this.lbl_satir.Size = new System.Drawing.Size(45, 17);
            this.lbl_satir.TabIndex = 5;
            this.lbl_satir.Text = "Saır : ";
            // 
            // frm_yildizOlusturucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 444);
            this.Controls.Add(this.lbl_satir);
            this.Controls.Add(this.tbx_satirSayisi);
            this.Controls.Add(this.lbx_yildiz);
            this.Controls.Add(this.btn_yildizOlustur);
            this.Controls.Add(this.cbx_turler);
            this.Controls.Add(this.lbl_tur);
            this.MaximizeBox = false;
            this.Name = "frm_yildizOlusturucu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Yıldız Oluşturucu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.ComboBox cbx_turler;
        private System.Windows.Forms.Button btn_yildizOlustur;
        private System.Windows.Forms.ListBox lbx_yildiz;
        private System.Windows.Forms.TextBox tbx_satirSayisi;
        private System.Windows.Forms.Label lbl_satir;
    }
}

