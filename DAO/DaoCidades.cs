using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.DAO
{
    internal class DaoCidades : Dao
    {
        protected SqlConnection cnn;
        public DaoCidades()
        {
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string ok = string.Empty, sql = string.Empty;
            if (oCidade.Codigo == 0)
            {
                sql = "insert into Cidades(Cidade, DDD, ID_Estado) values (@cidade, @ddd, @id_estado)";
            }
            else
            {
                sql = "update Cidades set Cidade = @cidade, DDD = @ddd, ID_Estado = @id_estado where ID_Cidades = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@cidade", oCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", oCidade.DDD);
                cmd.Parameters.AddWithValue("@id_estado", oCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@codigo", oCidade.Codigo);
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
            Cidades oCidade = (Cidades)obj;
            string ok = string.Empty, sql = string.Empty;

            sql = "delete Cidades where ID_Cidades = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCidade.Codigo);
                cmd.ExecuteNonQuery();
            }

            throw new NotImplementedException();
        }
    }
}
