namespace SA.Views
{
    partial class TelaGerenciamentoDeMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenciamentoDeMesas));
            this.comboBoxStatsMesa = new System.Windows.Forms.ComboBox();
            this.comboBoxStatsPedido = new System.Windows.Forms.ComboBox();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.labelMesa = new System.Windows.Forms.Label();
            this.labelStatusMesa = new System.Windows.Forms.Label();
            this.labelStatusPedido = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.buttonFundo = new System.Windows.Forms.Button();
            this.comboBoxNMesa = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStatsMesa
            // 
            this.comboBoxStatsMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.comboBoxStatsMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatsMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.comboBoxStatsMesa.FormattingEnabled = true;
            this.comboBoxStatsMesa.Items.AddRange(new object[] {
            "Ocupado",
            "Livre",
            "Reservado",
            "A Espera de Limpeza"});
            this.comboBoxStatsMesa.Location = new System.Drawing.Point(398, 164);
            this.comboBoxStatsMesa.Name = "comboBoxStatsMesa";
            this.comboBoxStatsMesa.Size = new System.Drawing.Size(111, 29);
            this.comboBoxStatsMesa.TabIndex = 2;
            // 
            // comboBoxStatsPedido
            // 
            this.comboBoxStatsPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.comboBoxStatsPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatsPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.comboBoxStatsPedido.FormattingEnabled = true;
            this.comboBoxStatsPedido.Items.AddRange(new object[] {
            "Já feito",
            "Esperando Atendente",
            "Mesa Vazia"});
            this.comboBoxStatsPedido.Location = new System.Drawing.Point(524, 164);
            this.comboBoxStatsPedido.Name = "comboBoxStatsPedido";
            this.comboBoxStatsPedido.Size = new System.Drawing.Size(162, 29);
            this.comboBoxStatsPedido.TabIndex = 3;
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBoxObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBoxObservacao.Location = new System.Drawing.Point(253, 233);
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(432, 29);
            this.textBoxObservacao.TabIndex = 4;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonEditar.Location = new System.Drawing.Point(495, 301);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(142, 34);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.buttonInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonInicio.Location = new System.Drawing.Point(332, 301);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(142, 34);
            this.buttonInicio.TabIndex = 6;
            this.buttonInicio.Text = "Início";
            this.buttonInicio.UseVisualStyleBackColor = false;
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.labelMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMesa.ForeColor = System.Drawing.Color.White;
            this.labelMesa.Location = new System.Drawing.Point(253, 140);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(130, 21);
            this.labelMesa.TabIndex = 8;
            this.labelMesa.Text = "Número da Mesa";
            // 
            // labelStatusMesa
            // 
            this.labelStatusMesa.AutoSize = true;
            this.labelStatusMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.labelStatusMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatusMesa.ForeColor = System.Drawing.Color.White;
            this.labelStatusMesa.Location = new System.Drawing.Point(395, 140);
            this.labelStatusMesa.Name = "labelStatusMesa";
            this.labelStatusMesa.Size = new System.Drawing.Size(114, 21);
            this.labelStatusMesa.TabIndex = 8;
            this.labelStatusMesa.Text = "Status da Mesa";
            // 
            // labelStatusPedido
            // 
            this.labelStatusPedido.AutoSize = true;
            this.labelStatusPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.labelStatusPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatusPedido.ForeColor = System.Drawing.Color.White;
            this.labelStatusPedido.Location = new System.Drawing.Point(524, 140);
            this.labelStatusPedido.Name = "labelStatusPedido";
            this.labelStatusPedido.Size = new System.Drawing.Size(125, 21);
            this.labelStatusPedido.TabIndex = 8;
            this.labelStatusPedido.Text = "Status do Pedido";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.labelObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelObservacao.ForeColor = System.Drawing.Color.White;
            this.labelObservacao.Location = new System.Drawing.Point(253, 209);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(92, 21);
            this.labelObservacao.TabIndex = 8;
            this.labelObservacao.Text = "Observação";
            // 
            // buttonFundo
            // 
            this.buttonFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonFundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFundo.Location = new System.Drawing.Point(243, 12);
            this.buttonFundo.Name = "buttonFundo";
            this.buttonFundo.Size = new System.Drawing.Size(449, 339);
            this.buttonFundo.TabIndex = 9;
            this.buttonFundo.UseVisualStyleBackColor = false;
            // 
            // comboBoxNMesa
            // 
            this.comboBoxNMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.comboBoxNMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.comboBoxNMesa.FormattingEnabled = true;
            this.comboBoxNMesa.Location = new System.Drawing.Point(253, 164);
            this.comboBoxNMesa.Name = "comboBoxNMesa";
            this.comboBoxNMesa.Size = new System.Drawing.Size(130, 29);
            this.comboBoxNMesa.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // TelaGerenciamentoDeMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxNMesa);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.labelStatusPedido);
            this.Controls.Add(this.labelStatusMesa);
            this.Controls.Add(this.labelMesa);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.comboBoxStatsPedido);
            this.Controls.Add(this.comboBoxStatsMesa);
            this.Controls.Add(this.buttonFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaGerenciamentoDeMesas";
            this.Text = "Gerenciamento de Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxStatsMesa;
        private System.Windows.Forms.ComboBox comboBoxStatsPedido;
        private System.Windows.Forms.TextBox textBoxObservacao;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Label labelStatusMesa;
        private System.Windows.Forms.Label labelStatusPedido;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.Button buttonFundo;
        private System.Windows.Forms.ComboBox comboBoxNMesa;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}