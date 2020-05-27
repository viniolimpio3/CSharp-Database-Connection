namespace Database_Connection
{
    partial class ListForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.NomeProd,
            this.DescProd,
            this.Valor,
            this.CodFor});
            this.grid.Location = new System.Drawing.Point(12, 54);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(655, 273);
            this.grid.TabIndex = 0;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            this.CodProd.Width = 65;
            // 
            // NomeProd
            // 
            this.NomeProd.HeaderText = "Nome";
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.Width = 60;
            // 
            // DescProd
            // 
            this.DescProd.HeaderText = "Descrição";
            this.DescProd.Name = "DescProd";
            this.DescProd.Width = 80;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 56;
            // 
            // CodFor
            // 
            this.CodFor.HeaderText = "Fornecedor";
            this.CodFor.Name = "CodFor";
            this.CodFor.Width = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTOS";
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(340, 343);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(90, 47);
            this.btn_exibir.TabIndex = 2;
            this.btn_exibir.Text = "&Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(461, 343);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(90, 47);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "&Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(577, 343);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(90, 47);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(679, 411);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Produtos";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFor;
    }
}

