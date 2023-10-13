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
            gESTIONARUSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            modificacionToolStripMenuItem = new ToolStripMenuItem();
            mENSAJERIAToolStripMenuItem = new ToolStripMenuItem();
            enviarMensajesToolStripMenuItem = new ToolStripMenuItem();
            mensajesEnviadosToolStripMenuItem = new ToolStripMenuItem();
            mensajesRecibidosToolStripMenuItem = new ToolStripMenuItem();
            nOTASToolStripMenuItem = new ToolStripMenuItem();
            iNFORMESToolStripMenuItem = new ToolStripMenuItem();
            eVENTOSToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, gESTIONARUSUARIOSToolStripMenuItem, mENSAJERIAToolStripMenuItem, nOTASToolStripMenuItem, iNFORMESToolStripMenuItem, eVENTOSToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 482);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.BackColor = Color.Teal;
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(92, 29);
            iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // gESTIONARUSUARIOSToolStripMenuItem
            // 
            gESTIONARUSUARIOSToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            gESTIONARUSUARIOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, bajaToolStripMenuItem, modificacionToolStripMenuItem });
            gESTIONARUSUARIOSToolStripMenuItem.Name = "gESTIONARUSUARIOSToolStripMenuItem";
            gESTIONARUSUARIOSToolStripMenuItem.Size = new Size(270, 29);
            gESTIONARUSUARIOSToolStripMenuItem.Text = "GESTIONAR USUARIOS";
            gESTIONARUSUARIOSToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(219, 30);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(219, 30);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificacionToolStripMenuItem
            // 
            modificacionToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            modificacionToolStripMenuItem.Size = new Size(219, 30);
            modificacionToolStripMenuItem.Text = "Modificacion";
            // 
            // mENSAJERIAToolStripMenuItem
            // 
            mENSAJERIAToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            mENSAJERIAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enviarMensajesToolStripMenuItem, mensajesEnviadosToolStripMenuItem, mensajesRecibidosToolStripMenuItem });
            mENSAJERIAToolStripMenuItem.ForeColor = SystemColors.Desktop;
            mENSAJERIAToolStripMenuItem.Name = "mENSAJERIAToolStripMenuItem";
            mENSAJERIAToolStripMenuItem.Size = new Size(164, 29);
            mENSAJERIAToolStripMenuItem.Text = "MENSAJERIA";
            // 
            // enviarMensajesToolStripMenuItem
            // 
            enviarMensajesToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            enviarMensajesToolStripMenuItem.Name = "enviarMensajesToolStripMenuItem";
            enviarMensajesToolStripMenuItem.Size = new Size(284, 30);
            enviarMensajesToolStripMenuItem.Text = "Enviar mensajes";
            // 
            // mensajesEnviadosToolStripMenuItem
            // 
            mensajesEnviadosToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            mensajesEnviadosToolStripMenuItem.Name = "mensajesEnviadosToolStripMenuItem";
            mensajesEnviadosToolStripMenuItem.Size = new Size(284, 30);
            mensajesEnviadosToolStripMenuItem.Text = "Mensajes enviados";
            // 
            // mensajesRecibidosToolStripMenuItem
            // 
            mensajesRecibidosToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            mensajesRecibidosToolStripMenuItem.Name = "mensajesRecibidosToolStripMenuItem";
            mensajesRecibidosToolStripMenuItem.Size = new Size(284, 30);
            mensajesRecibidosToolStripMenuItem.Text = "Mensajes recibidos";
            // 
            // nOTASToolStripMenuItem
            // 
            nOTASToolStripMenuItem.BackColor = Color.Lime;
            nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            nOTASToolStripMenuItem.Size = new Size(102, 29);
            nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // iNFORMESToolStripMenuItem
            // 
            iNFORMESToolStripMenuItem.BackColor = SystemColors.HotTrack;
            iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            iNFORMESToolStripMenuItem.Size = new Size(138, 29);
            iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(130, 29);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Location = new Point(0, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(905, 88);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 515);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            TransparencyKey = Color.Transparent;
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
        private ToolStripMenuItem gESTIONARUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem modificacionToolStripMenuItem;
        private ToolStripMenuItem enviarMensajesToolStripMenuItem;
        private ToolStripMenuItem mensajesEnviadosToolStripMenuItem;
        private ToolStripMenuItem mensajesRecibidosToolStripMenuItem;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}