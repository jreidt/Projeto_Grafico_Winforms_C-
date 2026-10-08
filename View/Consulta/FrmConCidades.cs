using Grafico_2026_Julio_Eidt.Controller;
using Grafico_2026_Julio_Eidt.Model;
using Grafico_2026_Julio_Eidt.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    public partial class FrmConCidades : Grafico_2026_Julio_Eidt.View.FrmConsulta
    {
        private Cidades oCidades;
        private FrmCadCidades oFrmCadCidades;
        private CtrlCidades oCtrlCidades;
        public FrmConCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCidades = (Cidades)obj;
            oCtrlCidades = (CtrlCidades)ctrl;
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCidades = (FrmCadCidades)obj;
        }

        public override void Pesquisar()
        {
            
        }

        public override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "&Excluir";
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.btnSalvar.Text = aux;
            Sair();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void brnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
