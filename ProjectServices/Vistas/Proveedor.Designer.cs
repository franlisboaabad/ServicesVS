namespace ProjectServices.Vistas
{
    partial class Proveedor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textcelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textlocalidad = new System.Windows.Forms.TextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.textruc = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textrazonsocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.checkDelete = new System.Windows.Forms.CheckBox();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataproveedor = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textemail);
            this.tabPage1.Controls.Add(this.textcelular);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textlocalidad);
            this.tabPage1.Controls.Add(this.textdireccion);
            this.tabPage1.Controls.Add(this.textruc);
            this.tabPage1.Controls.Add(this.btnupdate);
            this.tabPage1.Controls.Add(this.btncancel);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.btnnuevo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textrazonsocial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1072, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(272, 313);
            this.textemail.Margin = new System.Windows.Forms.Padding(4);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(345, 36);
            this.textemail.TabIndex = 6;
            // 
            // textcelular
            // 
            this.textcelular.Location = new System.Drawing.Point(272, 258);
            this.textcelular.Margin = new System.Windows.Forms.Padding(4);
            this.textcelular.Multiline = true;
            this.textcelular.Name = "textcelular";
            this.textcelular.Size = new System.Drawing.Size(345, 36);
            this.textcelular.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "EMAIL";
            // 
            // textlocalidad
            // 
            this.textlocalidad.Location = new System.Drawing.Point(272, 207);
            this.textlocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.textlocalidad.Multiline = true;
            this.textlocalidad.Name = "textlocalidad";
            this.textlocalidad.Size = new System.Drawing.Size(471, 36);
            this.textlocalidad.TabIndex = 4;
            // 
            // textdireccion
            // 
            this.textdireccion.Location = new System.Drawing.Point(272, 155);
            this.textdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textdireccion.Multiline = true;
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(471, 36);
            this.textdireccion.TabIndex = 3;
            // 
            // textruc
            // 
            this.textruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textruc.Location = new System.Drawing.Point(272, 43);
            this.textruc.Margin = new System.Windows.Forms.Padding(4);
            this.textruc.Multiline = true;
            this.textruc.Name = "textruc";
            this.textruc.Size = new System.Drawing.Size(284, 36);
            this.textruc.TabIndex = 1;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = global::ProjectServices.Properties.Resources.Editar;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(565, 417);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 55);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Editar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = global::ProjectServices.Properties.Resources.X;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(720, 417);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(160, 55);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::ProjectServices.Properties.Resources.Guardar;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(397, 417);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(160, 55);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Guardar";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::ProjectServices.Properties.Resources.Nuevo;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(188, 417);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(147, 55);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "CELULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "CIUDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIRECCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "RUC ";
            // 
            // textrazonsocial
            // 
            this.textrazonsocial.Location = new System.Drawing.Point(272, 102);
            this.textrazonsocial.Margin = new System.Windows.Forms.Padding(4);
            this.textrazonsocial.Multiline = true;
            this.textrazonsocial.Name = "textrazonsocial";
            this.textrazonsocial.Size = new System.Drawing.Size(655, 36);
            this.textrazonsocial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "RAZON SOCIAL";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.textcodigo);
            this.tabPage2.Controls.Add(this.checkDelete);
            this.tabPage2.Controls.Add(this.textbuscar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataproveedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1072, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(3, 16);
            this.textcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(36, 30);
            this.textcodigo.TabIndex = 15;
            this.textcodigo.Visible = false;
            // 
            // checkDelete
            // 
            this.checkDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDelete.Image = global::ProjectServices.Properties.Resources.Eliminar;
            this.checkDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkDelete.Location = new System.Drawing.Point(769, 18);
            this.checkDelete.Margin = new System.Windows.Forms.Padding(4);
            this.checkDelete.Name = "checkDelete";
            this.checkDelete.Size = new System.Drawing.Size(159, 63);
            this.checkDelete.TabIndex = 14;
            this.checkDelete.Text = "Eliminar";
            this.checkDelete.UseVisualStyleBackColor = true;
            this.checkDelete.CheckedChanged += new System.EventHandler(this.checkDelete_CheckedChanged);
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(248, 34);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textbuscar.Multiline = true;
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(380, 36);
            this.textbuscar.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "BUSCAR CLIENTE";
            // 
            // dataproveedor
            // 
            this.dataproveedor.AllowUserToAddRows = false;
            this.dataproveedor.AllowUserToDeleteRows = false;
            this.dataproveedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproveedor.Location = new System.Drawing.Point(8, 86);
            this.dataproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.dataproveedor.Name = "dataproveedor";
            this.dataproveedor.ReadOnly = true;
            this.dataproveedor.Size = new System.Drawing.Size(1051, 400);
            this.dataproveedor.TabIndex = 11;
            this.dataproveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproveedor_CellClick);
            this.dataproveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproveedor_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1112, 566);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Proveedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textrazonsocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox textruc;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.TextBox textlocalidad;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textcelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.CheckBox checkDelete;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataproveedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}