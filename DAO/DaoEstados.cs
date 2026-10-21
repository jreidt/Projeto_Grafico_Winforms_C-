using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oEstado.Codigo == 0)
                    {
                        const string sql = "insert into Estados(Estado, UF, ID_Pais) output inserted.ID_Estados values (@estado, @uf, @id_paises)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oEstado, cmd);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql = "update Estados set Estado = @estado, UF = @uf, ID_Pais = @id_paises where ID_Estados = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oEstado, cmd);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oEstado.Codigo;
                        }
                    }
                    tx.Commit();
                    oEstado.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
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
            var lista = new List<object>();

            using (cnn = Banco.AbrirBD())
            {
                const string sql = "Select E.ID_Estados, E.Estado, E.UF, E.ID_Pais, P.Pais from Estados E inner join Paises P on E.ID_Pais = P.ID_Paises";

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

            return lista;
        }

        public override string Excluir(object obj)
        {
            Estados oEstado = (Estados)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "delete from Estados where ID_Estados = @codigo";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new InvalidOperationException("Nenhum registro foi excluído.");
                        }
                    }
                    tx.Commit();
                    return oEstado.Codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdiconarParametros(Estados oEstado, SqlCommand cmd)
        {
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = oEstado.Estado;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar, 2).Value = oEstado.UF;
            cmd.Parameters.Add("@id_paises", SqlDbType.Int).Value = oEstado.OPais.Codigo;
        }
    }
}
