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
            
        }
        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();

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
            cnn.Close();
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
            string sql = "Select C.ID_Cidades, C.Cidade, C.DDD, C.ID_Estado, E.Estado, E.ID_Pais, P.Pais from Cidades C inner join Estados E on C.ID_Estado = E.ID_Estados inner join Paises P on E.ID_Pais = P.ID_Paises";

            var lista = new List<object>();

            cnn = Banco.AbrirBD();

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cidades oCidade = new Cidades();
                        oCidade.Codigo = Convert.ToInt32(dr["ID_Cidades"]);
                        oCidade.Cidade = dr["Cidade"].ToString();
                        oCidade.DDD = dr["DDD"].ToString();
                        oCidade.OEstado.Codigo = Convert.ToInt32(dr["ID_Estado"]);
                        oCidade.OEstado.Estado = dr["Estado"].ToString();
                        oCidade.OEstado.OPais.Codigo = Convert.ToInt32(dr["ID_Pais"]);
                        oCidade.OEstado.OPais.Pais = dr["Pais"].ToString();
                        lista.Add(oCidade);
                    }
                }

            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }

        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();

            sql = "delete Cidades where ID_Cidades = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCidade.Codigo);
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
            throw new NotImplementedException();
        }
    }
}
