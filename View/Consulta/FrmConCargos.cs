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
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCargos = (FrmCadCargos)obj;
        }

        public override void Incluir()
        {
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.ShowDialog();
            this.Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
            this.Pesquisar();
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
            this.Pesquisar();
        }

        public override void Pesquisar()
        {
            this.listV.Items.Clear();
            Cargos oCargoFiltro = new Cargos();
            oCargo.Cargo = txtCodigo.Text.Trim();
            foreach (Cargos cargo in oCtrlCargos.Pesquisar(oCargoFiltro))
            {
                AdicionarLinhaLV(cargo);
            }
        }

        private void AdicionarLinhaLV(Cargos cargo)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(cargo.Codigo.ToString());
            item.SubItems.Add(cargo.Cargo);
            item.SubItems.Add(cargo.ExigeCnh ? "Sim" : "Não");
            item.SubItems.Add(cargo.GanhaComissao ? "Sim" : "Não");
            item.Tag = cargo;
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
                Cargos oCargoSel = (Cargos)linha.Tag;
                oCargo.Codigo = oCargoSel.Codigo;
                oCargo.Cargo = oCargoSel.Cargo;
                oCargo.ExigeCnh = oCargoSel.ExigeCnh;
                oCargo.GanhaComissao = oCargoSel.GanhaComissao;
            }
        }
    }
}
