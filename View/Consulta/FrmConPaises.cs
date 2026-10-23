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
    public partial class FrmConPaises : Grafico_2026_Julio_Eidt.View.FrmConsulta
    {
        private Paises oPais;
        private FrmCadPaises oFrmCadPaises;
        private CtrlPaises oCtrlPaises;
        public FrmConPaises()
        {
            InitializeComponent();
        }

        private void FrmConPaises_Load(object sender, EventArgs e)
        {

        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            oCtrlPaises = (CtrlPaises)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.Pesquisar();
        }   

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "&Excluir";
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.BloquearTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.btnSalvar.Text = aux;
            oFrmCadPaises.DesbloquearTxt();
            this.Pesquisar();
        }

        public override void Pesquisar()
        {
            this.listV.Items.Clear();
            Paises oPaisFiltro = new Paises();
            oPais.Pais = txtCodigo.Text.Trim();
            foreach (Paises pais in oCtrlPaises.Pesquisar(oPaisFiltro))
            {
                AdicionarLinhaLV(pais);
            }
        }

        private void AdicionarLinhaLV(Paises pais)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(pais.Codigo.ToString());
            item.SubItems.Add(pais.Pais);
            item.SubItems.Add(pais.Sigla);
            item.SubItems.Add(pais.DDI);
            item.SubItems.Add(pais.Moeda);
            item.Tag = pais;
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
                Paises oPaisSel = (Paises)linha.Tag;
                oPais.Codigo = oPaisSel.Codigo;
                oPais.Pais = oPaisSel.Pais;
                oPais.Sigla = oPaisSel.Sigla;
                oPais.DDI = oPaisSel.DDI;
                oPais.Moeda = oPaisSel.Moeda;
            }
        }
    }
}
