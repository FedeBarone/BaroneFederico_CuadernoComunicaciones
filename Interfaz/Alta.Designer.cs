using System.Windows.Forms;
using System.Drawing;
namespace Interfaz
{
    partial class frmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta));
            txtRelacionConAlumno = new TextBox();
            txtNumeroCelular = new TextBox();
            txtDirCorreo = new TextBox();
            txtNombre = new TextBox();
            txtUsuarioClave = new TextBox();
            txtNombreAlumno = new TextBox();
            lblAlta = new Label();
            lblPadresOTutor = new Label();
            lblDatosAlumno = new Label();
            txtGradoAlumno = new TextBox();
            txtLegajoAlumno = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtRelacionConAlumno
            // 
            txtRelacionConAlumno.BackColor = Color.Silver;
            txtRelacionConAlumno.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRelacionConAlumno.Location = new Point(12, 177);
            txtRelacionConAlumno.Name = "txtRelacionConAlumno";
            txtRelacionConAlumno.PlaceholderText = "Ingrese relacion con alumno";
            txtRelacionConAlumno.Size = new Size(325, 34);
            txtRelacionConAlumno.TabIndex = 2;
            // 
            // txtNumeroCelular
            // 
            txtNumeroCelular.BackColor = Color.Silver;
            txtNumeroCelular.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroCelular.Location = new Point(12, 137);
            txtNumeroCelular.Name = "txtNumeroCelular";
            txtNumeroCelular.PlaceholderText = "Ingrese numero celular";
            txtNumeroCelular.Size = new Size(325, 34);
            txtNumeroCelular.TabIndex = 3;
            // 
            // txtDirCorreo
            // 
            txtDirCorreo.BackColor = Color.Silver;
            txtDirCorreo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirCorreo.Location = new Point(11, 97);
            txtDirCorreo.Name = "txtDirCorreo";
            txtDirCorreo.PlaceholderText = "Ingrese direccion de correo";
            txtDirCorreo.Size = new Size(325, 34);
            txtDirCorreo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(11, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre completo";
            txtNombre.Size = new Size(325, 34);
            txtNombre.TabIndex = 5;
            // 
            // txtUsuarioClave
            // 
            txtUsuarioClave.BackColor = Color.Silver;
            txtUsuarioClave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioClave.Location = new Point(12, 217);
            txtUsuarioClave.Name = "txtUsuarioClave";
            txtUsuarioClave.PlaceholderText = "Ingrese clave de usuario";
            txtUsuarioClave.Size = new Size(325, 34);
            txtUsuarioClave.TabIndex = 6;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.BackColor = Color.Silver;
            txtNombreAlumno.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreAlumno.Location = new Point(11, 318);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.PlaceholderText = "Ingrese nombre del alumno";
            txtNombreAlumno.Size = new Size(325, 34);
            txtNombreAlumno.TabIndex = 7;
            // 
            // lblAlta
            // 
            lblAlta.AutoSize = true;
            lblAlta.BackColor = SystemColors.ActiveCaption;
            lblAlta.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlta.ForeColor = SystemColors.ActiveCaptionText;
            lblAlta.Location = new Point(484, 9);
            lblAlta.Name = "lblAlta";
            lblAlta.Size = new Size(230, 36);
            lblAlta.TabIndex = 8;
            lblAlta.Text = "Alta de usuario";
            // 
            // lblPadresOTutor
            // 
            lblPadresOTutor.AutoSize = true;
            lblPadresOTutor.BackColor = SystemColors.ActiveCaption;
            lblPadresOTutor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPadresOTutor.ForeColor = SystemColors.ActiveCaptionText;
            lblPadresOTutor.Location = new Point(12, 9);
            lblPadresOTutor.Name = "lblPadresOTutor";
            lblPadresOTutor.Size = new Size(324, 29);
            lblPadresOTutor.TabIndex = 9;
            lblPadresOTutor.Text = "Datos padre, madre o tutor";
            // 
            // lblDatosAlumno
            // 
            lblDatosAlumno.AutoSize = true;
            lblDatosAlumno.BackColor = SystemColors.ActiveCaption;
            lblDatosAlumno.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosAlumno.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosAlumno.Location = new Point(12, 272);
            lblDatosAlumno.Name = "lblDatosAlumno";
            lblDatosAlumno.Size = new Size(172, 29);
            lblDatosAlumno.TabIndex = 10;
            lblDatosAlumno.Text = "Datos alumno";
            // 
            // txtGradoAlumno
            // 
            txtGradoAlumno.BackColor = Color.Silver;
            txtGradoAlumno.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGradoAlumno.Location = new Point(11, 358);
            txtGradoAlumno.Name = "txtGradoAlumno";
            txtGradoAlumno.PlaceholderText = "Ingrese grado del alumno";
            txtGradoAlumno.Size = new Size(325, 34);
            txtGradoAlumno.TabIndex = 11;
            // 
            // txtLegajoAlumno
            // 
            txtLegajoAlumno.BackColor = Color.Silver;
            txtLegajoAlumno.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLegajoAlumno.Location = new Point(11, 398);
            txtLegajoAlumno.Name = "txtLegajoAlumno";
            txtLegajoAlumno.PlaceholderText = "Ingrese legajo del alumno";
            txtLegajoAlumno.Size = new Size(325, 34);
            txtLegajoAlumno.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(439, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 74);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(632, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 74);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 470);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtLegajoAlumno);
            Controls.Add(txtGradoAlumno);
            Controls.Add(lblDatosAlumno);
            Controls.Add(lblPadresOTutor);
            Controls.Add(lblAlta);
            Controls.Add(txtNombreAlumno);
            Controls.Add(txtUsuarioClave);
            Controls.Add(txtNombre);
            Controls.Add(txtDirCorreo);
            Controls.Add(txtNumeroCelular);
            Controls.Add(txtRelacionConAlumno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta";
            Load += frmAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRelacionConAlumno;
        private TextBox txtNumeroCelular;
        private TextBox txtDirCorreo;
        private TextBox txtNombre;
        private TextBox txtUsuarioClave;
        private TextBox txtNombreAlumno;
        private Label lblAlta;
        private Label lblPadresOTutor;
        private Label lblDatosAlumno;
        private TextBox txtGradoAlumno;
        private TextBox txtLegajoAlumno;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}