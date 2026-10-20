namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    partial class FrmConFuncionarios
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
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colNome,
            this.colIdade,
            this.colSexo,
            this.colMatricula,
            this.colCpf,
            this.colNumDep,
            this.colSalBase,
            this.colComissao,
            this.colCodCargo,
            this.colCargo});
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNome.Width = 100;
            // 
            // colIdade
            // 
            this.colIdade.Text = "Idade";
            this.colIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colSexo
            // 
            this.colSexo.Text = "Sexo";
            this.colSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMatricula
            // 
            this.colMatricula.Text = "Matricula";
            this.colMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMatricula.Width = 100;
            // 
            // colCpf
            // 
            this.colCpf.Text = "CPF";
            this.colCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colNumDep
            // 
            this.colNumDep.Text = "Num Dependentes";
            this.colNumDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNumDep.Width = 130;
            // 
            // colSalBase
            // 
            this.colSalBase.Text = "Sal Base";
            this.colSalBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSalBase.Width = 100;
            // 
            // colComissao
            // 
            this.colComissao.Text = "Comissão";
            this.colComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colComissao.Width = 100;
            // 
            // colCodCargo
            // 
            this.colCodCargo.Text = "Cod Cargo";
            this.colCodCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCodCargo.Width = 80;
            // 
            // colCargo
            // 
            this.colCargo.Text = "Cargo";
            this.colCargo.Width = 100;
            // 
            // FrmConFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmConFuncionarios";
            this.Text = "Consulta de Funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colIdade;
        private System.Windows.Forms.ColumnHeader colSexo;
        private System.Windows.Forms.ColumnHeader colMatricula;
        private System.Windows.Forms.ColumnHeader colCpf;
        private System.Windows.Forms.ColumnHeader colNumDep;
        private System.Windows.Forms.ColumnHeader colSalBase;
        private System.Windows.Forms.ColumnHeader colComissao;
        private System.Windows.Forms.ColumnHeader colCodCargo;
        private System.Windows.Forms.ColumnHeader colCargo;
    }
}
