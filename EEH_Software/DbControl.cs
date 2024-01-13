using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EEH_Software
{
    public partial class DbControl : Form
    {
        public DbControl()
        {
            InitializeComponent();
        }

        private void AcessoBD_Click(object sender, EventArgs e)
        {
            try
            {
                //ligar base de dados
                SqlConnection ligacao = new SqlConnection();
                ligacao.ConnectionString = $@"Server=DESKTOP-VK287J3\SQLEXPRESS;Database={textBD.Text};User=admin;Password=123456";
                ligacao.Open();

                //Recolha de Dados
                //recolhe para a estrutura, como se fosse replicar uma tabela dentro do server sql
                DataTable data = new DataTable();

                //Responvel por receber ordens, enviar dados, receber dados, responsavel pela comunicação com a base de dados
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Cliente", ligacao);
                //preenche a tabela
                adapter.Fill(data);

                //desliga ligação com a bd 
                ligacao.Close();

                //apresentar resultados da tabela lida
                //MessageBox.Show(data.Rows[0]["CP"].ToString());

                Listagem_Clientes.Items.Clear();
                foreach (DataRow linha in data.Rows)
                {
                    Listagem_Clientes.Items.Add(linha["ClienteID"].ToString() + " - " +
                                         linha["Nome"].ToString() + " - " +
                                         linha["NIF"].ToString() + " - " +
                                         linha["Contacto"].ToString() + " - " +
                                         linha["CP"].ToString() + " - " +
                                         linha["PartesEnvolvidasPartesId"].ToString() + " - " +
                                         linha["Morada"].ToString()
                                         );
                }

                //Conta a quantidade de linhas da tabela
                //label_result.Text = data.Rows.Count.ToString();

                //testar com market point -> int v = 0;


            }
            catch (SqlException erro)
            {
                Listagem_Clientes.Items.Clear();
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados \n" + erro);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            textBox1.Text = "Base de Dados:";
            textBoxNome(sender, e);
            */
        }

        private void textBD_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Torne o TextBox somente leitura 
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListaDados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Botões de Acesso
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Criar uma instância do formulário DbControl
            Adicionar formDbRegister = new Adicionar();

            // Exibir o formulário DbControl
            formDbRegister.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar formDbAlterar = new Alterar();
            formDbAlterar.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover fromDbRemover = new Remover();
            fromDbRemover.Show();
        }
    }
}

