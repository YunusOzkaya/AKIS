
namespace AKIS
{
    partial class SifreDegistir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_yTekrar = new System.Windows.Forms.Label();
            this.label_captcha = new System.Windows.Forms.Label();
            this.textBox_eSifre = new System.Windows.Forms.TextBox();
            this.textBox_ySifre = new System.Windows.Forms.TextBox();
            this.textBox_ySifreT = new System.Windows.Forms.TextBox();
            this.textBox_captcha = new System.Windows.Forms.TextBox();
            this.label_hata = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.denemeDataset = new System.Windows.Forms.BindingSource(this.components);
            this._202325011DataSet = new AKIS._202325011DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._202325011DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre";
            // 
            // label_yTekrar
            // 
            this.label_yTekrar.AutoSize = true;
            this.label_yTekrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yTekrar.Location = new System.Drawing.Point(37, 160);
            this.label_yTekrar.Name = "label_yTekrar";
            this.label_yTekrar.Size = new System.Drawing.Size(130, 19);
            this.label_yTekrar.TabIndex = 2;
            this.label_yTekrar.Text = "Yeni Şifre(Tekrar)";
            // 
            // label_captcha
            // 
            this.label_captcha.AutoSize = true;
            this.label_captcha.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_captcha.Location = new System.Drawing.Point(111, 213);
            this.label_captcha.Name = "label_captcha";
            this.label_captcha.Size = new System.Drawing.Size(51, 19);
            this.label_captcha.TabIndex = 3;
            this.label_captcha.Text = "label4";
            // 
            // textBox_eSifre
            // 
            this.textBox_eSifre.Location = new System.Drawing.Point(204, 64);
            this.textBox_eSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_eSifre.Name = "textBox_eSifre";
            this.textBox_eSifre.Size = new System.Drawing.Size(183, 22);
            this.textBox_eSifre.TabIndex = 4;
            // 
            // textBox_ySifre
            // 
            this.textBox_ySifre.Location = new System.Drawing.Point(204, 114);
            this.textBox_ySifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ySifre.Name = "textBox_ySifre";
            this.textBox_ySifre.Size = new System.Drawing.Size(183, 22);
            this.textBox_ySifre.TabIndex = 5;
            // 
            // textBox_ySifreT
            // 
            this.textBox_ySifreT.Location = new System.Drawing.Point(204, 162);
            this.textBox_ySifreT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ySifreT.Name = "textBox_ySifreT";
            this.textBox_ySifreT.Size = new System.Drawing.Size(183, 22);
            this.textBox_ySifreT.TabIndex = 6;
            // 
            // textBox_captcha
            // 
            this.textBox_captcha.Location = new System.Drawing.Point(279, 213);
            this.textBox_captcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_captcha.Name = "textBox_captcha";
            this.textBox_captcha.Size = new System.Drawing.Size(107, 22);
            this.textBox_captcha.TabIndex = 7;
            // 
            // label_hata
            // 
            this.label_hata.AutoSize = true;
            this.label_hata.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hata.ForeColor = System.Drawing.Color.Firebrick;
            this.label_hata.Location = new System.Drawing.Point(37, 398);
            this.label_hata.Name = "label_hata";
            this.label_hata.Size = new System.Drawing.Size(0, 19);
            this.label_hata.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(227, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denemeDataset
            // 
            this.denemeDataset.AllowNew = true;
            this.denemeDataset.DataSource = this._202325011DataSet;
            this.denemeDataset.Position = 0;
            this.denemeDataset.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // _202325011DataSet
            // 
            this._202325011DataSet.DataSetName = "_202325011DataSet";
            this._202325011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_hata);
            this.Controls.Add(this.textBox_captcha);
            this.Controls.Add(this.textBox_ySifreT);
            this.Controls.Add(this.textBox_ySifre);
            this.Controls.Add(this.textBox_eSifre);
            this.Controls.Add(this.label_captcha);
            this.Controls.Add(this.label_yTekrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SifreDegistir";
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._202325011DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_yTekrar;
        private System.Windows.Forms.Label label_captcha;
        private System.Windows.Forms.TextBox textBox_eSifre;
        private System.Windows.Forms.TextBox textBox_ySifre;
        private System.Windows.Forms.TextBox textBox_ySifreT;
        private System.Windows.Forms.TextBox textBox_captcha;
        private System.Windows.Forms.Label label_hata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource denemeDataset;
        private _202325011DataSet _202325011DataSet;
    }
}