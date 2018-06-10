namespace RegistroEjemplo.UI.Consultas
{
    partial class cVisitas
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
            this.label4 = new System.Windows.Forms.Label();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.filtrarcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Fechaspanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Filtrar usando Rango de fechas";
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechaspanel.Controls.Add(this.HastadateTimePicker);
            this.Fechaspanel.Controls.Add(this.label3);
            this.Fechaspanel.Controls.Add(this.DesdedateTimePicker);
            this.Fechaspanel.Controls.Add(this.label6);
            this.Fechaspanel.Location = new System.Drawing.Point(217, 66);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(521, 37);
            this.Fechaspanel.TabIndex = 27;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(329, 8);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.HastadateTimePicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(55, 8);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.DesdedateTimePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CriteriotextBox);
            this.groupBox1.Controls.Add(this.filtrarcomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 51);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriteriotextBox.Location = new System.Drawing.Point(299, 17);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(421, 22);
            this.CriteriotextBox.TabIndex = 3;
            // 
            // filtrarcomboBox
            // 
            this.filtrarcomboBox.FormattingEnabled = true;
            this.filtrarcomboBox.Items.AddRange(new object[] {
            "TODOS",
            "Id",
            "Nombre",
            "Cedula",
            "Direccion",
            "Telefono"});
            this.filtrarcomboBox.Location = new System.Drawing.Point(59, 16);
            this.filtrarcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filtrarcomboBox.Name = "filtrarcomboBox";
            this.filtrarcomboBox.Size = new System.Drawing.Size(160, 24);
            this.filtrarcomboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AllowUserToOrderColumns = true;
            this.ConsultadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 120);
            this.ConsultadataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.RowHeadersWidth = 10;
            this.ConsultadataGridView.Size = new System.Drawing.Size(876, 374);
            this.ConsultadataGridView.TabIndex = 22;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Imprimirbutton.Image = global::RegistroEjemplo.Properties.Resources.impresora;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 502);
            this.Imprimirbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(140, 51);
            this.Imprimirbutton.TabIndex = 25;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Image = global::RegistroEjemplo.Properties.Resources.buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(748, 14);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(140, 51);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // cVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "cVisitas";
            this.Text = "cVisitas";
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Fechaspanel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox filtrarcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}