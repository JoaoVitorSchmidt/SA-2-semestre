namespace SA.Views
{
    partial class TelaDeBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeBebidas));
            this.checkedListBoxBebidas = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFecharPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxBebidas
            // 
            this.checkedListBoxBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.checkedListBoxBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxBebidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxBebidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.checkedListBoxBebidas.FormattingEnabled = true;
            this.checkedListBoxBebidas.Items.AddRange(new object[] {
            "Água Mineral s/gás | R$ 4,00 ",
            "Água Mineral c/gás| R$ 4,00",
            "Refrigerante 350 ml | R$ 3,50",
            "Refrigernte 600 ml | R$ 4,00",
            "Refrigernte 1L | R$ 6,00",
            "Cerveja lata 350 ml | R$ 3,50",
            "Cerveja garrafa 500 ml | R$ 5,00",
            "Cerveja garrafa 1L | R$ 8,50",
            "Torre de Chop 1,5L | R$ 25,00",
            "Torre de Chop 2L | R$ 35,00",
            "Suco 500 ml | R$ 5,00"});
            this.checkedListBoxBebidas.Location = new System.Drawing.Point(244, 91);
            this.checkedListBoxBebidas.Name = "checkedListBoxBebidas";
            this.checkedListBoxBebidas.Size = new System.Drawing.Size(424, 264);
            this.checkedListBoxBebidas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFecharPedido
            // 
            this.buttonFecharPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.buttonFecharPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFecharPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonFecharPedido.Location = new System.Drawing.Point(520, 204);
            this.buttonFecharPedido.Name = "buttonFecharPedido";
            this.buttonFecharPedido.Size = new System.Drawing.Size(129, 41);
            this.buttonFecharPedido.TabIndex = 2;
            this.buttonFecharPedido.Text = "Fechar Pedido";
            this.buttonFecharPedido.UseVisualStyleBackColor = false;
            // 
            // TelaDeBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.buttonFecharPedido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBoxBebidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaDeBebidas";
            this.Text = "Bebidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxBebidas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFecharPedido;
    }
}