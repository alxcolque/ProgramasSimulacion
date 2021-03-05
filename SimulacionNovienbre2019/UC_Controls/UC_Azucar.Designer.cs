namespace SimulacionNovienbre2019.UC_Controls
{
    partial class UC_Azucar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Azucar));
            this.txtPC = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPV = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCOrden = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvAzucar = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblVtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCDins = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGNeta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTEnt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCBod = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDMax = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarPnl = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAzucar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPnl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPC
            // 
            this.txtPC.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPC.Location = new System.Drawing.Point(66, 375);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(100, 27);
            this.txtPC.TabIndex = 121;
            this.txtPC.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(37, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 120;
            this.label8.Text = "Precio de Venta (Bs)";
            // 
            // txtPV
            // 
            this.txtPV.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPV.Location = new System.Drawing.Point(66, 319);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(100, 27);
            this.txtPV.TabIndex = 119;
            this.txtPV.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Costo de Orden (Bs)";
            // 
            // txtCOrden
            // 
            this.txtCOrden.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOrden.Location = new System.Drawing.Point(66, 263);
            this.txtCOrden.Name = "txtCOrden";
            this.txtCOrden.Size = new System.Drawing.Size(100, 27);
            this.txtCOrden.TabIndex = 117;
            this.txtCOrden.Text = "300";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(37, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "Precio de Compra(Bs)";
            // 
            // dtgvAzucar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvAzucar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAzucar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAzucar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.dtgvAzucar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAzucar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAzucar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAzucar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAzucar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAzucar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAzucar.DoubleBuffered = true;
            this.dtgvAzucar.EnableHeadersVisualStyles = false;
            this.dtgvAzucar.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dtgvAzucar.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvAzucar.Location = new System.Drawing.Point(342, 70);
            this.dtgvAzucar.Name = "dtgvAzucar";
            this.dtgvAzucar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvAzucar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvAzucar.Size = new System.Drawing.Size(398, 317);
            this.dtgvAzucar.TabIndex = 116;
            // 
            // lblVtotal
            // 
            this.lblVtotal.AutoSize = true;
            this.lblVtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVtotal.ForeColor = System.Drawing.Color.Gray;
            this.lblVtotal.Location = new System.Drawing.Point(466, 507);
            this.lblVtotal.Name = "lblVtotal";
            this.lblVtotal.Size = new System.Drawing.Size(24, 25);
            this.lblVtotal.TabIndex = 115;
            this.lblVtotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(379, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 114;
            this.label11.Text = "Venta Total";
            // 
            // lblCDins
            // 
            this.lblCDins.AutoSize = true;
            this.lblCDins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDins.ForeColor = System.Drawing.Color.Gray;
            this.lblCDins.Location = new System.Drawing.Point(466, 482);
            this.lblCDins.Name = "lblCDins";
            this.lblCDins.Size = new System.Drawing.Size(24, 25);
            this.lblCDins.TabIndex = 113;
            this.lblCDins.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(318, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = "Cantidad Insatisfecha";
            // 
            // lblGNeta
            // 
            this.lblGNeta.AutoSize = true;
            this.lblGNeta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGNeta.ForeColor = System.Drawing.Color.Gray;
            this.lblGNeta.Location = new System.Drawing.Point(678, 482);
            this.lblGNeta.Name = "lblGNeta";
            this.lblGNeta.Size = new System.Drawing.Size(62, 38);
            this.lblGNeta.TabIndex = 111;
            this.lblGNeta.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(642, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 110;
            this.label5.Text = "GANANCIA NETA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.ActiveBorderThickness = 1;
            this.btnCalcular.ActiveCornerRadius = 20;
            this.btnCalcular.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.ActiveForecolor = System.Drawing.Color.White;
            this.btnCalcular.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.ButtonText = "Resolver";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCalcular.IdleBorderThickness = 1;
            this.btnCalcular.IdleCornerRadius = 30;
            this.btnCalcular.IdleFillColor = System.Drawing.Color.Teal;
            this.btnCalcular.IdleForecolor = System.Drawing.Color.White;
            this.btnCalcular.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(40, 423);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 43);
            this.btnCalcular.TabIndex = 109;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Tiempo de entrega (dias)";
            // 
            // txtTEnt
            // 
            this.txtTEnt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTEnt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEnt.Location = new System.Drawing.Point(66, 207);
            this.txtTEnt.Name = "txtTEnt";
            this.txtTEnt.Size = new System.Drawing.Size(100, 27);
            this.txtTEnt.TabIndex = 107;
            this.txtTEnt.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Capacidad de la bodega (Kg)";
            // 
            // txtCBod
            // 
            this.txtCBod.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCBod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBod.Location = new System.Drawing.Point(66, 151);
            this.txtCBod.Name = "txtCBod";
            this.txtCBod.Size = new System.Drawing.Size(100, 27);
            this.txtCBod.TabIndex = 105;
            this.txtCBod.Text = "700";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Revision de in ventario (dias)";
            // 
            // txtDMax
            // 
            this.txtDMax.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDMax.Location = new System.Drawing.Point(66, 95);
            this.txtDMax.Name = "txtDMax";
            this.txtDMax.Size = new System.Drawing.Size(100, 27);
            this.txtDMax.TabIndex = 103;
            this.txtDMax.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(359, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Demanda de Azucar en una tienda";
            // 
            // btnCerrarPnl
            // 
            this.btnCerrarPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarPnl.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarPnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPnl.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPnl.Image")));
            this.btnCerrarPnl.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnCerrarPnl.ImageActive")));
            this.btnCerrarPnl.Location = new System.Drawing.Point(895, 12);
            this.btnCerrarPnl.Name = "btnCerrarPnl";
            this.btnCerrarPnl.Size = new System.Drawing.Size(77, 50);
            this.btnCerrarPnl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarPnl.TabIndex = 101;
            this.btnCerrarPnl.TabStop = false;
            this.btnCerrarPnl.Zoom = 10;
            this.btnCerrarPnl.Click += new System.EventHandler(this.btnCerrarPnl_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "inV Azucar";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Costo Mantenimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // UC_Azucar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCOrden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgvAzucar);
            this.Controls.Add(this.lblVtotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCDins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGNeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTEnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCBod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarPnl);
            this.Name = "UC_Azucar";
            this.Size = new System.Drawing.Size(984, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAzucar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPC;
        private System.Windows.Forms.Label label8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPV;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCOrden;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvAzucar;
        private System.Windows.Forms.Label lblVtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCDins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGNeta;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCalcular;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTEnt;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCBod;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDMax;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarPnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
