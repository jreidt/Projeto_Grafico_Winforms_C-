namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    partial class FrmConPaises
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
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colPais,
            this.colSigla,
            this.colDdi,
            this.colMoeda});
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.Width = 200;
            // 
            // colSigla
            // 
            this.colSigla.Text = "Sigla";
            this.colSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDdi
            // 
            this.colDdi.Text = "DDI";
            this.colDdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMoeda
            // 
            this.colMoeda.Text = "Moeda";
            this.colMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmConPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmConPaises";
            this.Text = "Consulta de Paises";
            this.Load += new System.EventHandler(this.FrmConPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colPais;
        private System.Windows.Forms.ColumnHeader colSigla;
        private System.Windows.Forms.ColumnHeader colDdi;
        private System.Windows.Forms.ColumnHeader colMoeda;
    }
}
