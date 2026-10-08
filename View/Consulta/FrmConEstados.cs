using Grafico_2026_Julio_Eidt.Controller;
using Grafico_2026_Julio_Eidt.Model;
using Grafico_2026_Julio_Eidt.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Julio_Eidt.View.Consulta
{
    public partial class FrmConEstados : Grafico_2026_Julio_Eidt.View.FrmConsulta
    {
        private Estados oEstado;
        private FrmCadEstados oFrmCadEstados;
        private CtrlEstados oCtrlEstados;
        public FrmConEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            oCtrlEstados = (CtrlEstados)ctrl;
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadEstados = (FrmCadEstados)obj;
        }

        public override void Pesquisar()
        {
         
        }

        public override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "&Excluir";
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.BloquearTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
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

        }
    }
}
