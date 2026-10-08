using Grafico_2026_Julio_Eidt.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.Controller
{
    internal class CtrlPaises: Controller
    {
        protected DaoPaises oDaoPaises;
        public CtrlPaises()
        {
            oDaoPaises = new DaoPaises();
        }

        public override string Salvar(object obj)
        {
            return oDaoPaises.Salvar(obj);
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
            return oDaoPaises.Excluir(obj);
        }

        public DaoPaises ODaoPaises
        {
            get => oDaoPaises;
            set => oDaoPaises = value;
        }
    }
}
