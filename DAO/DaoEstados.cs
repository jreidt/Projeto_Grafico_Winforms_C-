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
            
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();
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
            string sql = "Select E.ID_Estados, E.Estado, E.UF, E.ID_Pais, P.Pais from Estados E inner join Paises P on E.ID_Pais = P.ID_Paises";

            var lista = new List<object>();

            cnn = Banco.AbrirBD();

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estados oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(dr["ID_Estados"]);
                        oEstado.Estado = dr["Estado"].ToString();
                        oEstado.UF = dr["UF"].ToString();
                        oEstado.OPais.Codigo = Convert.ToInt32(dr["ID_Pais"]);
                        oEstado.OPais.Pais = dr["Pais"].ToString();
                        lista.Add(oEstado);
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
            Estados oEstado = (Estados)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();

            sql = "delete Estados where ID_Estados = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();
            }

            cnn.Close();
            throw new NotImplementedException();
        }
    }
}
