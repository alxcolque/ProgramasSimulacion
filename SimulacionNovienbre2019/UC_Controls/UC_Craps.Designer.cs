namespace SimulacionNovienbre2019.UC_Controls
{
    partial class UC_Craps
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Craps));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJugar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGanaste = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnIntentar = new System.Windows.Forms.Button();
            this.lblProb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPerdiste = new System.Windows.Forms.Panel();
            this.lblPerdiste = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCraps = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgif = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGanaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPerdiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCraps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnJugar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnCraps);
            this.panel2.Controls.Add(this.imgif);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 561);
            this.panel2.TabIndex = 17;
            // 
            // btnJugar
            // 
            this.btnJugar.AutoEllipsis = true;
            this.btnJugar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnJugar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJugar.Location = new System.Drawing.Point(34, 23);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(116, 42);
            this.btnJugar.TabIndex = 17;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.pnlGanaste);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnIntentar);
            this.panel1.Controls.Add(this.lblProb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pnlPerdiste);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Controls.Add(this.lblP);
            this.panel1.Controls.Add(this.lblSuma);
            this.panel1.Controls.Add(this.lblDado2);
            this.panel1.Controls.Add(this.lblDado1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(180, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 475);
            this.panel1.TabIndex = 15;
            // 
            // pnlGanaste
            // 
            this.pnlGanaste.Controls.Add(this.label4);
            this.pnlGanaste.Controls.Add(this.pictureBox2);
            this.pnlGanaste.Location = new System.Drawing.Point(411, 73);
            this.pnlGanaste.Name = "pnlGanaste";
            this.pnlGanaste.Size = new System.Drawing.Size(189, 161);
            this.pnlGanaste.TabIndex = 22;
            this.pnlGanaste.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(53, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "GANASTE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.AutoEllipsis = true;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(42, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(175, 53);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "Jugar de Nuevo";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIntentar
            // 
            this.btnIntentar.AutoEllipsis = true;
            this.btnIntentar.BackColor = System.Drawing.Color.Green;
            this.btnIntentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIntentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIntentar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntentar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIntentar.Location = new System.Drawing.Point(42, 157);
            this.btnIntentar.Name = "btnIntentar";
            this.btnIntentar.Size = new System.Drawing.Size(175, 42);
            this.btnIntentar.TabIndex = 24;
            this.btnIntentar.Text = "Intentar ";
            this.btnIntentar.UseVisualStyleBackColor = false;
            this.btnIntentar.Visible = false;
            this.btnIntentar.Click += new System.EventHandler(this.btnIntentar_Click);
            // 
            // lblProb
            // 
            this.lblProb.AutoSize = true;
            this.lblProb.BackColor = System.Drawing.Color.Transparent;
            this.lblProb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProb.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblProb.Location = new System.Drawing.Point(195, 235);
            this.lblProb.Name = "lblProb";
            this.lblProb.Size = new System.Drawing.Size(0, 32);
            this.lblProb.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(38, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "PROBABILIDAD";
            // 
            // pnlPerdiste
            // 
            this.pnlPerdiste.Controls.Add(this.lblPerdiste);
            this.pnlPerdiste.Controls.Add(this.pictureBox1);
            this.pnlPerdiste.Location = new System.Drawing.Point(411, 73);
            this.pnlPerdiste.Name = "pnlPerdiste";
            this.pnlPerdiste.Size = new System.Drawing.Size(189, 161);
            this.pnlPerdiste.TabIndex = 21;
            this.pnlPerdiste.Visible = false;
            // 
            // lblPerdiste
            // 
            this.lblPerdiste.AutoSize = true;
            this.lblPerdiste.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdiste.ForeColor = System.Drawing.Color.Crimson;
            this.lblPerdiste.Location = new System.Drawing.Point(53, 129);
            this.lblPerdiste.Name = "lblPerdiste";
            this.lblPerdiste.Size = new System.Drawing.Size(88, 23);
            this.lblPerdiste.TabIndex = 20;
            this.lblPerdiste.Text = "PERDISTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblPuntos.Location = new System.Drawing.Point(155, 202);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 32);
            this.lblPuntos.TabIndex = 20;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblP.Location = new System.Drawing.Point(43, 211);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(82, 23);
            this.lblP.TabIndex = 19;
            this.lblP.Text = "PUNTOS";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.BackColor = System.Drawing.Color.Transparent;
            this.lblSuma.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.ForeColor = System.Drawing.Color.Gold;
            this.lblSuma.Location = new System.Drawing.Point(229, 73);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 44);
            this.lblSuma.TabIndex = 18;
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.BackColor = System.Drawing.Color.Transparent;
            this.lblDado2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblDado2.Location = new System.Drawing.Point(145, 112);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(0, 32);
            this.lblDado2.TabIndex = 17;
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.BackColor = System.Drawing.Color.Transparent;
            this.lblDado1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblDado1.Location = new System.Drawing.Point(145, 66);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(0, 32);
            this.lblDado1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "DADO 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "DADO 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "CRAPS";
            // 
            // btnCraps
            // 
            this.btnCraps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCraps.BackColor = System.Drawing.Color.Transparent;
            this.btnCraps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCraps.Image = ((System.Drawing.Image)(resources.GetObject("btnCraps.Image")));
            this.btnCraps.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnCraps.ImageActive")));
            this.btnCraps.Location = new System.Drawing.Point(904, 3);
            this.btnCraps.Name = "btnCraps";
            this.btnCraps.Size = new System.Drawing.Size(77, 50);
            this.btnCraps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCraps.TabIndex = 13;
            this.btnCraps.TabStop = false;
            this.btnCraps.Zoom = 10;
            this.btnCraps.Click += new System.EventHandler(this.btnCraps_Click);
            // 
            // imgif
            // 
            this.imgif.Image = ((System.Drawing.Image)(resources.GetObject("imgif.Image")));
            this.imgif.Location = new System.Drawing.Point(17, 92);
            this.imgif.Name = "imgif";
            this.imgif.Size = new System.Drawing.Size(157, 114);
            this.imgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgif.TabIndex = 16;
            this.imgif.TabStop = false;
            this.imgif.Visible = false;
            // 
            // UC_Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.panel2);
            this.Name = "UC_Craps";
            this.Size = new System.Drawing.Size(984, 561);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGanaste.ResumeLayout(false);
            this.pnlGanaste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPerdiste.ResumeLayout(false);
            this.pnlPerdiste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCraps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGanaste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnIntentar;
        private System.Windows.Forms.Label lblProb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPerdiste;
        private System.Windows.Forms.Label lblPerdiste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnCraps;
        private System.Windows.Forms.PictureBox imgif;
    }
}
