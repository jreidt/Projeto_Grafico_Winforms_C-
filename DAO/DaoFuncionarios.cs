using Grafico_2026_Julio_Eidt.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Julio_Eidt.DAO
{
    internal class DaoFuncionarios : Dao
    {
        protected SqlConnection cnn;
        public DaoFuncionarios()
        {
            
        }
        public override string Salvar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();
            if (oFuncionario.Codigo == 0)
            {
                sql = "insert into Funcionarios(Matricula, Nome, CPF, Idade, Sexo, Numero_Dependentes, Numero_CNH, Tipo_CNH, Data_Validade_CNH, SalarioBase, Gratificacao, ID_Cargo, ID_Cidade, Logradouro, Numero, Complemento, Bairro, CEP) values (@matricula, @nome, @cpf, @idade, @sexo, @numero_dependentes, @numero_cnh, @tipo_cnh, @data_validade_cnh, @salario_base, @gratificacao, @id_cargo, @id_cidade, @logradouro, @numero, @complemento, @bairro, @cep)";
            }
            else
            {
                sql = "update Funcionarios set Matricula = @matricula, Nome = @nome, CPF = @cpf, Idade = @idade, Sexo = @sexo, Numero_Dependentes = @numero_dependentes, Numero_CNH = @numero_cnh, Tipo_CNH = @tipo_cnh, Data_Validade_CNH = @data_validade_cnh, SalarioBase = @salario_base, Gratificacao = @gratificacao, ID_Cargo = @id_cargo, ID_Cidade = @id_cidade, Logradouro = @logradouro, Numero = @numero, Complemento = @complemento, Bairro = @bairro, CEP = @cep where ID_Funcionarios = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@matricula", oFuncionario.Matricula);
                cmd.Parameters.AddWithValue("@nome", oFuncionario.Nome);
                cmd.Parameters.AddWithValue("@cpf", oFuncionario.Cpf);
                cmd.Parameters.AddWithValue("@idade", oFuncionario.Idade);
                cmd.Parameters.AddWithValue("@sexo", oFuncionario.Sexo);
                cmd.Parameters.AddWithValue("@numero_dependentes", oFuncionario.NumDep);
                cmd.Parameters.AddWithValue("@numero_cnh", oFuncionario.Cnh);
                cmd.Parameters.AddWithValue("@tipo_cnh", oFuncionario.TipoCnh);
                cmd.Parameters.AddWithValue("@data_validade_cnh", oFuncionario.DataValidadeCnh);
                cmd.Parameters.AddWithValue("@salario_base", oFuncionario.SalBase);
                cmd.Parameters.AddWithValue("@gratificacao", oFuncionario.Gratificacao);
                cmd.Parameters.AddWithValue("@id_cargo", oFuncionario.OCargo.Codigo);
                cmd.Parameters.AddWithValue("@id_cidade", oFuncionario.OCidade.Codigo);
                cmd.Parameters.AddWithValue("@logradouro", oFuncionario.Logradouro);
                cmd.Parameters.AddWithValue("@numero", oFuncionario.Numero);
                cmd.Parameters.AddWithValue("@complemento", oFuncionario.Complemento);
                cmd.Parameters.AddWithValue("@bairro", oFuncionario.Bairro);
                cmd.Parameters.AddWithValue("@cep", oFuncionario.Cep);
                cmd.Parameters.AddWithValue("@codigo", oFuncionario.Codigo);
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
            string sql = "Select F.ID_Funcionarios, F.Nome, F.Idade, F.Sexo, F.Matricula, F.CPF, F.Numero_Dependentes, F.SalarioBase, F.Gratificacao, F.ID_Cargo, C.Cargo from Funcionarios F inner join Cargos C on F.ID_Cargo = C.ID_Cargos";

            var lista = new List<object>();

            cnn = Banco.AbrirBD();

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionarios oFuncionario = new Funcionarios();
                        oFuncionario.Codigo = Convert.ToInt32(dr["ID_Funcionarios"]);
                        oFuncionario.Nome = dr["Nome"].ToString();
                        oFuncionario.Idade = Convert.ToInt32(dr["Idade"]);
                        oFuncionario.Sexo = Char.ToUpper(dr["Sexo"].ToString()[0]);
                        oFuncionario.Matricula = dr["Matricula"].ToString();
                        oFuncionario.Cpf = dr["CPF"].ToString();
                        oFuncionario.NumDep = Convert.ToInt32(dr["Numero_Dependentes"]);
                        oFuncionario.SalBase = Convert.ToDouble(dr["SalarioBase"]);
                        oFuncionario.Gratificacao = Convert.ToDouble(dr["Gratificacao"]);
                        oFuncionario.OCargo.Codigo = Convert.ToInt32(dr["ID_Cargo"]);
                        oFuncionario.OCargo.Cargo = dr["Cargo"].ToString();
                        lista.Add(oFuncionario);
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
            Funcionarios oFuncionario = (Funcionarios)obj;
            string ok = string.Empty, sql = string.Empty;
            cnn = Banco.AbrirBD();

            sql = "delete Funcionarios where ID_Funcionarios = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oFuncionario.Codigo);
                cmd.ExecuteNonQuery();
            }

            cnn.Close();
            throw new NotImplementedException();
        }
    }
}
