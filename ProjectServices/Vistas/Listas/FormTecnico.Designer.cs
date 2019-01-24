namespace ProjectServices.Vistas.Listas
{
    partial class FormTecnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datatecnicos = new System.Windows.Forms.DataGridView();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datatecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // datatecnicos
            // 
            this.datatecnicos.AllowUserToAddRows = false;
            this.datatecnicos.AllowUserToDeleteRows = false;
            this.datatecnicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datatecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datatecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatecnicos.Location = new System.Drawing.Point(31, 78);
            this.datatecnicos.Margin = new System.Windows.Forms.Padding(4);
            this.datatecnicos.Name = "datatecnicos";
            this.datatecnicos.ReadOnly = true;
            this.datatecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datatecnicos.Size = new System.Drawing.Size(872, 383);
            this.datatecnicos.TabIndex = 8;
            // 
            // textbuscar
            // 
            this.textbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.Location = new System.Drawing.Point(243, 33);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textbuscar.Multiline = true;
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(516, 36);
            this.textbuscar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "BUSCAR TÉCNICO";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnseleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseleccionar.Location = new System.Drawing.Point(629, 468);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(273, 55);
            this.btnseleccionar.TabIndex = 7;
            this.btnseleccionar.Text = "Seleccionar Técnico";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // FormTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.datatecnicos);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTecnico";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.FormTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datatecnicos;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label1;
    }
}