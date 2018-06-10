namespace RegistroEjemplo.UI.Registros
{
    partial class rVisitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label visitaIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            visitaIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // visitaIdLabel
            // 
            visitaIdLabel.AutoSize = true;
            visitaIdLabel.Location = new System.Drawing.Point(24, 27);
            visitaIdLabel.Name = "visitaIdLabel";
            visitaIdLabel.Size = new System.Drawing.Size(61, 17);
            visitaIdLabel.TabIndex = 19;
            visitaIdLabel.Text = "Visita Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 63);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 20;
            fechaLabel.Text = "Fecha:";
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(24, 341);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(91, 17);
            comentariosLabel.TabIndex = 21;
            comentariosLabel.Text = "Comentarios:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 24;
            label1.Text = "Ciudad:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(343, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 17);
            label2.TabIndex = 26;
            label2.Text = "Cantidad:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(88, 59);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(189, 22);
            this.fechaDateTimePicker.TabIndex = 21;
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comentariosTextBox.Location = new System.Drawing.Point(27, 361);
            this.comentariosTextBox.MaxLength = 100;
            this.comentariosTextBox.Multiline = true;
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(547, 39);
            this.comentariosTextBox.TabIndex = 22;
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.AllowUserToAddRows = false;
            this.detalleDataGridView.AllowUserToDeleteRows = false;
            this.detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(21, 53);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.ReadOnly = true;
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalleDataGridView.Size = new System.Drawing.Size(511, 137);
            this.detalleDataGridView.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.CantidadnumericUpDown);
            this.groupBox1.Controls.Add(this.CiudadcomboBox);
            this.groupBox1.Controls.Add(this.detalleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(27, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 235);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciudades Visitadas";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.Color.Blue;
            this.Agregarbutton.Location = new System.Drawing.Point(490, 21);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(42, 23);
            this.Agregarbutton.TabIndex = 25;
            this.Agregarbutton.Text = "+";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(417, 21);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.CantidadnumericUpDown.TabIndex = 24;
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Location = new System.Drawing.Point(79, 20);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(258, 24);
            this.CiudadcomboBox.TabIndex = 23;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(88, 24);
            this.IdnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(96, 22);
            this.IdnumericUpDown.TabIndex = 27;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::RegistroEjemplo.Properties.Resources.delete__1_;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(19, 197);
            this.Removerbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(152, 28);
            this.Removerbutton.TabIndex = 28;
            this.Removerbutton.Text = "- Remover Fila";
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroEjemplo.Properties.Resources.buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(195, 21);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(82, 28);
            this.Buscarbutton.TabIndex = 18;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Image = global::RegistroEjemplo.Properties.Resources.borrar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(386, 445);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(152, 58);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Image = global::RegistroEjemplo.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(216, 445);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(152, 58);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Image = global::RegistroEjemplo.Properties.Resources.nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(46, 445);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(152, 58);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // rVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 516);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(visitaIdLabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "rVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Visitas Ciudades Famosas";
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox comentariosTextBox;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Removerbutton;
    }
}