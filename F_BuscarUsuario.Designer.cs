namespace Proyecto_POO
{
    partial class F_BuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BuscarUsuario));
            this.PB_USUARIO = new System.Windows.Forms.PictureBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.F_Apellido = new System.Windows.Forms.Label();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.bt_BuscarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_USUARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_USUARIO
            // 
            this.PB_USUARIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_USUARIO.Image = ((System.Drawing.Image)(resources.GetObject("PB_USUARIO.Image")));
            this.PB_USUARIO.Location = new System.Drawing.Point(756, 12);
            this.PB_USUARIO.Name = "PB_USUARIO";
            this.PB_USUARIO.Size = new System.Drawing.Size(328, 339);
            this.PB_USUARIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_USUARIO.TabIndex = 0;
            this.PB_USUARIO.TabStop = false;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.Color.Black;
            this.tb_nombre.Location = new System.Drawing.Point(765, 590);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(359, 38);
            this.tb_nombre.TabIndex = 1;
            this.tb_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Nombre
            // 
            this.L_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nombre.Location = new System.Drawing.Point(837, 484);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(181, 51);
            this.L_Nombre.TabIndex = 2;
            this.L_Nombre.Text = "Nombre";
            // 
            // F_Apellido
            // 
            this.F_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.F_Apellido.AutoSize = true;
            this.F_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Apellido.Location = new System.Drawing.Point(837, 674);
            this.F_Apellido.Name = "F_Apellido";
            this.F_Apellido.Size = new System.Drawing.Size(185, 51);
            this.F_Apellido.TabIndex = 3;
            this.F_Apellido.Text = "Apellido";
            // 
            // tb_apellido
            // 
            this.tb_apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apellido.ForeColor = System.Drawing.Color.Black;
            this.tb_apellido.Location = new System.Drawing.Point(774, 780);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(359, 38);
            this.tb_apellido.TabIndex = 4;
            this.tb_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_BuscarUsuario
            // 
            this.bt_BuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_BuscarUsuario.BackColor = System.Drawing.Color.LightGreen;
            this.bt_BuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BuscarUsuario.Location = new System.Drawing.Point(866, 858);
            this.bt_BuscarUsuario.Name = "bt_BuscarUsuario";
            this.bt_BuscarUsuario.Size = new System.Drawing.Size(180, 82);
            this.bt_BuscarUsuario.TabIndex = 5;
            this.bt_BuscarUsuario.Text = "Buscar Cliente";
            this.bt_BuscarUsuario.UseVisualStyleBackColor = false;
            this.bt_BuscarUsuario.Click += new System.EventHandler(this.bt_BuscarUsuario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese los datos del cliente";
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Red;
            this.bt_back.Image = ((System.Drawing.Image)(resources.GetObject("bt_back.Image")));
            this.bt_back.Location = new System.Drawing.Point(12, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(124, 84);
            this.bt_back.TabIndex = 7;
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_BuscarUsuario);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.F_Apellido);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.PB_USUARIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_BuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_USUARIO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_USUARIO;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label F_Apellido;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Button bt_BuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_back;
    }
}