namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    partial class FrmConCargos
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
            this.colCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCargo,
            this.colCnh,
            this.colComissao});
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // colCargo
            // 
            this.colCargo.Text = "Cargo";
            this.colCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCargo.Width = 200;
            // 
            // colCnh
            // 
            this.colCnh.Text = "Exige Cnh";
            this.colCnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCnh.Width = 100;
            // 
            // colComissao
            // 
            this.colComissao.Text = "Ganha Comissão";
            this.colComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colComissao.Width = 130;
            // 
            // FrmConCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmConCargos";
            this.Text = "Consulta de Cargos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colCargo;
        private System.Windows.Forms.ColumnHeader colCnh;
        private System.Windows.Forms.ColumnHeader colComissao;
    }
}
