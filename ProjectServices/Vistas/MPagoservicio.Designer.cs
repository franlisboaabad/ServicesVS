namespace ProjectServices.Vistas
{
    partial class MPagoservicio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Combotpagoservicio = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textsaldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelmonto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtvuelto = new System.Windows.Forms.TextBox();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.textcliente = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Combotpagoservicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textsaldo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelmonto);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtvuelto);
            this.groupBox2.Controls.Add(this.txtpago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEfectivo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 542);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESUMEN DE SERVICIO";
            // 
            // Combotpagoservicio
            // 
            this.Combotpagoservicio.FormattingEnabled = true;
            this.Combotpagoservicio.ItemHeight = 24;
            this.Combotpagoservicio.Items.AddRange(new object[] {
            "COMPLETO",
            "PARCIAL"});
            this.Combotpagoservicio.Location = new System.Drawing.Point(254, 116);
            this.Combotpagoservicio.Name = "Combotpagoservicio";
            this.Combotpagoservicio.Size = new System.Drawing.Size(190, 30);
            this.Combotpagoservicio.TabIndex = 13;
            this.Combotpagoservicio.UseSelectable = true;
            this.Combotpagoservicio.SelectedIndexChanged += new System.EventHandler(this.Combotpagoservicio_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "TIPO DE PAGO";
            // 
            // textsaldo
            // 
            this.textsaldo.Location = new System.Drawing.Point(254, 291);
            this.textsaldo.Multiline = true;
            this.textsaldo.Name = "textsaldo";
            this.textsaldo.ReadOnly = true;
            this.textsaldo.Size = new System.Drawing.Size(190, 36);
            this.textsaldo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "SALDO :";
            // 
            // labelmonto
            // 
            this.labelmonto.AutoSize = true;
            this.labelmonto.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonto.Location = new System.Drawing.Point(297, 68);
            this.labelmonto.Name = "labelmonto";
            this.labelmonto.Size = new System.Drawing.Size(47, 34);
            this.labelmonto.TabIndex = 9;
            this.labelmonto.Text = "00";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(336, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 110);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 110);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtvuelto
            // 
            this.txtvuelto.Location = new System.Drawing.Point(254, 239);
            this.txtvuelto.Multiline = true;
            this.txtvuelto.Name = "txtvuelto";
            this.txtvuelto.ReadOnly = true;
            this.txtvuelto.Size = new System.Drawing.Size(190, 36);
            this.txtvuelto.TabIndex = 6;
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(254, 176);
            this.txtpago.Multiline = true;
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(190, 36);
            this.txtpago.TabIndex = 5;
            this.txtpago.TextChanged += new System.EventHandler(this.txtpago_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "S/ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "VUELTO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAGO S/ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL DE SERVICIO";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Image = global::ProjectServices.Properties.Resources.cash1;
            this.btnEfectivo.Location = new System.Drawing.Point(29, 410);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(130, 110);
            this.btnEfectivo.TabIndex = 8;
            this.btnEfectivo.Text = "EFECTIVO";
            this.btnEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcelular);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.textcliente);
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 542);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(172, 356);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(228, 36);
            this.txtcelular.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "CELULAR";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(172, 312);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(228, 36);
            this.txtdireccion.TabIndex = 3;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(172, 268);
            this.txtdocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtdocumento.Multiline = true;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(228, 36);
            this.txtdocumento.TabIndex = 2;
            // 
            // textcliente
            // 
            this.textcliente.Location = new System.Drawing.Point(172, 224);
            this.textcliente.Margin = new System.Windows.Forms.Padding(4);
            this.textcliente.Multiline = true;
            this.textcliente.Name = "textcliente";
            this.textcliente.Size = new System.Drawing.Size(228, 36);
            this.textcliente.TabIndex = 1;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(7, 43);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcliente.Multiline = true;
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(40, 36);
            this.txtidcliente.TabIndex = 32;
            this.txtidcliente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "NOMBRES ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "DOCUMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 22);
            this.label8.TabIndex = 31;
            this.label8.Text = "DIRECCION ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectServices.Properties.Resources.Contacts;
            this.pictureBox1.Location = new System.Drawing.Point(172, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MPagoservicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MPagoservicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MPagoservicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labelmonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtvuelto;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtdocumento;
        public System.Windows.Forms.TextBox textcliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textsaldo;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox Combotpagoservicio;
    }
}