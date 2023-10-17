using System.Windows.Forms;
using System.Drawing;
namespace Interfaz
{
    partial class frmEnvioMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioMensaje));
            cboDestinatarios = new ComboBox();
            txtTextoMensaje = new TextBox();
            btnEnviar = new Button();
            btnCancelarMensaje = new Button();
            SuspendLayout();
            // 
            // cboDestinatarios
            // 
            cboDestinatarios.FormattingEnabled = true;
            cboDestinatarios.Items.AddRange(new object[] { "a" });
            cboDestinatarios.Location = new Point(125, 12);
            cboDestinatarios.Name = "cboDestinatarios";
            cboDestinatarios.Size = new Size(192, 28);
            cboDestinatarios.TabIndex = 0;
            cboDestinatarios.Text = "Destinatarios";
            // 
            // txtTextoMensaje
            // 
            txtTextoMensaje.Location = new Point(125, 68);
            txtTextoMensaje.Multiline = true;
            txtTextoMensaje.Name = "txtTextoMensaje";
            txtTextoMensaje.Size = new Size(497, 238);
            txtTextoMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.ActiveCaption;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.Location = new Point(166, 334);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(161, 74);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelarMensaje
            // 
            btnCancelarMensaje.BackColor = SystemColors.ActiveCaption;
            btnCancelarMensaje.FlatStyle = FlatStyle.Popup;
            btnCancelarMensaje.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarMensaje.Location = new Point(391, 334);
            btnCancelarMensaje.Name = "btnCancelarMensaje";
            btnCancelarMensaje.Size = new Size(161, 74);
            btnCancelarMensaje.TabIndex = 3;
            btnCancelarMensaje.Text = "CANCELAR";
            btnCancelarMensaje.UseVisualStyleBackColor = false;
            // 
            // frmEnvioMensaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCancelarMensaje);
            Controls.Add(btnEnviar);
            Controls.Add(txtTextoMensaje);
            Controls.Add(cboDestinatarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEnvioMensaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EnvioMensaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboDestinatarios;
        private TextBox txtTextoMensaje;
        private Button btnEnviar;
        private Button btnCancelarMensaje;
    }
}