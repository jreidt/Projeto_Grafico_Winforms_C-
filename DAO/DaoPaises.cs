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
    internal class DaoPaises : Dao
    {
        protected SqlConnection cnn;
        public DaoPaises()
        {
            
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oPais.Codigo == 0)
                    {
                        const string sql = "insert into Paises(Pais, Sigla, DDI , Moeda) output inserted.ID_Paises values (@pais, @sigla, @ddi, @moeda)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oPais, cmd);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql = "update Paises set Pais = @pais, Sigla = @sigla, DDI = @ddi, Moeda = @moeda where ID_Paises = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oPais, cmd);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oPais.Codigo;
                        }
                    }
                    tx.Commit();
                    oPais.Codigo = codigo;
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
            Paises oPais = (Paises)obj;

            const string sql = "Select ID_Paises, Pais, Sigla, DDI, Moeda from Paises WHERE ID_Paises = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Código de Pais não Encontrado";
                        oPais.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Paises"));
                        oPais.Pais = dr.GetString(dr.GetOrdinal("Pais"));
                        oPais.Sigla = dr.GetString(dr.GetOrdinal("Sigla"));
                        oPais.DDI = dr.GetString(dr.GetOrdinal("DDI"));
                        oPais.Moeda = dr.GetString(dr.GetOrdinal("Moeda"));
                    }
                }
                return "";
            }
            catch (SqlException ex)
            {
                return "Erro de bando de dados" + ex.Message;
            }
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
                const string sql = "Select ID_Paises, Pais, Sigla, DDI, Moeda from Paises";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Paises oPais = new Paises();
                        oPais.Codigo = Convert.ToInt32(dr["ID_Paises"]);
                        oPais.Pais = dr["Pais"].ToString();
                        oPais.Sigla = dr["Sigla"].ToString();
                        oPais.DDI = dr["DDI"].ToString();
                        oPais.Moeda = dr["Moeda"].ToString();
                        lista.Add(oPais);
                    }
                }
            }

            return lista;
        }

        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "delete from Paises where ID_Paises = @codigo";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new InvalidOperationException("Nenhum registro foi excluído.");
                        }
                    }
                    tx.Commit();
                    return oPais.Codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdiconarParametros(Paises oPais, SqlCommand cmd)
        {
            cmd.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = oPais.Pais;
            cmd.Parameters.Add("@sigla", SqlDbType.VarChar, 3).Value = oPais.Sigla;
            cmd.Parameters.Add("@ddi", SqlDbType.VarChar, 5).Value = oPais.DDI;
            cmd.Parameters.Add("@moeda", SqlDbType.VarChar, 5).Value = oPais.Moeda;
        }
    }
}
