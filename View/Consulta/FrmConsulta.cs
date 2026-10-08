using Grafico_2026_Julio_Eidt.Model;
using Grafico_2026_Julio_Eidt.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Julio_Eidt.View
{
    public partial class FrmConsulta : Grafico_2026_Julio_Eidt.View.FrmBase
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }

        public virtual void Incluir()
        {

        }

        public virtual void Alterar()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Pesquisar()
        {

        }

        public override void Sair()
        {
            Close();
        }

        public virtual void SetFrmCadastro(object obj)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
