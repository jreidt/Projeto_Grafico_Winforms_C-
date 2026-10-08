using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
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
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string ok = string.Empty, sql = string.Empty;
            if (oCargo.Codigo == 0)
            {
                sql = "insert into Cargos(Cargo, Exige_CNH, Ganha_Comissao) values (@cargo, @exige_cnh, @ganha_comissao)";
            }
            else
            {
                sql = "update Cargos set Cargo = @cargo, Exige_CNH = @exige_cnh, Ganha_Comissao = @ganha_comissao where ID_Cargos = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@cargo", oCargo.Cargo);
                cmd.Parameters.AddWithValue("@exige_cnh", oCargo.ExigeCnh);
                cmd.Parameters.AddWithValue("@ganha_comissao", oCargo.GanhaComissao);
                cmd.Parameters.AddWithValue("@codigo", oCargo.Codigo);
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
            Cargos oCargo = (Cargos)obj;
            string ok = string.Empty, sql = string.Empty;

            sql = "delete Cargos where ID_Cargos = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCargo.Codigo);
                cmd.ExecuteNonQuery();
            }

            throw new NotImplementedException();
        }
    }
}
