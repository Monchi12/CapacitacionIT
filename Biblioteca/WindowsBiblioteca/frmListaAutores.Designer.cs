
namespace WindowsBiblioteca
{
    partial class frmListaAutores
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
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.lblpaises = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(12, 91);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowTemplate.Height = 25;
            this.dgvAutores.Size = new System.Drawing.Size(651, 347);
            this.dgvAutores.TabIndex = 0;
            // 
            // cboPaises
            // 
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(80, 21);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(158, 23);
            this.cboPaises.TabIndex = 1;
            // 
            // lblpaises
            // 
            this.lblpaises.AutoSize = true;
            this.lblpaises.Location = new System.Drawing.Point(35, 29);
            this.lblpaises.Name = "lblpaises";
            this.lblpaises.Size = new System.Drawing.Size(39, 15);
            this.lblpaises.TabIndex = 2;
            this.lblpaises.Text = "Paises";
            // 
            // frmListaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lblpaises);
            this.Controls.Add(this.cboPaises);
            this.Controls.Add(this.dgvAutores);
            this.Name = "frmListaAutores";
            this.Text = "frmListaAutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.ComboBox cboPaises;
        private System.Windows.Forms.Label lblpaises;
    }
}