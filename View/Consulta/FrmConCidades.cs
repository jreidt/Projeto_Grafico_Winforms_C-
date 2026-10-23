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
        private Cidades oCidade;
        private FrmCadCidades oFrmCadCidades;
        private CtrlCidades oCtrlCidades;
        public FrmConCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
            oCtrlCidades = (CtrlCidades)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCidades = (FrmCadCidades)obj;
        }

        public override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidade, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidade, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            this.Pesquisar();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "&Excluir";
            oFrmCadCidades.ConhecaObj(oCidade, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.btnSalvar.Text = aux;
            this.Pesquisar();
        }

        public override void Pesquisar()
        {
            this.listV.Items.Clear();
            Cidades oCidadeFiltro = new Cidades();
            oCidade.Cidade = txtCodigo.Text.Trim();
            foreach (Cidades cidade in oCtrlCidades.Pesquisar(oCidadeFiltro))
            {
                AdicionarLinhaLV(cidade);
            }
        }

        private void AdicionarLinhaLV(Cidades cidade)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(cidade.Codigo.ToString());
            item.SubItems.Add(cidade.Cidade);
            item.SubItems.Add(cidade.DDD);
            item.SubItems.Add(cidade.OEstado.Codigo.ToString());
            item.SubItems.Add(cidade.OEstado.Estado);
            item.SubItems.Add(cidade.OEstado.OPais.Codigo.ToString());
            item.SubItems.Add(cidade.OEstado.OPais.Pais);
            item.Tag = cidade;
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
            Sair();
        }

        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listV.SelectedItems.Count > 0)
            {
                ListViewItem linha = listV.SelectedItems[0];
                Cidades oCidadeSel = (Cidades)linha.Tag;
                oCidade.Codigo = oCidadeSel.Codigo;
                oCidade.Cidade = oCidadeSel.Cidade;
                oCidade.DDD = oCidadeSel.DDD;
                oCidade.OEstado.Codigo = oCidadeSel.OEstado.Codigo;
                oCidade.OEstado.Estado = oCidadeSel.OEstado.Estado;
                oCidade.OEstado.OPais.Codigo = oCidadeSel.OEstado.Codigo;
                oCidade.OEstado.OPais.Pais = oCidadeSel.OEstado.OPais.Pais;
            }
        }
    }
}
