using Grafico_2026_Julio_Eidt.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.Controller
{
    internal class CtrlEstados : Controller
    {
        protected CtrlPaises oCtrlPaises;
        protected DaoEstados oDaoEstados;

        public CtrlEstados()
        {
            oCtrlPaises = new CtrlPaises();
            oDaoEstados = new DaoEstados();
        }

        public override string Salvar(object obj)
        {
            return oDaoEstados.Salvar(obj);
        }

        public override string CarregarObj(object obj)
        {
            return null;
        }

        public override List<object> CarregarColecao(object obj)
        {
            return null;
        }

        public override List<object> Pesquisar(object obj)
        {
            return null;
        }

        public override string Excluir(object obj)
        {
            return oDaoEstados.Excluir(obj);
        }

        public CtrlPaises OCtrlPaises
        {
            get => oCtrlPaises;
            set => oCtrlPaises = value;
        }

        public DaoEstados ODaoEstados
        {
            get => oDaoEstados;
            set => oDaoEstados = value;
        }
    }
}
