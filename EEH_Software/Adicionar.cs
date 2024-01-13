using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EEH_Software
{
    public partial class Adicionar : Form
    {
        private TextBox textBoxCP;
        private TextBox textBoxNIF;
        private TextBox textBoxMorada;
        private TextBox textBoxContacto;
        private TextBox textBoxPE;
        private Button button1;
        private TextBox LocalBD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNome;

        public Adicionar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxPE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LocalBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNome.Location = new System.Drawing.Point(12, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(149, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCP.Location = new System.Drawing.Point(167, 45);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(78, 20);
            this.textBoxCP.TabIndex = 1;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNIF.Location = new System.Drawing.Point(12, 85);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(82, 20);
            this.textBoxNIF.TabIndex = 2;
            this.textBoxNIF.TextChanged += new System.EventHandler(this.textBoxNIF_TextChanged);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMorada.Location = new System.Drawing.Point(251, 45);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(151, 20);
            this.textBoxMorada.TabIndex = 3;
            this.textBoxMorada.TextChanged += new System.EventHandler(this.textBoxMorada_TextChanged);
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxContacto.Location = new System.Drawing.Point(100, 85);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(100, 20);
            this.textBoxContacto.TabIndex = 4;
            this.textBoxContacto.TextChanged += new System.EventHandler(this.textBoxContacto_TextChanged);
            // 
            // textBoxPE
            // 
            this.textBoxPE.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPE.Location = new System.Drawing.Point(206, 85);
            this.textBoxPE.Name = "textBoxPE";
            this.textBoxPE.Size = new System.Drawing.Size(39, 20);
            this.textBoxPE.TabIndex = 5;
            this.textBoxPE.TextChanged += new System.EventHandler(this.textBoxPE_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(251, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocalBD
            // 
            this.LocalBD.BackColor = System.Drawing.SystemColors.Control;
            this.LocalBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalBD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LocalBD.Location = new System.Drawing.Point(156, 9);
            this.LocalBD.Name = "LocalBD";
            this.LocalBD.Size = new System.Drawing.Size(100, 13);
            this.LocalBD.TabIndex = 7;
            this.LocalBD.Text = "EEH";
            this.LocalBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocalBD.TextChanged += new System.EventHandler(this.LocalBD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "NIF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contacto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PEID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Adicionar
            // 
            this.ClientSize = new System.Drawing.Size(414, 117);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalBD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPE);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNIF);
            this.Name = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMorada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPE_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            // Atribuir uma string vazia a cada TextBox
            textBoxNome.Text = "";
            textBoxNIF.Text = "";
            textBoxContacto.Text = "";
            textBoxCP.Text = "";
            textBoxPE.Text = "";
            textBoxMorada.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Recolha de dados pelo utilizador
                string nome = textBoxNome.Text;
                string nif = textBoxNIF.Text;
                string contacto = textBoxContacto.Text;
                string cp = textBoxCP.Text;
                int partesEnvolvidas = Convert.ToInt32(textBoxPE.Text);
                string morada = textBoxMorada.Text;

                //abrir ligação
                SqlConnection ligacao = new SqlConnection();
                ligacao.ConnectionString = $@"Server=DESKTOP-VK287J3\SQLEXPRESS;Database={LocalBD.Text};User=admin;Password=123456";
                ligacao.Open();

                //Inserir dados nome,nif, contacto, cp, partesenvolvidas, morada
                string query = $"INSERT INTO Cliente VALUES('{nome}', '{nif}', '{contacto}', '{cp}', {partesEnvolvidas}, '{morada}')";
                SqlCommand adapter = new SqlCommand(query, ligacao);

                //executa uma instrução que não vai retornar resultados
                adapter.ExecuteNonQuery();

                //fechar ligação
                ligacao.Close();
                LimparCampos();
            }

            catch (SqlException erro)
            {
                MessageBox.Show("Não foi possível inserir dados. \n" + erro);
            }
        }

        private void LocalBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
