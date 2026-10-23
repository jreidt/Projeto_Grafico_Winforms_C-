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

        public override void Pesquisar()
        {
            this.listV.Items.Clear();
            Funcionarios oFuncionarioFiltro = new Funcionarios();
            oFuncionarioFiltro.Nome = txtCodigo.Text.Trim();
            foreach (Funcionarios funcionario in oCtrlFuncionarios.Pesquisar(oFuncionarioFiltro))
            {
                AdicionarLinhaLV(funcionario);
            }
        }

        private void AdicionarLinhaLV(Funcionarios funcionario)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(funcionario.Codigo.ToString());
            item.SubItems.Add(funcionario.Nome);
            item.SubItems.Add(funcionario.Idade.ToString());
            item.SubItems.Add(funcionario.Sexo.ToString());
            item.SubItems.Add(funcionario.Matricula);
            item.SubItems.Add(funcionario.Cpf);
            item.SubItems.Add(funcionario.NumDep.ToString());
            item.SubItems.Add(funcionario.SalBase.ToString("C2"));
            item.SubItems.Add(funcionario.Gratificacao.ToString("C2"));
            item.SubItems.Add(funcionario.OCargo.Codigo.ToString());
            item.SubItems.Add(funcionario.OCargo.Cargo);
            item.Tag = funcionario;
            listV.Items.Add(item);
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

        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listV.SelectedItems.Count > 0)
            {
                ListViewItem linha = listV.SelectedItems[0];
                Funcionarios oFuncionarioSel = (Funcionarios)linha.Tag;

                oFuncionario.Codigo = oFuncionarioSel.Codigo;
                oFuncionario.Nome = oFuncionarioSel.Nome;
                oFuncionario.Idade = oFuncionarioSel.Idade;
                oFuncionario.Sexo = oFuncionarioSel.Sexo;
                oFuncionario.Matricula = oFuncionarioSel.Matricula;
                oFuncionario.Cpf = oFuncionarioSel.Cpf;
                oFuncionario.NumDep = oFuncionarioSel.NumDep;
                oFuncionario.SalBase = oFuncionarioSel.SalBase;
                oFuncionario.Gratificacao = oFuncionarioSel.Gratificacao;
                oFuncionario.OCargo.Codigo = oFuncionarioSel.OCargo.Codigo;
                oFuncionario.OCargo.Cargo = oFuncionarioSel.OCargo.Cargo;

                // Endereço e Localização (como todo o objeto está na Tag, você já pode carregar tudo)
                oFuncionario.Logradouro = oFuncionarioSel.Logradouro;
                oFuncionario.Numero = oFuncionarioSel.Numero;
                oFuncionario.Complemento = oFuncionarioSel.Complemento;
                oFuncionario.Bairro = oFuncionarioSel.Bairro;
                oFuncionario.Cep = oFuncionarioSel.Cep;
                oFuncionario.OCidade.Codigo = oFuncionarioSel.OCidade.Codigo;
                oFuncionario.OCidade.Cidade = oFuncionarioSel.OCidade.Cidade;
                oFuncionario.OCidade.OEstado.Codigo = oFuncionarioSel.OCidade.OEstado.Codigo;
                oFuncionario.OCidade.OEstado.Estado = oFuncionarioSel.OCidade.OEstado.Estado;
                oFuncionario.OCidade.OEstado.OPais.Codigo = oFuncionarioSel.OCidade.OEstado.OPais.Codigo;
                oFuncionario.OCidade.OEstado.OPais.Pais = oFuncionarioSel.OCidade.OEstado.OPais.Pais;
            }
        }
    }
}
