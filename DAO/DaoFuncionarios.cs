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
    internal class DaoFuncionarios : Dao
    {
        protected SqlConnection cnn;
        public DaoFuncionarios()
        {

        }

        public override string Salvar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oFuncionario.Codigo == 0)
                    {
                        const string sql = "insert into Funcionarios(Matricula, Nome, CPF, Idade, Sexo, Numero_Dependentes, Numero_CNH, Tipo_CNH, Data_Validade_CNH, SalarioBase, Gratificacao, ID_Cargo, ID_Cidade, Logradouro, Numero, Complemento, Bairro, CEP) output inserted.ID_Funcionarios values (@matricula, @nome, @cpf, @idade, @sexo, @numero_dependentes, @numero_cnh, @tipo_cnh, @data_validade_cnh, @salario_base, @gratificacao, @id_cargo, @id_cidade, @logradouro, @numero, @complemento, @bairro, @cep)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oFuncionario, cmd);
                            codigo = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        const string sql = "update Funcionarios set Matricula = @matricula, Nome = @nome, CPF = @cpf, Idade = @idade, Sexo = @sexo, Numero_Dependentes = @numero_dependentes, Numero_CNH = @numero_cnh, Tipo_CNH = @tipo_cnh, Data_Validade_CNH = @data_validade_cnh, SalarioBase = @salario_base, Gratificacao = @gratificacao, ID_Cargo = @id_cargo, ID_Cidade = @id_cidade, Logradouro = @logradouro, Numero = @numero, Complemento = @complemento, Bairro = @bairro, CEP = @cep where ID_Funcionarios = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdiconarParametros(oFuncionario, cmd);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oFuncionario.Codigo;
                        }
                    }
                    tx.Commit();
                    oFuncionario.Codigo = codigo;
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
                const string sql = "Select F.ID_Funcionarios, F.Nome, F.Idade, F.Sexo, F.Matricula, F.CPF, F.Numero_Dependentes, F.SalarioBase, F.Gratificacao, F.ID_Cargo, C.Cargo from Funcionarios F inner join Cargos C on F.ID_Cargo = C.ID_Cargos";

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

            return lista;
        }

        public override string Excluir(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            using (cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "delete from Funcionarios where ID_Funcionarios = @codigo";
                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new InvalidOperationException("Nenhum registro foi excluído.");
                        }
                    }
                    tx.Commit();
                    return oFuncionario.Codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdiconarParametros(Funcionarios oFuncionario, SqlCommand cmd)
        {
            cmd.Parameters.Add("@matricula", SqlDbType.VarChar, 20).Value = oFuncionario.Matricula;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 100).Value = oFuncionario.Nome;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 14).Value = oFuncionario.Cpf;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = oFuncionario.Idade;
            cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = oFuncionario.Sexo;
            cmd.Parameters.Add("@numero_dependentes", SqlDbType.Int).Value = oFuncionario.NumDep;
            cmd.Parameters.Add("@numero_cnh", SqlDbType.VarChar, 20).Value = oFuncionario.Cnh;
            cmd.Parameters.Add("@tipo_cnh", SqlDbType.VarChar, 5).Value = oFuncionario.TipoCnh;
            cmd.Parameters.Add("@data_validade_cnh", SqlDbType.DateTime).Value = oFuncionario.DataValidadeCnh;
            cmd.Parameters.Add("@salario_base", SqlDbType.Float).Value = oFuncionario.SalBase;
            cmd.Parameters.Add("@gratificacao", SqlDbType.Float).Value = oFuncionario.Gratificacao;
            cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = oFuncionario.OCargo.Codigo;
            cmd.Parameters.Add("@id_cidade", SqlDbType.Int).Value = oFuncionario.OCidade.Codigo;
            cmd.Parameters.Add("@logradouro", SqlDbType.VarChar, 100).Value = oFuncionario.Logradouro;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar, 10).Value = oFuncionario.Numero;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar, 50).Value = oFuncionario.Complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar, 50).Value = oFuncionario.Bairro;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar, 10).Value = oFuncionario.Cep;
        }
    }
}
