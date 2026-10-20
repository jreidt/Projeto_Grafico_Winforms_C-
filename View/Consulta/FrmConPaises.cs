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
            oPais.Pais = txtCodigo.Text.Trim().ToUpper();
            var listaResultado = new List<Paises>();
            foreach (var pais in oCtrlPaises.Pesquisar(oPais))
            {
                listaResultado.Add((Paises)pais);
            }

            foreach (Paises oPaisPesq in listaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(oPaisPesq.Codigo.ToString());
                item.SubItems.Add(oPaisPesq.Pais);
                item.SubItems.Add(oPaisPesq.Sigla);
                item.SubItems.Add(oPaisPesq.DDI);
                item.SubItems.Add(oPaisPesq.Moeda);
                listV.Items.Add(item);
            }
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
