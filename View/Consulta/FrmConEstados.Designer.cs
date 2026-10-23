namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    partial class FrmConEstados
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
            this.colEstados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colEstados,
            this.colUf,
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
            // colEstados
            // 
            this.colEstados.Text = "Estado";
            this.colEstados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEstados.Width = 200;
            // 
            // colUf
            // 
            this.colUf.Text = "UF";
            this.colUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodPais
            // 
            this.colCodPais.Text = "Cod Pais";
            this.colCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCodPais.Width = 80;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPais.Width = 200;
            // 
            // FrmConEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConEstados";
            this.Text = "Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colEstados;
        private System.Windows.Forms.ColumnHeader colUf;
        private System.Windows.Forms.ColumnHeader colCodPais;
        private System.Windows.Forms.ColumnHeader colPais;
    }
}
