namespace ArbolDesR
{
    partial class Form1
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
            this.dgvArchivo = new System.Windows.Forms.DataGridView();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnGArbol = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchivo
            // 
            this.dgvArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivo.Location = new System.Drawing.Point(12, 12);
            this.dgvArchivo.Name = "dgvArchivo";
            this.dgvArchivo.Size = new System.Drawing.Size(537, 321);
            this.dgvArchivo.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 339);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(537, 99);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnGArbol
            // 
            this.btnGArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGArbol.Location = new System.Drawing.Point(594, 44);
            this.btnGArbol.Name = "btnGArbol";
            this.btnGArbol.Size = new System.Drawing.Size(161, 58);
            this.btnGArbol.TabIndex = 2;
            this.btnGArbol.Text = "Árbol";
            this.btnGArbol.UseVisualStyleBackColor = true;
            this.btnGArbol.Click += new System.EventHandler(this.btnGArbol_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.Location = new System.Drawing.Point(594, 160);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(161, 58);
            this.btnArchivo.TabIndex = 3;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnGArbol);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.dgvArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnGArbol;
        private System.Windows.Forms.Button btnArchivo;
    }
}

