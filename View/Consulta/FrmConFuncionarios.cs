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
    public partial class FrmConFuncionarios : Grafico_2026_Julio_Eidt.View.FrmConsulta
    {

        private Funcionarios oFuncionario;
        private FrmCadFuncionarios oFrmCadFuncionarios;
        private CtrlFuncionarios oCtrlFuncionarios;
        public FrmConFuncionarios()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oFuncionario = (Funcionarios)obj;
            oCtrlFuncionarios = (CtrlFuncionarios)ctrl;
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadFuncionarios = (FrmCadFuncionarios)obj;
        }

        public override void Pesquisar()
        {
            
        }

        public override void Incluir()
        {
            oFrmCadFuncionarios.ConhecaObj(oFuncionario, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadFuncionarios.ConhecaObj(oFuncionario, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadFuncionarios.btnSalvar.Text;
            oFrmCadFuncionarios.btnSalvar.Text = "&Excluir";
            oFrmCadFuncionarios.ConhecaObj(oFuncionario, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.BloquearTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            oFrmCadFuncionarios.DesbloquearTxt();
            oFrmCadFuncionarios.btnSalvar.Text = aux;
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
