namespace Projeto_Seguranca
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureDefesa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureMarcador = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CriarServidor = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefesa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarcador)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "SUPER PENALTY KICK SECURED";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureDefesa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(454, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 260);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // pictureDefesa
            // 
            this.pictureDefesa.Image = ((System.Drawing.Image)(resources.GetObject("pictureDefesa.Image")));
            this.pictureDefesa.Location = new System.Drawing.Point(17, 79);
            this.pictureDefesa.Name = "pictureDefesa";
            this.pictureDefesa.Size = new System.Drawing.Size(180, 139);
            this.pictureDefesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDefesa.TabIndex = 2;
            this.pictureDefesa.TabStop = false;
            this.pictureDefesa.Click += new System.EventHandler(this.pictureDefesa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEFESA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureMarcador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(133, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 260);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureMarcador
            // 
            this.pictureMarcador.Image = ((System.Drawing.Image)(resources.GetObject("pictureMarcador.Image")));
            this.pictureMarcador.Location = new System.Drawing.Point(33, 79);
            this.pictureMarcador.Name = "pictureMarcador";
            this.pictureMarcador.Size = new System.Drawing.Size(136, 128);
            this.pictureMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMarcador.TabIndex = 3;
            this.pictureMarcador.TabStop = false;
            this.pictureMarcador.Click += new System.EventHandler(this.pictureMarcador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARCADOR";
            // 
            // bt_CriarServidor
            // 
            this.bt_CriarServidor.Location = new System.Drawing.Point(320, 91);
            this.bt_CriarServidor.Name = "bt_CriarServidor";
            this.bt_CriarServidor.Size = new System.Drawing.Size(156, 43);
            this.bt_CriarServidor.TabIndex = 8;
            this.bt_CriarServidor.Text = "Criar Servidor";
            this.bt_CriarServidor.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_CriarServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefesa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMarcador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureDefesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureMarcador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CriarServidor;
    }
}

