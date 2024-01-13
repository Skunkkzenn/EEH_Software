using System;

namespace EEH_Software
{
    partial class DbControl
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AcessoBD = new System.Windows.Forms.Button();
            this.Listagem_Clientes = new System.Windows.Forms.ListBox();
            this.textBD = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAbrirDbRegister = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcessoBD
            // 
            this.AcessoBD.Location = new System.Drawing.Point(421, 29);
            this.AcessoBD.Name = "AcessoBD";
            this.AcessoBD.Size = new System.Drawing.Size(163, 23);
            this.AcessoBD.TabIndex = 0;
            this.AcessoBD.Text = "Listar Clientes";
            this.AcessoBD.UseVisualStyleBackColor = true;
            this.AcessoBD.Click += new System.EventHandler(this.AcessoBD_Click);
            // 
            // Listagem_Clientes
            // 
            this.Listagem_Clientes.FormattingEnabled = true;
            this.Listagem_Clientes.Location = new System.Drawing.Point(12, 66);
            this.Listagem_Clientes.Name = "Listagem_Clientes";
            this.Listagem_Clientes.Size = new System.Drawing.Size(602, 238);
            this.Listagem_Clientes.TabIndex = 2;
            this.Listagem_Clientes.SelectedIndexChanged += new System.EventHandler(this.ListaDados_SelectedIndexChanged);
            // 
            // textBD
            // 
            this.textBD.Location = new System.Drawing.Point(11, 31);
            this.textBD.Name = "textBD";
            this.textBD.Size = new System.Drawing.Size(101, 20);
            this.textBD.TabIndex = 3;
            this.textBD.Text = "EEH";
            this.textBD.TextChanged += new System.EventHandler(this.textBD_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Base de Dados:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAbrirDbRegister
            // 
            this.btnAbrirDbRegister.Location = new System.Drawing.Point(131, 29);
            this.btnAbrirDbRegister.Name = "btnAbrirDbRegister";
            this.btnAbrirDbRegister.Size = new System.Drawing.Size(79, 23);
            this.btnAbrirDbRegister.TabIndex = 8;
            this.btnAbrirDbRegister.Text = "Inserir Cliente";
            this.btnAbrirDbRegister.UseVisualStyleBackColor = true;
            this.btnAbrirDbRegister.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 29);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar Cliente";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(319, 29);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(96, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover Cliente";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // DbControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 369);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAbrirDbRegister);
            this.Controls.Add(this.AcessoBD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBD);
            this.Controls.Add(this.Listagem_Clientes);
            this.Name = "DbControl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcessoBD;
        private System.Windows.Forms.TextBox textBD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAbrirDbRegister;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        internal System.Windows.Forms.ListBox Listagem_Clientes;
    }
}

