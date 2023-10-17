using System.Windows.Forms;
using System.Drawing;
namespace Interfaz
{
    partial class frmModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacion));
            btnGuardarMod = new Button();
            btnCancelarMod = new Button();
            radPadreMod = new RadioButton();
            radMadreMod = new RadioButton();
            radTutorMod = new RadioButton();
            lblPadresOTutorMod = new Label();
            txtNombreMod = new TextBox();
            txtDirCorreoMod = new TextBox();
            txtNumeroCelularMod = new TextBox();
            txtUsuarioClaveMod = new TextBox();
            lblDatosAlumnoMod = new Label();
            txtNombreAlumnoMod = new TextBox();
            txtGradoAlumnoMod = new TextBox();
            txtLegajoAlumnoMod = new TextBox();
            lblMod = new Label();
            lblRepresentante = new Label();
            SuspendLayout();
            // 
            // btnGuardarMod
            // 
            btnGuardarMod.BackColor = SystemColors.ActiveCaption;
            btnGuardarMod.FlatStyle = FlatStyle.Popup;
            btnGuardarMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarMod.Location = new Point(410, 336);
            btnGuardarMod.Name = "btnGuardarMod";
            btnGuardarMod.Size = new Size(161, 74);
            btnGuardarMod.TabIndex = 1;
            btnGuardarMod.Text = "GUARDAR";
            btnGuardarMod.UseVisualStyleBackColor = false;
            btnGuardarMod.Click += btnGuardarMod_Click;
            // 
            // btnCancelarMod
            // 
            btnCancelarMod.BackColor = SystemColors.ActiveCaption;
            btnCancelarMod.FlatStyle = FlatStyle.Popup;
            btnCancelarMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarMod.Location = new Point(603, 336);
            btnCancelarMod.Name = "btnCancelarMod";
            btnCancelarMod.Size = new Size(158, 74);
            btnCancelarMod.TabIndex = 14;
            btnCancelarMod.Text = "CANCELAR";
            btnCancelarMod.UseVisualStyleBackColor = false;
            btnCancelarMod.Click += btnCancelarMod_Click;
            // 
            // radPadreMod
            // 
            radPadreMod.AutoSize = true;
            radPadreMod.BackColor = SystemColors.ActiveCaption;
            radPadreMod.Location = new Point(91, 184);
            radPadreMod.Name = "radPadreMod";
            radPadreMod.Size = new Size(67, 24);
            radPadreMod.TabIndex = 15;
            radPadreMod.TabStop = true;
            radPadreMod.Text = "Padre";
            radPadreMod.UseVisualStyleBackColor = false;
            // 
            // radMadreMod
            // 
            radMadreMod.AutoSize = true;
            radMadreMod.BackColor = SystemColors.ActiveCaption;
            radMadreMod.Location = new Point(12, 184);
            radMadreMod.Name = "radMadreMod";
            radMadreMod.Size = new Size(73, 24);
            radMadreMod.TabIndex = 16;
            radMadreMod.TabStop = true;
            radMadreMod.Text = "Madre";
            radMadreMod.UseVisualStyleBackColor = false;
            // 
            // radTutorMod
            // 
            radTutorMod.AutoSize = true;
            radTutorMod.BackColor = SystemColors.ActiveCaption;
            radTutorMod.Location = new Point(164, 184);
            radTutorMod.Name = "radTutorMod";
            radTutorMod.Size = new Size(65, 24);
            radTutorMod.TabIndex = 17;
            radTutorMod.TabStop = true;
            radTutorMod.Text = "Tutor";
            radTutorMod.UseVisualStyleBackColor = false;
            // 
            // lblPadresOTutorMod
            // 
            lblPadresOTutorMod.AutoSize = true;
            lblPadresOTutorMod.BackColor = SystemColors.ActiveCaption;
            lblPadresOTutorMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPadresOTutorMod.ForeColor = SystemColors.ActiveCaptionText;
            lblPadresOTutorMod.Location = new Point(12, 19);
            lblPadresOTutorMod.Name = "lblPadresOTutorMod";
            lblPadresOTutorMod.Size = new Size(324, 29);
            lblPadresOTutorMod.TabIndex = 18;
            lblPadresOTutorMod.Text = "Datos padre, madre o tutor";
            // 
            // txtNombreMod
            // 
            txtNombreMod.BackColor = Color.Silver;
            txtNombreMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreMod.Location = new Point(11, 63);
            txtNombreMod.Name = "txtNombreMod";
            txtNombreMod.PlaceholderText = "Ingrese nombre completo";
            txtNombreMod.Size = new Size(325, 34);
            txtNombreMod.TabIndex = 19;
            // 
            // txtDirCorreoMod
            // 
            txtDirCorreoMod.BackColor = Color.Silver;
            txtDirCorreoMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirCorreoMod.Location = new Point(11, 103);
            txtDirCorreoMod.Name = "txtDirCorreoMod";
            txtDirCorreoMod.PlaceholderText = "Ingrese direccion de correo";
            txtDirCorreoMod.Size = new Size(325, 34);
            txtDirCorreoMod.TabIndex = 20;
            // 
            // txtNumeroCelularMod
            // 
            txtNumeroCelularMod.BackColor = Color.Silver;
            txtNumeroCelularMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroCelularMod.Location = new Point(12, 143);
            txtNumeroCelularMod.Name = "txtNumeroCelularMod";
            txtNumeroCelularMod.PlaceholderText = "Ingrese numero celular";
            txtNumeroCelularMod.Size = new Size(325, 34);
            txtNumeroCelularMod.TabIndex = 21;
            // 
            // txtUsuarioClaveMod
            // 
            txtUsuarioClaveMod.BackColor = Color.Silver;
            txtUsuarioClaveMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioClaveMod.Location = new Point(12, 214);
            txtUsuarioClaveMod.Name = "txtUsuarioClaveMod";
            txtUsuarioClaveMod.PlaceholderText = "Ingrese clave de usuario";
            txtUsuarioClaveMod.Size = new Size(325, 34);
            txtUsuarioClaveMod.TabIndex = 22;
            // 
            // lblDatosAlumnoMod
            // 
            lblDatosAlumnoMod.AutoSize = true;
            lblDatosAlumnoMod.BackColor = SystemColors.ActiveCaption;
            lblDatosAlumnoMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosAlumnoMod.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosAlumnoMod.Location = new Point(11, 274);
            lblDatosAlumnoMod.Name = "lblDatosAlumnoMod";
            lblDatosAlumnoMod.Size = new Size(172, 29);
            lblDatosAlumnoMod.TabIndex = 23;
            lblDatosAlumnoMod.Text = "Datos alumno";
            // 
            // txtNombreAlumnoMod
            // 
            txtNombreAlumnoMod.BackColor = Color.Silver;
            txtNombreAlumnoMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreAlumnoMod.Location = new Point(11, 316);
            txtNombreAlumnoMod.Name = "txtNombreAlumnoMod";
            txtNombreAlumnoMod.PlaceholderText = "Ingrese nombre del alumno";
            txtNombreAlumnoMod.Size = new Size(325, 34);
            txtNombreAlumnoMod.TabIndex = 24;
            // 
            // txtGradoAlumnoMod
            // 
            txtGradoAlumnoMod.BackColor = Color.Silver;
            txtGradoAlumnoMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGradoAlumnoMod.Location = new Point(11, 356);
            txtGradoAlumnoMod.Name = "txtGradoAlumnoMod";
            txtGradoAlumnoMod.PlaceholderText = "Ingrese grado del alumno";
            txtGradoAlumnoMod.Size = new Size(325, 34);
            txtGradoAlumnoMod.TabIndex = 25;
            // 
            // txtLegajoAlumnoMod
            // 
            txtLegajoAlumnoMod.BackColor = Color.Silver;
            txtLegajoAlumnoMod.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLegajoAlumnoMod.Location = new Point(11, 396);
            txtLegajoAlumnoMod.Name = "txtLegajoAlumnoMod";
            txtLegajoAlumnoMod.PlaceholderText = "Ingrese legajo del alumno";
            txtLegajoAlumnoMod.Size = new Size(325, 34);
            txtLegajoAlumnoMod.TabIndex = 26;
            // 
            // lblMod
            // 
            lblMod.AutoSize = true;
            lblMod.BackColor = SystemColors.ActiveCaption;
            lblMod.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMod.ForeColor = SystemColors.ActiveCaptionText;
            lblMod.Location = new Point(419, 12);
            lblMod.Name = "lblMod";
            lblMod.Size = new Size(354, 36);
            lblMod.TabIndex = 27;
            lblMod.Text = "Modificacion de usuario";
            // 
            // lblRepresentante
            // 
            lblRepresentante.AutoSize = true;
            lblRepresentante.Location = new Point(233, 188);
            lblRepresentante.Name = "lblRepresentante";
            lblRepresentante.Size = new Size(104, 20);
            lblRepresentante.TabIndex = 28;
            lblRepresentante.Text = "Representante";
            // 
            // frmModificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblRepresentante);
            Controls.Add(lblMod);
            Controls.Add(txtLegajoAlumnoMod);
            Controls.Add(txtGradoAlumnoMod);
            Controls.Add(txtNombreAlumnoMod);
            Controls.Add(lblDatosAlumnoMod);
            Controls.Add(txtUsuarioClaveMod);
            Controls.Add(txtNumeroCelularMod);
            Controls.Add(txtDirCorreoMod);
            Controls.Add(txtNombreMod);
            Controls.Add(lblPadresOTutorMod);
            Controls.Add(radTutorMod);
            Controls.Add(radMadreMod);
            Controls.Add(radPadreMod);
            Controls.Add(btnCancelarMod);
            Controls.Add(btnGuardarMod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModificacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificacion";
            Load += frmModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarMod;
        private Button btnCancelarMod;
        private RadioButton radPadreMod;
        private RadioButton radMadreMod;
        private RadioButton radTutorMod;
        private Label lblPadresOTutorMod;
        private TextBox txtNombreMod;
        private TextBox txtDirCorreoMod;
        private TextBox txtNumeroCelularMod;
        private TextBox txtUsuarioClaveMod;
        private Label lblDatosAlumnoMod;
        private TextBox txtNombreAlumnoMod;
        private TextBox txtGradoAlumnoMod;
        private TextBox txtLegajoAlumnoMod;
        private Label lblMod;
        private Label lblRepresentante;
    }
}