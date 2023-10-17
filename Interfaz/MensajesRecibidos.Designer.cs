using System.Windows.Forms;
using System.Drawing;
namespace Interfaz
{
    partial class frmMensajesRecibidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajesRecibidos));
            lstMensajesRecibidos = new ListBox();
            SuspendLayout();
            // 
            // lstMensajesRecibidos
            // 
            lstMensajesRecibidos.FormattingEnabled = true;
            lstMensajesRecibidos.ItemHeight = 20;
            lstMensajesRecibidos.Location = new Point(184, 50);
            lstMensajesRecibidos.Name = "lstMensajesRecibidos";
            lstMensajesRecibidos.Size = new Size(353, 304);
            lstMensajesRecibidos.TabIndex = 0;
            // 
            // frmMensajesRecibidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lstMensajesRecibidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMensajesRecibidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MensajesRecibidos";
            Load += frmMensajesRecibidos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMensajesRecibidos;
    }
}