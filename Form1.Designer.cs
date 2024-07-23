namespace Proyecto_POO
{
    partial class F_HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_HOME));
            this.label1 = new System.Windows.Forms.Label();
            this.PB_LOGO = new System.Windows.Forms.PictureBox();
            this.BT_BUSCAR_USUARIO = new System.Windows.Forms.Button();
            this.BT_REGISTRAR = new System.Windows.Forms.Button();
            this.BT_INVITADO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "##NOMBRE DEL PROGRAMA##";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_LOGO
            // 
            this.PB_LOGO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("PB_LOGO.Image")));
            this.PB_LOGO.Location = new System.Drawing.Point(747, 11);
            this.PB_LOGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_LOGO.Name = "PB_LOGO";
            this.PB_LOGO.Size = new System.Drawing.Size(289, 174);
            this.PB_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_LOGO.TabIndex = 1;
            this.PB_LOGO.TabStop = false;
            // 
            // BT_BUSCAR_USUARIO
            // 
            this.BT_BUSCAR_USUARIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_BUSCAR_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BT_BUSCAR_USUARIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BT_BUSCAR_USUARIO.Location = new System.Drawing.Point(747, 453);
            this.BT_BUSCAR_USUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_BUSCAR_USUARIO.Name = "BT_BUSCAR_USUARIO";
            this.BT_BUSCAR_USUARIO.Size = new System.Drawing.Size(329, 69);
            this.BT_BUSCAR_USUARIO.TabIndex = 2;
            this.BT_BUSCAR_USUARIO.Text = "BUSCAR USUARIO";
            this.BT_BUSCAR_USUARIO.UseVisualStyleBackColor = false;
            this.BT_BUSCAR_USUARIO.Click += new System.EventHandler(this.BT_BUSCAR_USUARIO_Click);
            // 
            // BT_REGISTRAR
            // 
            this.BT_REGISTRAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_REGISTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BT_REGISTRAR.Location = new System.Drawing.Point(747, 638);
            this.BT_REGISTRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_REGISTRAR.Name = "BT_REGISTRAR";
            this.BT_REGISTRAR.Size = new System.Drawing.Size(329, 72);
            this.BT_REGISTRAR.TabIndex = 3;
            this.BT_REGISTRAR.Text = "REGISTRAR";
            this.BT_REGISTRAR.UseVisualStyleBackColor = false;
            // 
            // BT_INVITADO
            // 
            this.BT_INVITADO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_INVITADO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BT_INVITADO.Location = new System.Drawing.Point(747, 836);
            this.BT_INVITADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_INVITADO.Name = "BT_INVITADO";
            this.BT_INVITADO.Size = new System.Drawing.Size(329, 71);
            this.BT_INVITADO.TabIndex = 4;
            this.BT_INVITADO.Text = "INVITADO";
            this.BT_INVITADO.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(611, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecciona una opcion de registro del cliente";
            // 
            // F_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_INVITADO);
            this.Controls.Add(this.BT_REGISTRAR);
            this.Controls.Add(this.BT_BUSCAR_USUARIO);
            this.Controls.Add(this.PB_LOGO);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_LOGO;
        private System.Windows.Forms.Button BT_BUSCAR_USUARIO;
        private System.Windows.Forms.Button BT_REGISTRAR;
        private System.Windows.Forms.Button BT_INVITADO;
        private System.Windows.Forms.Label label2;
    }
}

