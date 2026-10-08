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
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string ok = string.Empty, sql = string.Empty;
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
            Funcionarios oFuncionario = (Funcionarios)obj;
            string ok = string.Empty, sql = string.Empty;

            sql = "delete Funcionarios where ID_Funcionarios = @codigo";

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oFuncionario.Codigo);
                cmd.ExecuteNonQuery();
            }

            throw new NotImplementedException();
        }
    }
}
