namespace Proyecto_POO
{
    partial class dinero_cambio
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
            this.label1 = new System.Windows.Forms.Label();
            this.dinero_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cambio = new System.Windows.Forms.Label();
            this.BT_OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL :";
            // 
            // dinero_lb
            // 
            this.dinero_lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dinero_lb.AutoSize = true;
            this.dinero_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinero_lb.ForeColor = System.Drawing.Color.ForestGreen;
            this.dinero_lb.Location = new System.Drawing.Point(239, 27);
            this.dinero_lb.Name = "dinero_lb";
            this.dinero_lb.Size = new System.Drawing.Size(57, 29);
            this.dinero_lb.TabIndex = 1;
            this.dinero_lb.Text = "****";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(94, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 22);
            this.textBox1.TabIndex = 2;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_calcular.BackColor = System.Drawing.Color.Lime;
            this.bt_calcular.Location = new System.Drawing.Point(221, 186);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 31);
            this.bt_calcular.TabIndex = 3;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAMBIO :";
            // 
            // lb_cambio
            // 
            this.lb_cambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cambio.AutoSize = true;
            this.lb_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cambio.ForeColor = System.Drawing.Color.Red;
            this.lb_cambio.Location = new System.Drawing.Point(239, 275);
            this.lb_cambio.Name = "lb_cambio";
            this.lb_cambio.Size = new System.Drawing.Size(57, 29);
            this.lb_cambio.TabIndex = 5;
            this.lb_cambio.Text = "****";
            // 
            // BT_OK
            // 
            this.BT_OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_OK.BackColor = System.Drawing.Color.Lime;
            this.BT_OK.Location = new System.Drawing.Point(395, 424);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(75, 31);
            this.BT_OK.TabIndex = 6;
            this.BT_OK.Text = "OK";
            this.BT_OK.UseVisualStyleBackColor = false;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese la cantidad recibida";
            // 
            // dinero_cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.lb_cambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dinero_lb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dinero_cambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dinero_cambio_FormClosing);
            this.Load += new System.EventHandler(this.dinero_cambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dinero_lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_cambio;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Label label4;
    }
}