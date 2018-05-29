namespace RegistroEjemplo.UI.Registros
{
    partial class rCiudades
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
            System.Windows.Forms.Label ciudadIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ciudadIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ciudadIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroEjemplo.Properties.Resources.buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(353, 77);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(82, 28);
            this.Buscarbutton.TabIndex = 18;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminarbutton.Image = global::RegistroEjemplo.Properties.Resources.borrar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(494, 311);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(152, 58);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guardarbutton.Image = global::RegistroEjemplo.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(324, 311);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(152, 58);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NuevoButton.Image = global::RegistroEjemplo.Properties.Resources.nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(154, 311);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(152, 58);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ciudadIdLabel
            // 
            ciudadIdLabel.AutoSize = true;
            ciudadIdLabel.Location = new System.Drawing.Point(136, 77);
            ciudadIdLabel.Name = "ciudadIdLabel";
            ciudadIdLabel.Size = new System.Drawing.Size(71, 17);
            ciudadIdLabel.TabIndex = 19;
            ciudadIdLabel.Text = "Ciudad Id:";
            // 
            // ciudadIdNumericUpDown
            // 
            this.ciudadIdNumericUpDown.Location = new System.Drawing.Point(213, 77);
            this.ciudadIdNumericUpDown.Name = "ciudadIdNumericUpDown";
            this.ciudadIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ciudadIdNumericUpDown.TabIndex = 20;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(133, 130);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(201, 127);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(445, 22);
            this.nombreTextBox.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(ciudadIdLabel);
            this.Controls.Add(this.ciudadIdNumericUpDown);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "rCiudades";
            this.Text = "rCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.ciudadIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.NumericUpDown ciudadIdNumericUpDown;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}