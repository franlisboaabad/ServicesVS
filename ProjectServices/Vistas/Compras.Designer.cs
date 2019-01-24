namespace ProjectServices.Vistas
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridaProductos = new System.Windows.Forms.DataGridView();
            this.btnproductos = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelImporte = new System.Windows.Forms.Label();
            this.lblsol = new System.Windows.Forms.Label();
            this.btnNuevi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.GridaCompras = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpcompra = new System.Windows.Forms.TextBox();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpcompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GridaProductos);
            this.groupBox1.Controls.Add(this.btnproductos);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 729);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // GridaProductos
            // 
            this.GridaProductos.AllowUserToAddRows = false;
            this.GridaProductos.AllowUserToDeleteRows = false;
            this.GridaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridaProductos.Location = new System.Drawing.Point(15, 127);
            this.GridaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.GridaProductos.Name = "GridaProductos";
            this.GridaProductos.ReadOnly = true;
            this.GridaProductos.Size = new System.Drawing.Size(606, 465);
            this.GridaProductos.TabIndex = 30;
            // 
            // btnproductos
            // 
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = global::ProjectServices.Properties.Resources.add;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(456, 666);
            this.btnproductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(165, 55);
            this.btnproductos.TabIndex = 29;
            this.btnproductos.Text = "Agregar ";
            this.btnproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(291, 625);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(147, 36);
            this.txtcantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD DE PRODUCTO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 30);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "BUSCAR PRODUCTO ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(237, 46);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(280, 30);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIAS ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(660, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 72);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(483, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "LISTA DE PRODUCTOS ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.labelImporte);
            this.panel3.Controls.Add(this.lblsol);
            this.panel3.Controls.Add(this.btnNuevi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Location = new System.Drawing.Point(660, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 72);
            this.panel3.TabIndex = 3;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.ForeColor = System.Drawing.Color.White;
            this.labelImporte.Location = new System.Drawing.Point(1077, 26);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(86, 34);
            this.labelImporte.TabIndex = 38;
            this.labelImporte.Text = "00.00";
            // 
            // lblsol
            // 
            this.lblsol.AutoSize = true;
            this.lblsol.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsol.ForeColor = System.Drawing.Color.White;
            this.lblsol.Location = new System.Drawing.Point(1023, 26);
            this.lblsol.Name = "lblsol";
            this.lblsol.Size = new System.Drawing.Size(48, 34);
            this.lblsol.TabIndex = 35;
            this.lblsol.Text = "S/.";
            // 
            // btnNuevi
            // 
            this.btnNuevi.BackColor = System.Drawing.Color.White;
            this.btnNuevi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevi.Image = global::ProjectServices.Properties.Resources.Editar;
            this.btnNuevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevi.Location = new System.Drawing.Point(19, 9);
            this.btnNuevi.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevi.Name = "btnNuevi";
            this.btnNuevi.Size = new System.Drawing.Size(245, 55);
            this.btnNuevi.TabIndex = 37;
            this.btnNuevi.Text = "Nueva compra";
            this.btnNuevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevi.UseVisualStyleBackColor = false;
            this.btnNuevi.Click += new System.EventHandler(this.btnNuevi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(728, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 34);
            this.label6.TabIndex = 34;
            this.label6.Text = "TOTAL DE COMPRA :";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = global::ProjectServices.Properties.Resources.imprimir;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(272, 9);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(275, 55);
            this.btnGenerar.TabIndex = 36;
            this.btnGenerar.Text = "Generar compra";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // GridaCompras
            // 
            this.GridaCompras.AllowUserToAddRows = false;
            this.GridaCompras.AllowUserToDeleteRows = false;
            this.GridaCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTO,
            this.CANTIDAD,
            this.PRECIO_COMPRA,
            this.SUB_TOTAL,
            this.CODIGO});
            this.GridaCompras.Location = new System.Drawing.Point(660, 114);
            this.GridaCompras.Margin = new System.Windows.Forms.Padding(4);
            this.GridaCompras.Name = "GridaCompras";
            this.GridaCompras.ReadOnly = true;
            this.GridaCompras.Size = new System.Drawing.Size(1209, 524);
            this.GridaCompras.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "PRECIO DE COMPRA";
            // 
            // txtpcompra
            // 
            this.txtpcompra.Location = new System.Drawing.Point(291, 675);
            this.txtpcompra.Multiline = true;
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(147, 36);
            this.txtpcompra.TabIndex = 32;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.Width = 250;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 200;
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.ReadOnly = true;
            this.PRECIO_COMPRA.Width = 200;
            // 
            // SUB_TOTAL
            // 
            this.SUB_TOTAL.HeaderText = "SUB_TOTAL";
            this.SUB_TOTAL.Name = "SUB_TOTAL";
            this.SUB_TOTAL.ReadOnly = true;
            this.SUB_TOTAL.Width = 200;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.GridaCompras);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Compras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPRA DE PRODUCTOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.DataGridView GridaProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView GridaCompras;
        private System.Windows.Forms.Button btnNuevi;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblsol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox txtpcompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
    }
}