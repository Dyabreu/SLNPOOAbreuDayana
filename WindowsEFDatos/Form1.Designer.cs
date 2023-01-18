namespace WindowsEFDatos
{
    partial class frmAvion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.gridAvion = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblDenominacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(548, 48);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(148, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar Avión";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // gridAvion
            // 
            this.gridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvion.Location = new System.Drawing.Point(61, 255);
            this.gridAvion.Name = "gridAvion";
            this.gridAvion.RowHeadersWidth = 51;
            this.gridAvion.RowTemplate.Height = 24;
            this.gridAvion.Size = new System.Drawing.Size(689, 150);
            this.gridAvion.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(127, 140);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 22);
            this.txtCapacidad.TabIndex = 3;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(307, 140);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 22);
            this.txtDenominacion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(126, 121);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(83, 16);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenominacion.Location = new System.Drawing.Point(304, 121);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(106, 16);
            this.lblDenominacion.TabIndex = 8;
            this.lblDenominacion.Text = "Denominación";
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDenominacion);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridAvion);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmAvion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView gridAvion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblDenominacion;
    }
}

