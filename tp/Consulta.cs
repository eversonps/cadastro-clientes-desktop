using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp
{
    public partial class frmConsulta : Form
    {
        //declaração de variaveis.
        string var;
        string teste;
        public frmConsulta(string cons, string a)
        {
            // atribuição dos valores de caminho da pasta e do elemento principal que pode ser(a razão social ou o nome)


            InitializeComponent();
            teste = cons;
            lblConsulta.Text = File.ReadAllText(cons);
            var = a;
             if (teste == "C:\\EmpresaTião\\Empregados\\" + var + ".txt")
             { 
              this.Size = new System.Drawing.Size(410, 529);
             }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // vendo qual o form correspondente para que quando ele clique em voltar, volte para o formulário correto.

            if (teste == "C:\\EmpresaTião\\Clientes\\" + var + ".txt")
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
                else
                {
                    foreach (Form formAberto in Application.OpenForms)
                    {
                        if (formAberto is frmCadastroCliente)
                        {
                            formAberto.Show();
                            this.Hide();
                        }
                    }
                }
            }

            if (teste == "C:\\EmpresaTião\\Empregados\\" + var + ".txt")
            {           
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
                else
                {
                    foreach (Form formAberto in Application.OpenForms)
                    {
                        if (formAberto is frmCadastroEmpregado)
                        {
                            formAberto.Show();
                            this.Hide();
                        }
                    }
                }
            }

            if (teste == "C:\\EmpresaTião\\Fornecedores\\" + var + ".txt")
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
                else
                {
                    foreach (Form formAberto in Application.OpenForms)
                    {
                        if (formAberto is frmCadastroFornecedor)
                        {
                            formAberto.Show();
                            this.Hide();
                        }
                    }
                }
            }

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
