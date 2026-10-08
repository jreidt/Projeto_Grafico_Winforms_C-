using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.DAO
{
    internal class DaoEstados : Dao
    {
        protected SqlConnection cnn;
        public DaoEstados()
        {
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string ok = string.Empty, sql = string.Empty;
            if (oEstado.Codigo == 0)
            {
                sql = "insert into Estados(Estado, UF, ID_Pais) values (@estado, @uf, @id_paises)";
            }
            else
            {
                sql = "update Estados set Estado = @estado, UF = @uf, ID_Pais = @id_paises where ID_Estados = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.UF);
                cmd.Parameters.AddWithValue("@id_paises", oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
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
            Estados oEstado = (Estados)obj;
            string ok = string.Empty, sql = string.Empty;

            sql = "delete Estados where ID_Estados = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();
            }

            throw new NotImplementedException();
        }
    }
}
