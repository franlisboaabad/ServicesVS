namespace ProjectServices.Vistas
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridaVentas = new System.Windows.Forms.DataGridView();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelImporte = new System.Windows.Forms.Label();
            this.btnNuevi = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblsol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnproductos = new System.Windows.Forms.Button();
            this.GridaProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(739, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 72);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(470, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // GridaVentas
            // 
            this.GridaVentas.AllowUserToAddRows = false;
            this.GridaVentas.AllowUserToDeleteRows = false;
            this.GridaVentas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTO,
            this.CANTIDAD,
            this.PRECIO_VENTA,
            this.SUB_TOTAL,
            this.CODIGO});
            this.GridaVentas.Location = new System.Drawing.Point(738, 115);
            this.GridaVentas.Margin = new System.Windows.Forms.Padding(4);
            this.GridaVentas.Name = "GridaVentas";
            this.GridaVentas.ReadOnly = true;
            this.GridaVentas.Size = new System.Drawing.Size(1172, 524);
            this.GridaVentas.TabIndex = 32;
            this.GridaVentas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridaVentas_CellMouseClick);
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
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO_VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            this.PRECIO_VENTA.ReadOnly = true;
            this.PRECIO_VENTA.Width = 200;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.labelImporte);
            this.panel2.Controls.Add(this.btnNuevi);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.lblsol);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(738, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 86);
            this.panel2.TabIndex = 33;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.ForeColor = System.Drawing.Color.White;
            this.labelImporte.Location = new System.Drawing.Point(1048, 34);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(86, 34);
            this.labelImporte.TabIndex = 36;
            this.labelImporte.Text = "00.00";
            // 
            // btnNuevi
            // 
            this.btnNuevi.BackColor = System.Drawing.Color.White;
            this.btnNuevi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevi.Image = global::ProjectServices.Properties.Resources.Editar;
            this.btnNuevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevi.Location = new System.Drawing.Point(17, 18);
            this.btnNuevi.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevi.Name = "btnNuevi";
            this.btnNuevi.Size = new System.Drawing.Size(230, 55);
            this.btnNuevi.TabIndex = 35;
            this.btnNuevi.Text = "Nueva Venta";
            this.btnNuevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevi.UseVisualStyleBackColor = false;
            this.btnNuevi.Click += new System.EventHandler(this.btnNuevi_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = global::ProjectServices.Properties.Resources.imprimir;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(255, 18);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(251, 55);
            this.btnGenerar.TabIndex = 34;
            this.btnGenerar.Text = "Generar Venta";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblsol
            // 
            this.lblsol.AutoSize = true;
            this.lblsol.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsol.ForeColor = System.Drawing.Color.White;
            this.lblsol.Location = new System.Drawing.Point(994, 34);
            this.lblsol.Name = "lblsol";
            this.lblsol.Size = new System.Drawing.Size(48, 34);
            this.lblsol.TabIndex = 1;
            this.lblsol.Text = "S/.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(729, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL DE VENTA : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btnproductos);
            this.groupBox1.Controls.Add(this.GridaProductos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 729);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcantidad.Location = new System.Drawing.Point(324, 673);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(163, 36);
            this.txtcantidad.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(31, 687);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(250, 22);
            this.label21.TabIndex = 37;
            this.label21.Text = "CANTIDAD DE PRODUCTO";
            // 
            // btnproductos
            // 
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = global::ProjectServices.Properties.Resources.add;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(517, 656);
            this.btnproductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(169, 55);
            this.btnproductos.TabIndex = 36;
            this.btnproductos.Text = "Agregar ";
            this.btnproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click_1);
            // 
            // GridaProductos
            // 
            this.GridaProductos.AllowUserToAddRows = false;
            this.GridaProductos.AllowUserToDeleteRows = false;
            this.GridaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridaProductos.Location = new System.Drawing.Point(15, 120);
            this.GridaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.GridaProductos.Name = "GridaProductos";
            this.GridaProductos.ReadOnly = true;
            this.GridaProductos.Size = new System.Drawing.Size(671, 527);
            this.GridaProductos.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "BUSCAR PRODUCTO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(298, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 36);
            this.textBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "CATEGORIAS ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(298, 29);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(349, 30);
            this.metroComboBox1.TabIndex = 31;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GridaVentas);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR VENTA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsol;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnNuevi;
        public System.Windows.Forms.DataGridView GridaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.DataGridView GridaProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}