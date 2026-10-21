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
    internal class DaoCargos : Dao
    {
        protected SqlConnection cnn;
        public DaoCargos()
        {

        }

        public override string Salvar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCargo.Codigo == 0)
                    {
                        const string sql = "insert into Cargos(Cargo, Exige_CNH, Ganha_Comissao) output inserted.ID_Cargos values (@cargo, @exige_cnh, @ganha_comissao)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oCargo, cmd);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql = "update Cargos set Cargo = @cargo, Exige_CNH = @exige_cnh, Ganha_Comissao = @ganha_comissao where ID_Cargos = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oCargo, cmd);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oCargo.Codigo;
                        }
                    }
                    tx.Commit();
                    oCargo.Codigo = codigo;
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
                const string sql = "Select ID_Cargos, Cargo, Exige_CNH, Ganha_Comissao from Cargos";

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cargos oCargo = new Cargos();
                        oCargo.Codigo = Convert.ToInt32(dr["ID_Cargos"]);
                        oCargo.Cargo = dr["Cargo"].ToString();
                        oCargo.ExigeCnh = Convert.ToBoolean(dr["Exige_CNH"]);
                        oCargo.GanhaComissao = Convert.ToBoolean(dr["Ganha_Comissao"]);
                        lista.Add(oCargo);
                    }
                }
            }

            return lista;
        }

        public override string Excluir(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "delete from Cargos where ID_Cargos = @codigo";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new InvalidOperationException("Nenhum registro foi excluído.");
                        }
                    }
                    tx.Commit();
                    return oCargo.Codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdiconarParametros(Cargos oCargo, SqlCommand cmd)
        {
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 100).Value = oCargo.Cargo;
            cmd.Parameters.Add("@exige_cnh", SqlDbType.Bit).Value = oCargo.ExigeCnh;
            cmd.Parameters.Add("@ganha_comissao", SqlDbType.Bit).Value = oCargo.GanhaComissao;
        }
    }
}
