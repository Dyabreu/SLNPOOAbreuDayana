namespace PresentaciónVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Camion = new System.Windows.Forms.Button();
            this.btnAutoElec = new System.Windows.Forms.Button();
            this.btnRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Camion
            // 
            this.btn_Camion.Location = new System.Drawing.Point(177, 206);
            this.btn_Camion.Name = "btn_Camion";
            this.btn_Camion.Size = new System.Drawing.Size(169, 29);
            this.btn_Camion.TabIndex = 0;
            this.btn_Camion.Text = "Crear Camión";
            this.btn_Camion.UseVisualStyleBackColor = true;
            this.btn_Camion.Click += new System.EventHandler(this.btn_Camion_Click);
            // 
            // btnAutoElec
            // 
            this.btnAutoElec.Location = new System.Drawing.Point(397, 206);
            this.btnAutoElec.Name = "btnAutoElec";
            this.btnAutoElec.Size = new System.Drawing.Size(169, 29);
            this.btnAutoElec.TabIndex = 1;
            this.btnAutoElec.Text = "Crear Auto Eléctrico";
            this.btnAutoElec.UseVisualStyleBackColor = true;
            this.btnAutoElec.Click += new System.EventHandler(this.btnAutoElec_Click);
            // 
            // btnRemolque
            // 
            this.btnRemolque.Location = new System.Drawing.Point(294, 276);
            this.btnRemolque.Name = "btnRemolque";
            this.btnRemolque.Size = new System.Drawing.Size(169, 29);
            this.btnRemolque.TabIndex = 2;
            this.btnRemolque.Text = "Crear Remolque";
            this.btnRemolque.UseVisualStyleBackColor = true;
            this.btnRemolque.Click += new System.EventHandler(this.btnRemolque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemolque);
            this.Controls.Add(this.btnAutoElec);
            this.Controls.Add(this.btn_Camion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Camion;
        private Button btnAutoElec;
        private Button btnRemolque;
    }
}