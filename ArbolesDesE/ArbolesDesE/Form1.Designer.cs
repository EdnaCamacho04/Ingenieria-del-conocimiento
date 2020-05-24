namespace ArbolesDesE
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
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Location = new System.Drawing.Point(12, 12);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.Size = new System.Drawing.Size(441, 426);
            this.dgvDataSet.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.GridColor = System.Drawing.Color.Gray;
            this.dgvDatos.Location = new System.Drawing.Point(459, 204);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(329, 234);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLeerArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerArchivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeerArchivo.Location = new System.Drawing.Point(544, 28);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(157, 59);
            this.btnLeerArchivo.TabIndex = 2;
            this.btnLeerArchivo.Text = "Leer Archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = false;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // btnArbol
            // 
            this.btnArbol.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArbol.Location = new System.Drawing.Point(544, 93);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(157, 69);
            this.btnArbol.TabIndex = 3;
            this.btnArbol.Text = "Generar árbol";
            this.btnArbol.UseVisualStyleBackColor = false;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.dgvDataSet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.Button btnArbol;
    }
}

