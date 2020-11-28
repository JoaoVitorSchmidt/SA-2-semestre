namespace SA.Views.Cozinheiro
{
    partial class TelaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidos));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnTelaInicio = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnEstoque.Location = new System.Drawing.Point(172, 378);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(158, 37);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnTelaInicio
            // 
            this.btnTelaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.btnTelaInicio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTelaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnTelaInicio.Location = new System.Drawing.Point(376, 378);
            this.btnTelaInicio.Name = "btnTelaInicio";
            this.btnTelaInicio.Size = new System.Drawing.Size(158, 37);
            this.btnTelaInicio.TabIndex = 0;
            this.btnTelaInicio.Text = "Tela de Início";
            this.btnTelaInicio.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.GridColor = System.Drawing.Color.White;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(35, 29);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(633, 325);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.btnTelaInicio);
            this.Controls.Add(this.btnEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnTelaInicio;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
    }
}