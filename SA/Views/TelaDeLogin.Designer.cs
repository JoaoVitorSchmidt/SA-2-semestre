namespace SA.Views
{
    partial class TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonTelaCadastrar = new System.Windows.Forms.Button();
            this.buttonLogo1 = new System.Windows.Forms.Button();
            this.textBoxNome1 = new System.Windows.Forms.TextBox();
            this.textBoxSenha1 = new System.Windows.Forms.TextBox();
            this.labelNome1 = new System.Windows.Forms.Label();
            this.labelSenha1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrar.Location = new System.Drawing.Point(164, 257);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 35);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // buttonTelaCadastrar
            // 
            this.buttonTelaCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTelaCadastrar.Location = new System.Drawing.Point(280, 257);
            this.buttonTelaCadastrar.Name = "buttonTelaCadastrar";
            this.buttonTelaCadastrar.Size = new System.Drawing.Size(91, 35);
            this.buttonTelaCadastrar.TabIndex = 0;
            this.buttonTelaCadastrar.Text = "Cadastrar";
            this.buttonTelaCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonLogo1
            // 
            this.buttonLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogo1.BackgroundImage")));
            this.buttonLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(31)))), ((int)(((byte)(12)))));
            this.buttonLogo1.Location = new System.Drawing.Point(180, 12);
            this.buttonLogo1.Name = "buttonLogo1";
            this.buttonLogo1.Size = new System.Drawing.Size(176, 144);
            this.buttonLogo1.TabIndex = 0;
            this.buttonLogo1.TabStop = false;
            this.buttonLogo1.UseVisualStyleBackColor = true;
            // 
            // textBoxNome1
            // 
            this.textBoxNome1.Location = new System.Drawing.Point(173, 165);
            this.textBoxNome1.Name = "textBoxNome1";
            this.textBoxNome1.Size = new System.Drawing.Size(191, 23);
            this.textBoxNome1.TabIndex = 1;
            // 
            // textBoxSenha1
            // 
            this.textBoxSenha1.Location = new System.Drawing.Point(173, 205);
            this.textBoxSenha1.Name = "textBoxSenha1";
            this.textBoxSenha1.Size = new System.Drawing.Size(191, 23);
            this.textBoxSenha1.TabIndex = 1;
            this.textBoxSenha1.UseSystemPasswordChar = true;
            // 
            // labelNome1
            // 
            this.labelNome1.AutoSize = true;
            this.labelNome1.BackColor = System.Drawing.Color.Transparent;
            this.labelNome1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome1.ForeColor = System.Drawing.Color.White;
            this.labelNome1.Location = new System.Drawing.Point(115, 165);
            this.labelNome1.Name = "labelNome1";
            this.labelNome1.Size = new System.Drawing.Size(52, 20);
            this.labelNome1.TabIndex = 2;
            this.labelNome1.Text = "Nome:";
            // 
            // labelSenha1
            // 
            this.labelSenha1.AutoSize = true;
            this.labelSenha1.BackColor = System.Drawing.Color.Transparent;
            this.labelSenha1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenha1.ForeColor = System.Drawing.Color.White;
            this.labelSenha1.Location = new System.Drawing.Point(112, 205);
            this.labelSenha1.Name = "labelSenha1";
            this.labelSenha1.Size = new System.Drawing.Size(55, 20);
            this.labelSenha1.TabIndex = 2;
            this.labelSenha1.Text = "Senha:";
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(31)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(544, 304);
            this.Controls.Add(this.labelSenha1);
            this.Controls.Add(this.labelNome1);
            this.Controls.Add(this.textBoxSenha1);
            this.Controls.Add(this.textBoxNome1);
            this.Controls.Add(this.buttonLogo1);
            this.Controls.Add(this.buttonTelaCadastrar);
            this.Controls.Add(this.buttonEntrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaDeLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonTelaCadastrar;
        private System.Windows.Forms.Button buttonLogo1;
        private System.Windows.Forms.TextBox textBoxNome1;
        private System.Windows.Forms.TextBox textBoxSenha1;
        private System.Windows.Forms.Label labelNome1;
        private System.Windows.Forms.Label labelSenha1;
    }
}