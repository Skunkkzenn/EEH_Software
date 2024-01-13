using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace EEH_Software
{
    public partial class Remover : Form
    {
        private TextBox textBoxClienteId;
        private Button RemoverBtn;
        private TextBox textAlterarClienteId;
        private TextBox label_nome;
        private TextBox LocalBD;
        private TextBox textBoxNome;

        public Remover()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxClienteId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.RemoverBtn = new System.Windows.Forms.Button();
            this.textAlterarClienteId = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.TextBox();
            this.LocalBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxClienteId
            // 
            this.textBoxClienteId.Location = new System.Drawing.Point(159, 49);
            this.textBoxClienteId.Name = "textBoxClienteId";
            this.textBoxClienteId.Size = new System.Drawing.Size(49, 20);
            this.textBoxClienteId.TabIndex = 40;
            // 
            // textBoxNome
            // 
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNome.Location = new System.Drawing.Point(12, 49);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(145, 20);
            this.textBoxNome.TabIndex = 39;
            // 
            // RemoverBtn
            // 
            this.RemoverBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RemoverBtn.Location = new System.Drawing.Point(32, 75);
            this.RemoverBtn.Name = "RemoverBtn";
            this.RemoverBtn.Size = new System.Drawing.Size(151, 20);
            this.RemoverBtn.TabIndex = 41;
            this.RemoverBtn.Text = "Remover";
            this.RemoverBtn.UseVisualStyleBackColor = false;
            this.RemoverBtn.Click += new System.EventHandler(this.RemoverBtn_Click);
            // 
            // textAlterarClienteId
            // 
            this.textAlterarClienteId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textAlterarClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAlterarClienteId.Location = new System.Drawing.Point(159, 30);
            this.textAlterarClienteId.Name = "textAlterarClienteId";
            this.textAlterarClienteId.Size = new System.Drawing.Size(49, 13);
            this.textAlterarClienteId.TabIndex = 43;
            this.textAlterarClienteId.Text = "Cliente Id:";
            // 
            // label_nome
            // 
            this.label_nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_nome.Location = new System.Drawing.Point(12, 30);
            this.label_nome.Name = "label_nome";
            this.label_nome.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 42;
            this.label_nome.Text = "Nome:";
            // 
            // LocalBD
            // 
            this.LocalBD.BackColor = System.Drawing.SystemColors.Control;
            this.LocalBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalBD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LocalBD.Location = new System.Drawing.Point(62, 9);
            this.LocalBD.Name = "LocalBD";
            this.LocalBD.Size = new System.Drawing.Size(100, 13);
            this.LocalBD.TabIndex = 44;
            this.LocalBD.Text = "EEH";
            this.LocalBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocalBD.TextChanged += new System.EventHandler(this.LocalBD_TextChanged);
            // 
            // Remover
            // 
            this.ClientSize = new System.Drawing.Size(220, 113);
            this.Controls.Add(this.LocalBD);
            this.Controls.Add(this.textAlterarClienteId);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.RemoverBtn);
            this.Controls.Add(this.textBoxClienteId);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RemoverBtn_Click(object sender, EventArgs e)
        {
            //Eliminação de dados

            try
            {
                string nome = textBoxNome.Text;
                int clienteID = Convert.ToInt32(textBoxClienteId.Text);

                //abrir ligação
                SqlConnection ligacao = new SqlConnection();
                ligacao.ConnectionString = $@"Server=DESKTOP-VK287J3\SQLEXPRESS;Database={LocalBD.Text};User=admin;Password=123456";
                ligacao.Open();

                //Eliminação de registros na base de dados
                //ELIMINA TODAS AS LINHAS CONTENDO O CRITÉRIO DESEJADO!!!
                string query = "DELETE FROM Cliente " +
                               $"WHERE Nome='{nome}'" +
                               $"AND ClienteID='{clienteID}'";
                SqlCommand adapter = new SqlCommand(query, ligacao);
                adapter.ExecuteNonQuery();

                //fechar ligação
                ligacao.Close();
                LimparCampos();
            }

            catch (SqlException erro)
            {
                MessageBox.Show("Não foi possível eliminar dados. \n" + erro);
            }
        }

        private void LimparCampos()
        {
            // Atribuir uma string vazia a cada TextBox
            textBoxNome.Text = "";
            textBoxClienteId.Text = "";
        }

        private void LocalBD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
