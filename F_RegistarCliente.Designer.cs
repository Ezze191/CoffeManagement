namespace Proyecto_POO
{
    partial class F_RegistarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RegistarCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_registrarCliente = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa los datos para registrar al cliente";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(491, 572);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(411, 38);
            this.tb_nombre.TabIndex = 2;
            // 
            // tb_apellido
            // 
            this.tb_apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apellido.Location = new System.Drawing.Point(491, 771);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(411, 38);
            this.tb_apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // bt_registrarCliente
            // 
            this.bt_registrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_registrarCliente.BackColor = System.Drawing.Color.Lime;
            this.bt_registrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarCliente.Location = new System.Drawing.Point(601, 869);
            this.bt_registrarCliente.Name = "bt_registrarCliente";
            this.bt_registrarCliente.Size = new System.Drawing.Size(215, 87);
            this.bt_registrarCliente.TabIndex = 6;
            this.bt_registrarCliente.Text = "Registrar Cliente";
            this.bt_registrarCliente.UseVisualStyleBackColor = false;
            this.bt_registrarCliente.Click += new System.EventHandler(this.bt_registrarCliente_Click);
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Red;
            this.bt_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_back.BackgroundImage")));
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_back.Location = new System.Drawing.Point(12, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(138, 94);
            this.bt_back.TabIndex = 7;
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // F_RegistarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 1011);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_registrarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RegistarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_RegistarCliente";
            this.Load += new System.EventHandler(this.F_RegistarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_registrarCliente;
        private System.Windows.Forms.Button bt_back;
    }
}