namespace Interfaz
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(246, 147);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese usuario";
            txtUsuario.Size = new Size(325, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(246, 211);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Ingrese contraseña";
            txtClave.Size = new Size(325, 34);
            txtClave.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(321, 292);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(156, 73);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Red;
            btnCerrar.Location = new Point(12, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(60, 55);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            ForeColor = SystemColors.InfoText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.CodeDom.CodeTypeReference textBox1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnCerrar;
    }
}