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
            this.labelPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnEstoque.Location = new System.Drawing.Point(225, 311);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(150, 40);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnTelaInicio
            // 
            this.btnTelaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.btnTelaInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTelaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnTelaInicio.Location = new System.Drawing.Point(443, 311);
            this.btnTelaInicio.Name = "btnTelaInicio";
            this.btnTelaInicio.Size = new System.Drawing.Size(150, 40);
            this.btnTelaInicio.TabIndex = 0;
            this.btnTelaInicio.Text = "Tela de Início";
            this.btnTelaInicio.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(776, 236);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.labelPedido.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.labelPedido.Location = new System.Drawing.Point(324, 5);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(172, 54);
            this.labelPedido.TabIndex = 2;
            this.labelPedido.Text = "Pedidos";
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.btnTelaInicio);
            this.Controls.Add(this.btnEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnTelaInicio;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Label labelPedido;
    }
}