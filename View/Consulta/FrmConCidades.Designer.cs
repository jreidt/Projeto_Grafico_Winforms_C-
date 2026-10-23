namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    partial class FrmConCidades
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
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDDD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colCidade,
            this.colDDD,
            this.colCodEstado,
            this.colEstado,
            this.colCodPais,
            this.colPais});
            this.listV.SelectedIndexChanged += new System.EventHandler(this.listV_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // colCidade
            // 
            this.colCidade.Text = "Cidade";
            this.colCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCidade.Width = 200;
            // 
            // colDDD
            // 
            this.colDDD.Text = "DDD";
            this.colDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodEstado
            // 
            this.colCodEstado.Text = "Cod Estado";
            this.colCodEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCodEstado.Width = 100;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEstado.Width = 200;
            // 
            // colCodPais
            // 
            this.colCodPais.Text = "Cod Pais";
            this.colCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCodPais.Width = 100;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPais.Width = 200;
            // 
            // FrmConCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConCidades";
            this.Text = "Consulta de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colCidade;
        private System.Windows.Forms.ColumnHeader colDDD;
        private System.Windows.Forms.ColumnHeader colCodEstado;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colCodPais;
        private System.Windows.Forms.ColumnHeader colPais;
    }
}
