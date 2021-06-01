
namespace FlowControlProject
{
    partial class FrmMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalagoToolStripMenuItem
            // 
            this.catalagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activoFijoToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuitemSalir});
            this.catalagoToolStripMenuItem.Name = "catalagoToolStripMenuItem";
            this.catalagoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.catalagoToolStripMenuItem.Text = "Catalago";
            // 
            // activoFijoToolStripMenuItem
            // 
            this.activoFijoToolStripMenuItem.Name = "activoFijoToolStripMenuItem";
            this.activoFijoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activoFijoToolStripMenuItem.Text = "Activo Fijo";
            this.activoFijoToolStripMenuItem.Click += new System.EventHandler(this.activoFijoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemSalir
            // 
            this.menuitemSalir.Name = "menuitemSalir";
            this.menuitemSalir.Size = new System.Drawing.Size(180, 22);
            this.menuitemSalir.Text = "Salir";
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMdi";
            this.Text = "FrmMdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuitemSalir;
    }
}