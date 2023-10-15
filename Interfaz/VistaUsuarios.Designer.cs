namespace Interfaz
{
    partial class VistaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUsuarios));
            dtgVistaUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgVistaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgVistaUsuarios
            // 
            dtgVistaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVistaUsuarios.Location = new Point(67, 12);
            dtgVistaUsuarios.Name = "dtgVistaUsuarios";
            dtgVistaUsuarios.RowHeadersWidth = 51;
            dtgVistaUsuarios.RowTemplate.Height = 29;
            dtgVistaUsuarios.Size = new Size(721, 402);
            dtgVistaUsuarios.TabIndex = 0;
            // 
            // VistaUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dtgVistaUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VistaUsuarios";
            Load += VistaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVistaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgVistaUsuarios;
    }
}