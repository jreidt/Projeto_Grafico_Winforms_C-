using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.DAO
{
    internal class DaoPaises : Dao
    {
        protected SqlConnection cnn;
        public DaoPaises()
        {
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string ok = string.Empty, sql = string.Empty;
            if(oPais.Codigo == 0)
            {
                sql = "insert into Paises(Pais, Sigla, DDI , Moeda) values (@pais, @sigla, @ddi, @moeda)";
            }
            else
            {
                sql = "update Paises set Pais = @pais, Sigla = @sigla, DDI = @ddi, Moeda = @moeda where ID_Paises = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.DDI);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@IDENTITY";
                ok = cmd.ExecuteScalar().ToString();
            }
            return ok;
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
            Paises oPais = (Paises)obj;
            string ok = string.Empty, sql = string.Empty;

            sql = "delete Paises where ID_Paises = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            { 
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
            }
            
            throw new NotImplementedException();
        }
    }
}
