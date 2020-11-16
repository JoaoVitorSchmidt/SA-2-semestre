namespace SA.Views
{
    partial class TelaDeInicioAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeInicioAtendente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCadPed = new System.Windows.Forms.Button();
            this.BtnGerenMesas = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCadPed
            // 
            this.BtnCadPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.BtnCadPed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCadPed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BtnCadPed.Location = new System.Drawing.Point(35, 339);
            this.BtnCadPed.Name = "BtnCadPed";
            this.BtnCadPed.Size = new System.Drawing.Size(170, 45);
            this.BtnCadPed.TabIndex = 1;
            this.BtnCadPed.Text = "Cadastro Pedidos";
            this.BtnCadPed.UseVisualStyleBackColor = false;
            this.BtnCadPed.Click += new System.EventHandler(this.BtnCadPed_Click);
            // 
            // BtnGerenMesas
            // 
            this.BtnGerenMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.BtnGerenMesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGerenMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BtnGerenMesas.Location = new System.Drawing.Point(264, 339);
            this.BtnGerenMesas.Name = "BtnGerenMesas";
            this.BtnGerenMesas.Size = new System.Drawing.Size(170, 45);
            this.BtnGerenMesas.TabIndex = 2;
            this.BtnGerenMesas.Text = "Geren. de Mesas";
            this.BtnGerenMesas.UseVisualStyleBackColor = false;
            this.BtnGerenMesas.Click += new System.EventHandler(this.BtnGerenMesas_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BtnSair.Location = new System.Drawing.Point(488, 339);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(170, 45);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sign Out";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TelaDeInicioAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnGerenMesas);
            this.Controls.Add(this.BtnCadPed);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaDeInicioAtendente";
            this.Text = "TelaDeInicioAtendente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCadPed;
        private System.Windows.Forms.Button BtnGerenMesas;
        private System.Windows.Forms.Button BtnSair;
    }
}