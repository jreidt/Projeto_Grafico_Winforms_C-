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
    public partial class FrmConCargos : Grafico_2026_Julio_Eidt.View.FrmConsulta
    {

        private Cargos oCargo;
        private FrmCadCargos oFrmCadCargos;
        private CtrlCargos oCtrlCargos;
        public FrmConCargos()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCargo = (Cargos)obj;
            oCtrlCargos = (CtrlCargos)ctrl;
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCargos = (FrmCadCargos)obj;
        }

        public override void Pesquisar()
        {
            
        }

        public override void Incluir()
        {
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCargos.btnSalvar.Text;
            oFrmCadCargos.btnSalvar.Text = "&Excluir";
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.BloquearTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
            oFrmCadCargos.DesbloquearTxt();
            oFrmCadCargos.btnSalvar.Text = aux;
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
