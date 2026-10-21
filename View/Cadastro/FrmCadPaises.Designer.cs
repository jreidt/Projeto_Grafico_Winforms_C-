namespace Grafico_2026_Julio_Eidt.View.Cadastro
{
    partial class FrmCadPaises
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDdi = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDdi = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(141, 50);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "Pais";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(400, 50);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(38, 16);
            this.lblSigla.TabIndex = 5;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDdi
            // 
            this.lblDdi.AutoSize = true;
            this.lblDdi.Location = new System.Drawing.Point(534, 50);
            this.lblDdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDdi.Name = "lblDdi";
            this.lblDdi.Size = new System.Drawing.Size(30, 16);
            this.lblDdi.TabIndex = 7;
            this.lblDdi.Text = "DDI";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(653, 50);
            this.lblMoeda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(50, 16);
            this.lblMoeda.TabIndex = 9;
            this.lblMoeda.Text = "Moeda";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(145, 70);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(251, 22);
            this.txtPais.TabIndex = 4;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(404, 70);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(73, 22);
            this.txtSigla.TabIndex = 6;
            // 
            // txtDdi
            // 
            this.txtDdi.Location = new System.Drawing.Point(538, 70);
            this.txtDdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDdi.Name = "txtDdi";
            this.txtDdi.Size = new System.Drawing.Size(73, 22);
            this.txtDdi.TabIndex = 8;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(657, 70);
            this.txtMoeda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(73, 22);
            this.txtMoeda.TabIndex = 10;
            // 
            // FrmCadPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDdi);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDdi);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmCadPaises";
            this.Text = "Cadastro de Paises";
            this.Controls.SetChildIndex(this.lblCodUsulbl, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCadlbl, 0);
            this.Controls.SetChildIndex(this.lblUltAltlbl, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDdi, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDdi, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblPais;
        protected System.Windows.Forms.Label lblSigla;
        protected System.Windows.Forms.Label lblDdi;
        protected System.Windows.Forms.Label lblMoeda;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.TextBox txtSigla;
        protected System.Windows.Forms.TextBox txtDdi;
        protected System.Windows.Forms.TextBox txtMoeda;
    }
}
