using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.Model
{
    internal class Estados : Pai
    {
        protected string estado;
        protected string uf;
        protected Paises oPais;

        public Estados():base()
        {
            this.estado = string.Empty;
            this.uf = string.Empty;
            this.oPais = new Paises();
        }

        public Estados(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string estado, string uf, Paises oPais) : base(codigo, codigoUsuario, dataCadastro, dataAlteracao)
        {
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais.Clone();
        }

        public Estados Clone()
        {
            return new Estados(codigo, codigoUsuario, dataCadastro, dataAlteracao, estado, uf, oPais.Clone());
        }

        public string Estado
        {
            get => estado;
            set => estado = value.ToUpper();
        }

        public string UF
        {
            get => uf;
            set => uf = value.ToUpper();
        }

        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }

    }
}
