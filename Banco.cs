using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO_2026
{
    internal class Banco
    {
        private static string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DOCUMENTOS JULIO\AULAS SISTEMAS\ELP\POOII\Grafico_2026_Julio-Eidt\BDGrafico_2026.mdf"";Integrated Security=True";

        public static SqlConnection AbrirBD()
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }
    }
}
