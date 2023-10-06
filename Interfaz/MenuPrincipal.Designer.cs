namespace Interfaz
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            iNFORMESToolStripMenuItem = new ToolStripMenuItem();
            mENSAJERIAToolStripMenuItem = new ToolStripMenuItem();
            eVENTOSToolStripMenuItem = new ToolStripMenuItem();
            nOTASToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, iNFORMESToolStripMenuItem, mENSAJERIAToolStripMenuItem, eVENTOSToolStripMenuItem, nOTASToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(170, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(157, 29);
            iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // iNFORMESToolStripMenuItem
            // 
            iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            iNFORMESToolStripMenuItem.Size = new Size(157, 29);
            iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // mENSAJERIAToolStripMenuItem
            // 
            mENSAJERIAToolStripMenuItem.Name = "mENSAJERIAToolStripMenuItem";
            mENSAJERIAToolStripMenuItem.Size = new Size(157, 29);
            mENSAJERIAToolStripMenuItem.Text = "MENSAJERIA";
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(157, 29);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            // 
            // nOTASToolStripMenuItem
            // 
            nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            nOTASToolStripMenuItem.Size = new Size(157, 29);
            nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem iNFORMESToolStripMenuItem;
        private ToolStripMenuItem mENSAJERIAToolStripMenuItem;
        private ToolStripMenuItem eVENTOSToolStripMenuItem;
        private ToolStripMenuItem nOTASToolStripMenuItem;
    }
}