namespace Excel
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
            this.DataDetalles = new System.Windows.Forms.DataGridView();
            this.BtnImportarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDetalles
            // 
            this.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalles.Location = new System.Drawing.Point(3, 3);
            this.DataDetalles.Name = "DataDetalles";
            this.DataDetalles.Size = new System.Drawing.Size(629, 444);
            this.DataDetalles.TabIndex = 0;
            // 
            // BtnImportarDatos
            // 
            this.BtnImportarDatos.Location = new System.Drawing.Point(638, 3);
            this.BtnImportarDatos.Name = "BtnImportarDatos";
            this.BtnImportarDatos.Size = new System.Drawing.Size(150, 50);
            this.BtnImportarDatos.TabIndex = 1;
            this.BtnImportarDatos.Text = "Importar datos";
            this.BtnImportarDatos.UseVisualStyleBackColor = true;
            this.BtnImportarDatos.Click += new System.EventHandler(this.BtnImportarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnImportarDatos);
            this.Controls.Add(this.DataDetalles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataDetalles;
        private System.Windows.Forms.Button BtnImportarDatos;
    }
}

