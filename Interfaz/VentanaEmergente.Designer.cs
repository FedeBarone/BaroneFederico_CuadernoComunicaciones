namespace Interfaz
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            lblTitulo = new Label();
            lblMsj = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(17, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblMsj
            // 
            lblMsj.AutoSize = true;
            lblMsj.BackColor = Color.Transparent;
            lblMsj.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsj.Location = new Point(116, 9);
            lblMsj.Name = "lblMsj";
            lblMsj.Size = new Size(54, 29);
            lblMsj.TabIndex = 1;
            lblMsj.Text = "Msj";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Silver;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(96, 99);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 39);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // VentanaEmergente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(297, 165);
            ControlBox = false;
            Controls.Add(btnOk);
            Controls.Add(lblMsj);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaEmergente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaEmergente";
            Load += VentanaEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMsj;
        private Button btnOk;
    }
}