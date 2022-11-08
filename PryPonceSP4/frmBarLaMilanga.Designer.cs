namespace PryPonceSP4
{
    partial class frmBarLaMilanga
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
            this.lblPostre = new System.Windows.Forms.Label();
            this.lblBebidaConAlcohol = new System.Windows.Forms.Label();
            this.lblBebidaSinAlcohol = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.txtBebidasConAlcohol = new System.Windows.Forms.TextBox();
            this.txtBebidasSinAlcohol = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.txtMozoDelDia = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Columna0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPostre
            // 
            this.lblPostre.AutoSize = true;
            this.lblPostre.Location = new System.Drawing.Point(528, 275);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(42, 13);
            this.lblPostre.TabIndex = 31;
            this.lblPostre.Text = "Postres";
            // 
            // lblBebidaConAlcohol
            // 
            this.lblBebidaConAlcohol.AutoSize = true;
            this.lblBebidaConAlcohol.Location = new System.Drawing.Point(375, 275);
            this.lblBebidaConAlcohol.Name = "lblBebidaConAlcohol";
            this.lblBebidaConAlcohol.Size = new System.Drawing.Size(89, 13);
            this.lblBebidaConAlcohol.TabIndex = 30;
            this.lblBebidaConAlcohol.Text = "Bebida c/Alcohol";
            // 
            // lblBebidaSinAlcohol
            // 
            this.lblBebidaSinAlcohol.AutoSize = true;
            this.lblBebidaSinAlcohol.Location = new System.Drawing.Point(252, 275);
            this.lblBebidaSinAlcohol.Name = "lblBebidaSinAlcohol";
            this.lblBebidaSinAlcohol.Size = new System.Drawing.Size(88, 13);
            this.lblBebidaSinAlcohol.TabIndex = 29;
            this.lblBebidaSinAlcohol.Text = "Bebida s/Alcohol";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(148, 275);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(42, 13);
            this.lblComida.TabIndex = 12;
            this.lblComida.Text = "Comida";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(643, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total";
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(498, 291);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.ReadOnly = true;
            this.txtPostre.Size = new System.Drawing.Size(95, 20);
            this.txtPostre.TabIndex = 26;
            this.txtPostre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBebidasConAlcohol
            // 
            this.txtBebidasConAlcohol.Location = new System.Drawing.Point(378, 291);
            this.txtBebidasConAlcohol.Name = "txtBebidasConAlcohol";
            this.txtBebidasConAlcohol.ReadOnly = true;
            this.txtBebidasConAlcohol.Size = new System.Drawing.Size(95, 20);
            this.txtBebidasConAlcohol.TabIndex = 25;
            this.txtBebidasConAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBebidasSinAlcohol
            // 
            this.txtBebidasSinAlcohol.Location = new System.Drawing.Point(255, 291);
            this.txtBebidasSinAlcohol.Name = "txtBebidasSinAlcohol";
            this.txtBebidasSinAlcohol.ReadOnly = true;
            this.txtBebidasSinAlcohol.Size = new System.Drawing.Size(95, 20);
            this.txtBebidasSinAlcohol.TabIndex = 24;
            this.txtBebidasSinAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(122, 292);
            this.txtComida.Name = "txtComida";
            this.txtComida.ReadOnly = true;
            this.txtComida.Size = new System.Drawing.Size(95, 20);
            this.txtComida.TabIndex = 7;
            this.txtComida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotales
            // 
            this.txtTotales.Location = new System.Drawing.Point(610, 291);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(95, 20);
            this.txtTotales.TabIndex = 22;
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMozoDelDia
            // 
            this.txtMozoDelDia.Location = new System.Drawing.Point(122, 254);
            this.txtMozoDelDia.Name = "txtMozoDelDia";
            this.txtMozoDelDia.ReadOnly = true;
            this.txtMozoDelDia.Size = new System.Drawing.Size(95, 20);
            this.txtMozoDelDia.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(631, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 32);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(13, 285);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(103, 32);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "TOTALES";
            this.btnTotales.UseVisualStyleBackColor = true;
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.Location = new System.Drawing.Point(13, 247);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(103, 32);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "MOZO DEL DÍA";
            this.btnMozoDelDia.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(13, 209);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(103, 32);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna0,
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4});
            this.dgvGrilla.Location = new System.Drawing.Point(13, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(678, 147);
            this.dgvGrilla.TabIndex = 0;
            // 
            // Columna0
            // 
            this.Columna0.HeaderText = "MOZO";
            this.Columna0.MinimumWidth = 6;
            this.Columna0.Name = "Columna0";
            this.Columna0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Columna0.Width = 125;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "COMIDA";
            this.Columna1.MinimumWidth = 6;
            this.Columna1.Name = "Columna1";
            this.Columna1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Columna1.Width = 125;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "BEBIDA S/ALCOHOL";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            this.Columna2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Columna2.Width = 125;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "BEBIDA C/ALCOHOL";
            this.Columna3.MinimumWidth = 6;
            this.Columna3.Name = "Columna3";
            this.Columna3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Columna3.Width = 125;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "POSTRES";
            this.Columna4.MinimumWidth = 6;
            this.Columna4.Name = "Columna4";
            this.Columna4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Columna4.Width = 125;
            // 
            // frmBarLaMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPostre);
            this.Controls.Add(this.lblBebidaConAlcohol);
            this.Controls.Add(this.lblBebidaSinAlcohol);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPostre);
            this.Controls.Add(this.txtBebidasConAlcohol);
            this.Controls.Add(this.txtBebidasSinAlcohol);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.txtMozoDelDia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnMozoDelDia);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "frmBarLaMilanga";
            this.Text = "BAR La Milanga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostre;
        private System.Windows.Forms.Label lblBebidaConAlcohol;
        private System.Windows.Forms.Label lblBebidaSinAlcohol;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.TextBox txtBebidasConAlcohol;
        private System.Windows.Forms.TextBox txtBebidasSinAlcohol;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.TextBox txtMozoDelDia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnMozoDelDia;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
    }
}

