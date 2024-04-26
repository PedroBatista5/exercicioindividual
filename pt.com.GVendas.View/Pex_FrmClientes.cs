using exercicioindividual.pt.com.Gvendas.DAO;
using exercicioindividual.pt.com.Gvendas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioindividual.pt.com.GVendas.View
{
    public partial class Form1 : Form
    {
        Clientes obj = new Clientes();
        DataTable dt = new DataTable();
        ClientesDAO dao = new ClientesDAO();

        public Form1()
        {
            InitializeComponent();
            PreencherDataGrid();
            dataGridView2.ReadOnly = true;
        }
        private void PreencherDataGrid()
        {
            dt = ClientesDAO.GetClientes();
            dataGridView2.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) //Inserir
        {

            obj.nome_clientes = txtNome.Text;
            obj.email_clientes = txtEmail.Text;
            obj.morada_clientes = txtMorada.Text;
            obj.estado_clientes = cb_cliente.Text;
            obj.telefone_clientes = txtTelefone.Text;
            obj.datainicio_clientes = dt_datainicio.Value;

            dao.CadastrarCliente(obj);

            MessageBox.Show("Dados inseridos com sucesso!");
            PreencherDataGrid();

            dt_datainicio.Value = DateTime.Now;
            txtNome.Text = "";
            cb_cliente.Text = "";
            txtEmail.Text = "";
            txtMorada.Text = "";
            txtTelefone.Text = "";

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Editar
        {

        }

        private void button9_Click(object sender, EventArgs e) //Deletar
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id_cliente = int.Parse(textBox26.Text);

            DataTable dtCliente = dao.PesquisarCliente(obj, id_cliente);

            dataGridView2.DataSource = dtCliente;


        }
    }
}
