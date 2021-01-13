
namespace WindowsBiblioteca
{
    partial class frmAltaAutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tlbAutor = new System.Windows.Forms.TableLayoutPanel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.tlbAutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE NUEVO AUTOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlbAutor
            // 
            this.tlbAutor.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlbAutor.ColumnCount = 2;
            this.tlbAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbAutor.Controls.Add(this.lblApellido, 0, 0);
            this.tlbAutor.Controls.Add(this.lblNombre, 0, 1);
            this.tlbAutor.Controls.Add(this.lblFechaNacimiento, 0, 2);
            this.tlbAutor.Controls.Add(this.lblNacionalidad, 0, 3);
            this.tlbAutor.Controls.Add(this.btnConfirmar, 0, 4);
            this.tlbAutor.Controls.Add(this.txtApellido, 1, 0);
            this.tlbAutor.Controls.Add(this.btnCerrar, 1, 4);
            this.tlbAutor.Controls.Add(this.txtNombre, 1, 1);
            this.tlbAutor.Controls.Add(this.dtpFechaNac, 1, 2);
            this.tlbAutor.Controls.Add(this.cboNacionalidad, 1, 3);
            this.tlbAutor.Location = new System.Drawing.Point(3, 59);
            this.tlbAutor.Name = "tlbAutor";
            this.tlbAutor.RowCount = 5;
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbAutor.Size = new System.Drawing.Size(696, 387);
            this.tlbAutor.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(268, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 21);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(270, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(195, 181);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(148, 21);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(230, 257);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(113, 21);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(6, 310);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(337, 71);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(352, 25);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(338, 29);
            this.txtApellido.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(352, 310);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(337, 69);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(352, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(352, 177);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(116, 29);
            this.dtpFechaNac.TabIndex = 6;
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay",
            "Venezuela",
            "Colombia",
            "Mexico"});
            this.cboNacionalidad.Location = new System.Drawing.Point(352, 234);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(338, 29);
            this.cboNacionalidad.TabIndex = 7;
            // 
            // frmAltaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlbAutor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmAltaAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO AUTOR";
            this.tlbAutor.ResumeLayout(false);
            this.tlbAutor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlbAutor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cboNacionalidad;
    }
}