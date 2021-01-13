
namespace WindowsBiblioteca
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListaAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGeneros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsimEditoriales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsimLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsmiPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActulizacionPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutores,
            this.tsmiPaises,
            this.tsmiGeneros,
            this.tsimEditoriales,
            this.tsimLibros,
            this.windowsMenu,
            this.tsmiSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiAutores
            // 
            this.tsmiAutores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaAutor,
            this.tsmiListaAutores});
            this.tsmiAutores.Name = "tsmiAutores";
            this.tsmiAutores.Size = new System.Drawing.Size(60, 20);
            this.tsmiAutores.Text = "&Autores";
            // 
            // tsmiAltaAutor
            // 
            this.tsmiAltaAutor.Name = "tsmiAltaAutor";
            this.tsmiAltaAutor.Size = new System.Drawing.Size(158, 22);
            this.tsmiAltaAutor.Text = "Nuevo";
            // 
            // tsmiListaAutores
            // 
            this.tsmiListaAutores.Name = "tsmiListaAutores";
            this.tsmiListaAutores.Size = new System.Drawing.Size(158, 22);
            this.tsmiListaAutores.Text = "Lista de Autores";
            // 
            // tsmiGeneros
            // 
            this.tsmiGeneros.Name = "tsmiGeneros";
            this.tsmiGeneros.Size = new System.Drawing.Size(62, 20);
            this.tsmiGeneros.Text = "&Generos";
            // 
            // tsimEditoriales
            // 
            this.tsimEditoriales.Name = "tsimEditoriales";
            this.tsimEditoriales.Size = new System.Drawing.Size(73, 20);
            this.tsimEditoriales.Text = "&Editoriales";
            // 
            // tsimLibros
            // 
            this.tsimLibros.Name = "tsimLibros";
            this.tsimLibros.Size = new System.Drawing.Size(51, 20);
            this.tsimLibros.Text = "&Libros";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(66, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmiSalir.Text = "&Salir";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // tsmiPaises
            // 
            this.tsmiPaises.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActulizacionPaises});
            this.tsmiPaises.Name = "tsmiPaises";
            this.tsmiPaises.Size = new System.Drawing.Size(51, 20);
            this.tsmiPaises.Text = "&Paises";
            // 
            // tsmiActulizacionPaises
            // 
            this.tsmiActulizacionPaises.Name = "tsmiActulizacionPaises";
            this.tsmiActulizacionPaises.Size = new System.Drawing.Size(145, 22);
            this.tsmiActulizacionPaises.Text = "Actualizacion";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutores;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaAutor;
        private System.Windows.Forms.ToolStripMenuItem tsmiGeneros;
        private System.Windows.Forms.ToolStripMenuItem tsimEditoriales;
        private System.Windows.Forms.ToolStripMenuItem tsimLibros;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiListaAutores;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaises;
        private System.Windows.Forms.ToolStripMenuItem tsmiActulizacionPaises;
    }
}



