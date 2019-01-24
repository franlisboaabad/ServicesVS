namespace ProjectServices.Vistas.Listas
{
    partial class FormServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataservicios = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataservicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataservicios
            // 
            this.dataservicios.AllowUserToAddRows = false;
            this.dataservicios.AllowUserToDeleteRows = false;
            this.dataservicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataservicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataservicios.Location = new System.Drawing.Point(28, 100);
            this.dataservicios.Margin = new System.Windows.Forms.Padding(4);
            this.dataservicios.Name = "dataservicios";
            this.dataservicios.ReadOnly = true;
            this.dataservicios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataservicios.Size = new System.Drawing.Size(1148, 413);
            this.dataservicios.TabIndex = 12;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnseleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseleccionar.Location = new System.Drawing.Point(903, 521);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(273, 55);
            this.btnseleccionar.TabIndex = 11;
            this.btnseleccionar.Text = "Seleccionar Servicio";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // textbuscar
            // 
            this.textbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.Location = new System.Drawing.Point(236, 41);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textbuscar.Multiline = true;
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(516, 36);
            this.textbuscar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "BUSCAR SERVICIO";
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dataservicios);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormServicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServicios_FormClosing);
            this.Load += new System.EventHandler(this.FormServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataservicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataservicios;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label1;
    }
}