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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmSobre sobre = new frmSobre();
                sobre.Show();
                this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cdsCliente = new frmCadastroCliente();
            cdsCliente.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cdsCliente = new frmCadastroCliente();
            cdsCliente.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForncecedores_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cdsFornecedor = new frmCadastroFornecedor();
            cdsFornecedor.Show();
            this.Hide();
        }

        private void btnEmpregados_Click(object sender, EventArgs e)
        {
            frmCadastroEmpregado cdsEmpregado = new frmCadastroEmpregado();
            cdsEmpregado.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor cdsFornecedor = new frmCadastroFornecedor();
            cdsFornecedor.Show();
            this.Hide();
        }

        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpregado cdsEmpregado = new frmCadastroEmpregado();
            cdsEmpregado.Show();
            this.Hide();
        }
    }
}

