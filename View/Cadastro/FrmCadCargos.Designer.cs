namespace Grafico_2026_Julio_Eidt.View.Cadastro
{
    partial class FrmCadCargos
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblExigeCnh = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.cboxExigeCnh = new System.Windows.Forms.CheckBox();
            this.cboxGanhaComissao = new System.Windows.Forms.CheckBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
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
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(153, 49);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 16);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblExigeCnh
            // 
            this.lblExigeCnh.AutoSize = true;
            this.lblExigeCnh.Location = new System.Drawing.Point(296, 49);
            this.lblExigeCnh.Name = "lblExigeCnh";
            this.lblExigeCnh.Size = new System.Drawing.Size(36, 16);
            this.lblExigeCnh.TabIndex = 5;
            this.lblExigeCnh.Text = "CNH";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(366, 50);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(68, 16);
            this.lblComissao.TabIndex = 7;
            this.lblComissao.Text = "Comissão";
            // 
            // cboxExigeCnh
            // 
            this.cboxExigeCnh.AutoSize = true;
            this.cboxExigeCnh.Location = new System.Drawing.Point(299, 75);
            this.cboxExigeCnh.Name = "cboxExigeCnh";
            this.cboxExigeCnh.Size = new System.Drawing.Size(18, 17);
            this.cboxExigeCnh.TabIndex = 6;
            this.cboxExigeCnh.UseVisualStyleBackColor = true;
            // 
            // cboxGanhaComissao
            // 
            this.cboxGanhaComissao.AutoSize = true;
            this.cboxGanhaComissao.Location = new System.Drawing.Point(389, 74);
            this.cboxGanhaComissao.Name = "cboxGanhaComissao";
            this.cboxGanhaComissao.Size = new System.Drawing.Size(18, 17);
            this.cboxGanhaComissao.TabIndex = 8;
            this.cboxGanhaComissao.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(156, 70);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(107, 22);
            this.txtCargo.TabIndex = 4;
            // 
            // FrmCadCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.cboxGanhaComissao);
            this.Controls.Add(this.cboxExigeCnh);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.lblExigeCnh);
            this.Controls.Add(this.lblCargo);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmCadCargos";
            this.Text = "Cadastro de Cargos";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCadlbl, 0);
            this.Controls.SetChildIndex(this.lblUltAltlbl, 0);
            this.Controls.SetChildIndex(this.lblCodUsulbl, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.lblExigeCnh, 0);
            this.Controls.SetChildIndex(this.lblComissao, 0);
            this.Controls.SetChildIndex(this.cboxExigeCnh, 0);
            this.Controls.SetChildIndex(this.cboxGanhaComissao, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCargo;
        protected System.Windows.Forms.Label lblExigeCnh;
        protected System.Windows.Forms.CheckBox cboxExigeCnh;
        protected System.Windows.Forms.TextBox txtCargo;
        protected System.Windows.Forms.Label lblComissao;
        protected System.Windows.Forms.CheckBox cboxGanhaComissao;
    }
}
