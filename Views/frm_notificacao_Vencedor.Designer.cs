namespace JogoDaVelha_PC.Views
{
    partial class frm_notificacao_Vencedor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ganhador = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::JogoDaVelha_PC.Properties.Resources.trofel;
            this.pictureBox1.Location = new System.Drawing.Point(373, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parabêns!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(63, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foi o Vencedor";
            // 
            // lb_ganhador
            // 
            this.lb_ganhador.AutoSize = true;
            this.lb_ganhador.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ganhador.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ganhador.Location = new System.Drawing.Point(158, 109);
            this.lb_ganhador.Name = "lb_ganhador";
            this.lb_ganhador.Size = new System.Drawing.Size(40, 65);
            this.lb_ganhador.TabIndex = 3;
            this.lb_ganhador.Text = ".";
            // 
            // bt_ok
            // 
            this.bt_ok.FlatAppearance.BorderSize = 3;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.Color.Lime;
            this.bt_ok.Location = new System.Drawing.Point(373, 192);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(108, 48);
            this.bt_ok.TabIndex = 4;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // frm_notificacao_Vencedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(493, 252);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_ganhador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 500);
            this.Name = "frm_notificacao_Vencedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_notificacao_Vencedor";
            this.Load += new System.EventHandler(this.frm_notificacao_Vencedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_notificacao_Vencedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ganhador;
        private System.Windows.Forms.Button bt_ok;
    }
}