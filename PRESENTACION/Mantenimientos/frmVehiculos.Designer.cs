namespace PRESENTACION.Mantenimientos
{
    partial class frmVehiculos
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
            this.gridVehiculos = new System.Windows.Forms.DataGridView();
            this.grupoControles = new System.Windows.Forms.GroupBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboUso = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.txtNAsientos = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).BeginInit();
            this.grupoControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridVehiculos
            // 
            this.gridVehiculos.AllowUserToAddRows = false;
            this.gridVehiculos.AllowUserToDeleteRows = false;
            this.gridVehiculos.AllowUserToResizeRows = false;
            this.gridVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.gridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehiculos.Location = new System.Drawing.Point(22, 235);
            this.gridVehiculos.MultiSelect = false;
            this.gridVehiculos.Name = "gridVehiculos";
            this.gridVehiculos.ReadOnly = true;
            this.gridVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVehiculos.Size = new System.Drawing.Size(907, 284);
            this.gridVehiculos.TabIndex = 2;
            // 
            // grupoControles
            // 
            this.grupoControles.Controls.Add(this.cboMarca);
            this.grupoControles.Controls.Add(this.cboCategoria);
            this.grupoControles.Controls.Add(this.cboUso);
            this.grupoControles.Controls.Add(this.txtModelo);
            this.grupoControles.Controls.Add(this.txtColor);
            this.grupoControles.Controls.Add(this.txtNSerie);
            this.grupoControles.Controls.Add(this.txtNAsientos);
            this.grupoControles.Controls.Add(this.txtAnio);
            this.grupoControles.Controls.Add(this.txtPlaca);
            this.grupoControles.Controls.Add(this.label8);
            this.grupoControles.Controls.Add(this.label4);
            this.grupoControles.Controls.Add(this.label7);
            this.grupoControles.Controls.Add(this.label6);
            this.grupoControles.Controls.Add(this.lblColor);
            this.grupoControles.Controls.Add(this.label3);
            this.grupoControles.Controls.Add(this.label5);
            this.grupoControles.Controls.Add(this.label2);
            this.grupoControles.Controls.Add(this.label1);
            this.grupoControles.Location = new System.Drawing.Point(22, 36);
            this.grupoControles.Name = "grupoControles";
            this.grupoControles.Size = new System.Drawing.Size(763, 178);
            this.grupoControles.TabIndex = 0;
            this.grupoControles.TabStop = false;
            this.grupoControles.Text = "Complete el formulario";
            // 
            // cboMarca
            // 
            this.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(212, 121);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(180, 24);
            this.cboMarca.TabIndex = 11;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(26, 121);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(180, 24);
            this.cboCategoria.TabIndex = 9;
            // 
            // cboUso
            // 
            this.cboUso.FormattingEnabled = true;
            this.cboUso.Items.AddRange(new object[] {
            "Particular",
            "Laboral",
            "Industrial",
            "Taxi"});
            this.cboUso.Location = new System.Drawing.Point(408, 51);
            this.cboUso.Name = "cboUso";
            this.cboUso.Size = new System.Drawing.Size(333, 24);
            this.cboUso.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(408, 121);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 23);
            this.txtModelo.TabIndex = 13;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(641, 122);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 23);
            this.txtColor.TabIndex = 17;
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new System.Drawing.Point(525, 122);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(100, 23);
            this.txtNSerie.TabIndex = 15;
            // 
            // txtNAsientos
            // 
            this.txtNAsientos.Location = new System.Drawing.Point(277, 51);
            this.txtNAsientos.Name = "txtNAsientos";
            this.txtNAsientos.Size = new System.Drawing.Size(100, 23);
            this.txtNAsientos.TabIndex = 5;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(153, 52);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 23);
            this.txtAnio.TabIndex = 3;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(26, 52);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Uso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(638, 102);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(43, 16);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "N° Serie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° Asientos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(792, 45);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(792, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 548);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grupoControles);
            this.Controls.Add(this.gridVehiculos);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Vehículos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).EndInit();
            this.grupoControles.ResumeLayout(false);
            this.grupoControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVehiculos;
        private System.Windows.Forms.GroupBox grupoControles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUso;
        private System.Windows.Forms.TextBox txtNAsientos;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}