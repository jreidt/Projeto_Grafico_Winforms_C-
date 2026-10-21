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
    internal class DaoCidades : Dao
    {
        protected SqlConnection cnn;
        public DaoCidades()
        {

        }

        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCidade.Codigo == 0)
                    {
                        const string sql = "insert into Cidades(Cidade, DDD, ID_Estado) output inserted.ID_Cidades values (@cidade, @ddd, @id_estado)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oCidade, cmd);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql = "update Cidades set Cidade = @cidade, DDD = @ddd, ID_Estado = @id_estado where ID_Cidades = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oCidade, cmd);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oCidade.Codigo;
                        }
                    }
                    tx.Commit();
                    oCidade.Codigo = codigo;
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
                const string sql = "Select C.ID_Cidades, C.Cidade, C.DDD, C.ID_Estado, E.Estado, E.ID_Pais, P.Pais from Cidades C inner join Estados E on C.ID_Estado = E.ID_Estados inner join Paises P on E.ID_Pais = P.ID_Paises";

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

            return lista;
        }

        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "delete from Cidades where ID_Cidades = @codigo";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new InvalidOperationException("Nenhum registro foi excluído.");
                        }
                    }
                    tx.Commit();
                    return oCidade.Codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdiconarParametros(Cidades oCidade, SqlCommand cmd)
        {
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar, 100).Value = oCidade.Cidade;
            cmd.Parameters.Add("@ddd", SqlDbType.VarChar, 5).Value = oCidade.DDD;
            cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = oCidade.OEstado.Codigo;
        }
    }
}
