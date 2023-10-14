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
            registroDeNotasToolStripMenuItem = new ToolStripMenuItem();
            iNFORMESToolStripMenuItem = new ToolStripMenuItem();
            registroDeAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            progresoAcademicoToolStripMenuItem = new ToolStripMenuItem();
            eVENTOSToolStripMenuItem = new ToolStripMenuItem();
            inscripcionAEventosToolStripMenuItem = new ToolStripMenuItem();
            programacionDeEventosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            picInicio = new PictureBox();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
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
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // gESTIONARUSUARIOSToolStripMenuItem
            // 
            gESTIONARUSUARIOSToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            gESTIONARUSUARIOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, bajaToolStripMenuItem, modificacionToolStripMenuItem, verUsuariosToolStripMenuItem });
            gESTIONARUSUARIOSToolStripMenuItem.Name = "gESTIONARUSUARIOSToolStripMenuItem";
            gESTIONARUSUARIOSToolStripMenuItem.Size = new Size(270, 29);
            gESTIONARUSUARIOSToolStripMenuItem.Text = "GESTIONAR USUARIOS";
            gESTIONARUSUARIOSToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(220, 30);
            altaToolStripMenuItem.Text = "Dar de alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(220, 30);
            bajaToolStripMenuItem.Text = "Dar de baja";
            // 
            // modificacionToolStripMenuItem
            // 
            modificacionToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            modificacionToolStripMenuItem.Size = new Size(220, 30);
            modificacionToolStripMenuItem.Text = "Modificar";
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
            nOTASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeNotasToolStripMenuItem });
            nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            nOTASToolStripMenuItem.Size = new Size(102, 29);
            nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // registroDeNotasToolStripMenuItem
            // 
            registroDeNotasToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 0);
            registroDeNotasToolStripMenuItem.Name = "registroDeNotasToolStripMenuItem";
            registroDeNotasToolStripMenuItem.Size = new Size(266, 30);
            registroDeNotasToolStripMenuItem.Text = "Registro de notas";
            // 
            // iNFORMESToolStripMenuItem
            // 
            iNFORMESToolStripMenuItem.BackColor = SystemColors.HotTrack;
            iNFORMESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeAsistenciaToolStripMenuItem, progresoAcademicoToolStripMenuItem });
            iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            iNFORMESToolStripMenuItem.Size = new Size(138, 29);
            iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // registroDeAsistenciaToolStripMenuItem
            // 
            registroDeAsistenciaToolStripMenuItem.Name = "registroDeAsistenciaToolStripMenuItem";
            registroDeAsistenciaToolStripMenuItem.Size = new Size(310, 30);
            registroDeAsistenciaToolStripMenuItem.Text = "Registro de asistencia";
            // 
            // progresoAcademicoToolStripMenuItem
            // 
            progresoAcademicoToolStripMenuItem.Name = "progresoAcademicoToolStripMenuItem";
            progresoAcademicoToolStripMenuItem.Size = new Size(310, 30);
            progresoAcademicoToolStripMenuItem.Text = "Progreso academico";
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            eVENTOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscripcionAEventosToolStripMenuItem, programacionDeEventosToolStripMenuItem });
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(130, 29);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            // 
            // inscripcionAEventosToolStripMenuItem
            // 
            inscripcionAEventosToolStripMenuItem.Name = "inscripcionAEventosToolStripMenuItem";
            inscripcionAEventosToolStripMenuItem.Size = new Size(343, 30);
            inscripcionAEventosToolStripMenuItem.Text = "Inscripcion a eventos";
            // 
            // programacionDeEventosToolStripMenuItem
            // 
            programacionDeEventosToolStripMenuItem.Name = "programacionDeEventosToolStripMenuItem";
            programacionDeEventosToolStripMenuItem.Size = new Size(343, 30);
            programacionDeEventosToolStripMenuItem.Text = "Programacion de eventos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Location = new Point(818, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(87, 478);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // picInicio
            // 
            picInicio.Image = (Image)resources.GetObject("picInicio.Image");
            picInicio.Location = new Point(0, 0);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(823, 479);
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.TabIndex = 4;
            picInicio.TabStop = false;
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(220, 30);
            verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 515);
            ControlBox = false;
            Controls.Add(picInicio);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem iNFORMESToolStripMenuItem;
        private ToolStripMenuItem eVENTOSToolStripMenuItem;
        private ToolStripMenuItem nOTASToolStripMenuItem;
        private ToolStripMenuItem gESTIONARUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem modificacionToolStripMenuItem;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem mENSAJERIAToolStripMenuItem;
        private ToolStripMenuItem enviarMensajesToolStripMenuItem;
        private ToolStripMenuItem mensajesEnviadosToolStripMenuItem;
        private ToolStripMenuItem mensajesRecibidosToolStripMenuItem;
        private ToolStripMenuItem registroDeNotasToolStripMenuItem;
        private ToolStripMenuItem registroDeAsistenciaToolStripMenuItem;
        private ToolStripMenuItem progresoAcademicoToolStripMenuItem;
        private ToolStripMenuItem inscripcionAEventosToolStripMenuItem;
        private ToolStripMenuItem programacionDeEventosToolStripMenuItem;
        private PictureBox picInicio;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
    }
}