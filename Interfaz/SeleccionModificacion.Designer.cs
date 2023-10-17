using System.Windows.Forms;
using System.Drawing;
namespace Interfaz
{
    partial class frmSeleccionModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionModificacion));
            lstSeleccionModificacion = new ListBox();
            btnAceptarSeleccionModificacion = new Button();
            btnCancelarSeleccionModificacion = new Button();
            SuspendLayout();
            // 
            // lstSeleccionModificacion
            // 
            lstSeleccionModificacion.BackColor = SystemColors.ActiveCaption;
            lstSeleccionModificacion.FormattingEnabled = true;
            lstSeleccionModificacion.ItemHeight = 20;
            lstSeleccionModificacion.Location = new Point(235, 25);
            lstSeleccionModificacion.Name = "lstSeleccionModificacion";
            lstSeleccionModificacion.Size = new Size(327, 304);
            lstSeleccionModificacion.TabIndex = 1;
            // 
            // btnAceptarSeleccionModificacion
            // 
            btnAceptarSeleccionModificacion.BackColor = SystemColors.ActiveCaption;
            btnAceptarSeleccionModificacion.FlatStyle = FlatStyle.Popup;
            btnAceptarSeleccionModificacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptarSeleccionModificacion.Location = new Point(235, 349);
            btnAceptarSeleccionModificacion.Name = "btnAceptarSeleccionModificacion";
            btnAceptarSeleccionModificacion.Size = new Size(161, 74);
            btnAceptarSeleccionModificacion.TabIndex = 2;
            btnAceptarSeleccionModificacion.Text = "ACEPTAR";
            btnAceptarSeleccionModificacion.UseVisualStyleBackColor = false;
            btnAceptarSeleccionModificacion.Click += btnAceptarSeleccionModificacion_Click;
            // 
            // btnCancelarSeleccionModificacion
            // 
            btnCancelarSeleccionModificacion.BackColor = SystemColors.ActiveCaption;
            btnCancelarSeleccionModificacion.FlatStyle = FlatStyle.Popup;
            btnCancelarSeleccionModificacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarSeleccionModificacion.Location = new Point(402, 349);
            btnCancelarSeleccionModificacion.Name = "btnCancelarSeleccionModificacion";
            btnCancelarSeleccionModificacion.Size = new Size(158, 74);
            btnCancelarSeleccionModificacion.TabIndex = 15;
            btnCancelarSeleccionModificacion.Text = "CANCELAR";
            btnCancelarSeleccionModificacion.UseVisualStyleBackColor = false;
            btnCancelarSeleccionModificacion.Click += btnCancelarSeleccionModificacion_Click;
            // 
            // frmSeleccionModificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCancelarSeleccionModificacion);
            Controls.Add(btnAceptarSeleccionModificacion);
            Controls.Add(lstSeleccionModificacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSeleccionModificacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SeleccionModificacion";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSeleccionModificacion;
        private Button btnAceptarSeleccionModificacion;
        private Button btnCancelarSeleccionModificacion;
    }
}