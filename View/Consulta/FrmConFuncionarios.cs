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
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadFuncionarios = (FrmCadFuncionarios)obj;
        }

        public override void Pesquisar()
        {
            this.listV.Items.Clear();
            oFuncionario.Nome = txtCodigo.Text.Trim().ToUpper();
            var listaResultado = new List<Funcionarios>();
            foreach (var funcionario in oCtrlFuncionarios.Pesquisar(oFuncionario))
            {
                listaResultado.Add((Funcionarios)funcionario);
            }

            foreach (Funcionarios oFuncionarioPesq in listaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(oFuncionarioPesq.Codigo.ToString());
                item.SubItems.Add(oFuncionarioPesq.Nome);
                item.SubItems.Add(oFuncionarioPesq.Idade.ToString());
                item.SubItems.Add(oFuncionarioPesq.Sexo.ToString());
                item.SubItems.Add(oFuncionarioPesq.Matricula);
                item.SubItems.Add(oFuncionarioPesq.Cpf);
                item.SubItems.Add(oFuncionarioPesq.NumDep.ToString());
                item.SubItems.Add(oFuncionarioPesq.SalBase.ToString("C2"));
                item.SubItems.Add(oFuncionarioPesq.Gratificacao.ToString("C2"));
                item.SubItems.Add(oFuncionarioPesq.OCargo.Codigo.ToString());
                item.SubItems.Add(oFuncionarioPesq.OCargo.Cargo);
                listV.Items.Add(item);
            }
        }

        public override void Incluir()
        {
            oFrmCadFuncionarios.ConhecaObj(oFuncionario, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadFuncionarios.ConhecaObj(oFuncionario, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            this.Pesquisar();
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
            this.Pesquisar();
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
