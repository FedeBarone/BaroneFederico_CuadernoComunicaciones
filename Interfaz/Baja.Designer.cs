namespace Interfaz
{
    partial class frmBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaja));
            lstBaja = new ListBox();
            btnAceptarBaja = new Button();
            btnCancelarBaja = new Button();
            SuspendLayout();
            // 
            // lstBaja
            // 
            lstBaja.BackColor = SystemColors.ActiveCaption;
            lstBaja.FormattingEnabled = true;
            lstBaja.ItemHeight = 20;
            lstBaja.Location = new Point(231, 26);
            lstBaja.Name = "lstBaja";
            lstBaja.Size = new Size(327, 304);
            lstBaja.TabIndex = 0;
            // 
            // btnAceptarBaja
            // 
            btnAceptarBaja.BackColor = SystemColors.ActiveCaption;
            btnAceptarBaja.FlatStyle = FlatStyle.Popup;
            btnAceptarBaja.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptarBaja.Location = new Point(219, 347);
            btnAceptarBaja.Name = "btnAceptarBaja";
            btnAceptarBaja.Size = new Size(161, 74);
            btnAceptarBaja.TabIndex = 1;
            btnAceptarBaja.Text = "ACEPTAR";
            btnAceptarBaja.UseVisualStyleBackColor = false;
            btnAceptarBaja.Click += btnGuardar_Click;
            // 
            // btnCancelarBaja
            // 
            btnCancelarBaja.BackColor = SystemColors.ActiveCaption;
            btnCancelarBaja.FlatStyle = FlatStyle.Popup;
            btnCancelarBaja.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarBaja.Location = new Point(417, 347);
            btnCancelarBaja.Name = "btnCancelarBaja";
            btnCancelarBaja.Size = new Size(158, 74);
            btnCancelarBaja.TabIndex = 14;
            btnCancelarBaja.Text = "CANCELAR";
            btnCancelarBaja.UseVisualStyleBackColor = false;
            btnCancelarBaja.Click += btnCancelar_Click;
            // 
            // frmBaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCancelarBaja);
            Controls.Add(btnAceptarBaja);
            Controls.Add(lstBaja);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBaja";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Baja";
            Load += frmBaja_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBaja;
        private Button btnAceptarBaja;
        private Button btnCancelarBaja;
    }
}