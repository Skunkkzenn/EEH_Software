using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace EEH_Software
{
    public partial class Alterar : Form
    {
        private TextBox label_cp;
        private TextBox LocalBD;
        private Button AlterarBtn;
        private TextBox textBoxCP;
        private TextBox textBoxNome;
        private TextBox textAlterarClienteId;
        private TextBox textAlterarNif;
        private TextBox textBoxNIF;
        private TextBox textBoxClienteId;
        private TextBox label_nome;

        public Alterar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label_nome = new System.Windows.Forms.TextBox();
            this.label_cp = new System.Windows.Forms.TextBox();
            this.LocalBD = new System.Windows.Forms.TextBox();
            this.AlterarBtn = new System.Windows.Forms.Button();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textAlterarClienteId = new System.Windows.Forms.TextBox();
            this.textAlterarNif = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxClienteId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_nome.Location = new System.Drawing.Point(12, 32);
            this.label_nome.Name = "label_nome";
            this.label_nome.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.label_nome.Size = new System.Drawing.Size(100, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // label_cp
            // 
            this.label_cp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_cp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_cp.Location = new System.Drawing.Point(148, 32);
            this.label_cp.Name = "label_cp";
            this.label_cp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.label_cp.Size = new System.Drawing.Size(100, 13);
            this.label_cp.TabIndex = 2;
            this.label_cp.Text = "CP:";
            // 
            // LocalBD
            // 
            this.LocalBD.BackColor = System.Drawing.SystemColors.Control;
            this.LocalBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalBD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LocalBD.Location = new System.Drawing.Point(145, 8);
            this.LocalBD.Name = "LocalBD";
            this.LocalBD.Size = new System.Drawing.Size(100, 13);
            this.LocalBD.TabIndex = 8;
            this.LocalBD.Text = "EEH";
            this.LocalBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocalBD.TextChanged += new System.EventHandler(this.LocalBD_TextChanged);
            // 
            // AlterarBtn
            // 
            this.AlterarBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlterarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.AlterarBtn.Location = new System.Drawing.Point(118, 74);
            this.AlterarBtn.Name = "AlterarBtn";
            this.AlterarBtn.Size = new System.Drawing.Size(151, 20);
            this.AlterarBtn.TabIndex = 9;
            this.AlterarBtn.Text = "Alterar";
            this.AlterarBtn.UseVisualStyleBackColor = false;
            this.AlterarBtn.Click += new System.EventHandler(this.AlterarBtn_Click);
            // 
            // textBoxCP
            // 
            this.textBoxCP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCP.Location = new System.Drawing.Point(148, 51);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(53, 20);
            this.textBoxCP.TabIndex = 11;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNome.Location = new System.Drawing.Point(8, 51);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(134, 20);
            this.textBoxNome.TabIndex = 10;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textAlterarClienteId
            // 
            this.textAlterarClienteId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textAlterarClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAlterarClienteId.Location = new System.Drawing.Point(312, 32);
            this.textAlterarClienteId.Name = "textAlterarClienteId";
            this.textAlterarClienteId.Size = new System.Drawing.Size(100, 13);
            this.textAlterarClienteId.TabIndex = 36;
            this.textAlterarClienteId.Text = "Cliente Id:";
            // 
            // textAlterarNif
            // 
            this.textAlterarNif.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textAlterarNif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAlterarNif.Location = new System.Drawing.Point(206, 32);
            this.textAlterarNif.Name = "textAlterarNif";
            this.textAlterarNif.Size = new System.Drawing.Size(100, 13);
            this.textAlterarNif.TabIndex = 35;
            this.textAlterarNif.Text = "NIF:";
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(207, 51);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(100, 20);
            this.textBoxNIF.TabIndex = 37;
            this.textBoxNIF.TextChanged += new System.EventHandler(this.textBoxNIF_TextChanged);
            // 
            // textBoxClienteId
            // 
            this.textBoxClienteId.Location = new System.Drawing.Point(312, 51);
            this.textBoxClienteId.Name = "textBoxClienteId";
            this.textBoxClienteId.Size = new System.Drawing.Size(31, 20);
            this.textBoxClienteId.TabIndex = 38;
            this.textBoxClienteId.TextChanged += new System.EventHandler(this.textBoxClienteId_TextChanged);
            // 
            // Alterar
            // 
            this.ClientSize = new System.Drawing.Size(369, 98);
            this.Controls.Add(this.textBoxClienteId);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textAlterarClienteId);
            this.Controls.Add(this.textAlterarNif);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.AlterarBtn);
            this.Controls.Add(this.LocalBD);
            this.Controls.Add(this.label_cp);
            this.Controls.Add(this.label_nome);
            this.Name = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LocalBD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AlterarBtn_Click(object sender, EventArgs e)
        {
            //atualizar dados na base de dados

            try
            {
                //Recolha de dados pelo utilizador
                string nome = textBoxNome.Text;
                string nif = textBoxNIF.Text;
                string contacto = textBoxCP.Text;
                int clienteID = Convert.ToInt32(textBoxClienteId.Text);



                //abrir ligação
                SqlConnection ligacao = new SqlConnection();
                ligacao.ConnectionString = $@"Server=DESKTOP-VK287J3\SQLEXPRESS;Database={LocalBD.Text};User=admin;Password=123456";
                ligacao.Open();

                //Atualização de um registo na base de dados
                string query = $"UPDATE Cliente SET Nome='{nome}', NIF='{nif}', Contacto='{contacto}' WHERE ClienteID='{clienteID}'";
                SqlCommand adapter = new SqlCommand(query, ligacao);
                adapter.ExecuteNonQuery();


                //fechar ligação
                ligacao.Close();
                LimparCampos();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Não foi possível atualizar dados. \n" + erro);
            }
        }

        private void LimparCampos()
        {
            // Atribuir uma string vazia a cada TextBox
            textBoxNome.Text = "";
            textBoxCP.Text = "";
            textBoxNIF.Text = "";
            textBoxClienteId.Text = "";
        }

            private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alterar_Load(object sender, EventArgs e)
        {

        }
    }
}
