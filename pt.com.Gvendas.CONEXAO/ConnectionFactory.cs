using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioindividual.pt.com.Gvendas.CONEXAO
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using MySql.Data.MySqlClient;
    namespace pt.com.GVendas2023.CONEXAO
    {
        internal class conexao
        {
            private const string servidor = "localhost"; //Servidor do MYSQL WorkBench
            private const string basedados = "basededados_individual"; //Nome do esquema
            private const string utilizador = "root"; //Nome do utilizador (Predefenição)
            private const string pass = ""; //Palavra passe da conexão

            static public string strligar = $"server={servidor}; User ID={utilizador}; database={basedados}; password={pass}";
        }
    }
}
