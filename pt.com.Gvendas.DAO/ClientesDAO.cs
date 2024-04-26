using exercicioindividual.pt.com.Gvendas.CONEXAO.pt.com.GVendas2023.CONEXAO;
using exercicioindividual.pt.com.Gvendas.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioindividual.pt.com.Gvendas.DAO
{
    internal class ClientesDAO
    {

        public static DataTable GetClientes() // Função para exibir todos os dados da tabela Interessados
        {
            var dt = new DataTable(); // Cria uma nova datatable 

            var query = "SELECT * FROM basededados_individual.tb_clientes"; // Comando do MYSQL para selecionar todos os itens da tabela interessados

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlDataAdapter(query, ligabd))
                    {
                        ligacao.Fill(dt); // Preenche a variavel dt com todos os valores selecionados através do comando do MYSQL (query)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Messagem de Erro
            }

            return dt; // Retorna a datatable
        }

        public void CadastrarCliente (Clientes obj)
        {

            string sql = @"INSERT INTO basededados_individual.tb_clientes(estado_clientes,
                nome_clientes, email_clientes, telefone_clientes, morada_clientes, datainicio_clientes )
                values (@estado_clientes,
                @nome_clientes, @email_clientes, @telefone_clientes, @morada_clientes, @datainicio_clientes )";
            
            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {

                        ligacao.Parameters.AddWithValue("@estado_clientes", obj.estado_clientes);
                        ligacao.Parameters.AddWithValue("@nome_clientes", obj.nome_clientes);
                        ligacao.Parameters.AddWithValue("@email_clientes", obj.email_clientes);
                        ligacao.Parameters.AddWithValue("@telefone_clientes", obj.telefone_clientes);
                        ligacao.Parameters.AddWithValue("@morada_clientes", obj.morada_clientes);
                        ligacao.Parameters.AddWithValue("@datainicio_clientes", obj.datainicio_clientes);
                        ligacao.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarCliente (Clientes obj, int id)
        {
            string sql = "SELECT * FROM basededados_individual.tb_clientes WHERE id_clientes= '" + id + "'";
            DataTable dt = new DataTable();
            try
            {
                using (var ligabd = new MySqlConnection(conexao.strligar))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(ligacao))
                        {
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

    }


}


