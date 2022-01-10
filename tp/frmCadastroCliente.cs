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
    public partial class frmCadastroCliente : Form
    {
        // declaração de variaveis.
        string Arq;
        string nome;
        string consulta;
        bool a;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // caso o usuario feche o formulario de cadastro de cliente ele irá voltar para o menu inicial.
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is frmPrincipal)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomefCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskNascCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskRgCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCompCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidadeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchObservação_TextChanged(object sender, EventArgs e)
        {

            // programando botão label que se situa na richtextbox.
            lblNobg.Visible = false;
            if (rchObservacaoCliente.Text == "")
            {
                lblNobg.Visible = true;
            }
        }

        private void cmbSexoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskCelularCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSlvCliente_Click(object sender, EventArgs e)
        {

            // programando o botão incluir já validando os campos.

            a = false;
            if (txtCodCliente.Text == "")
            {
                errCliente.SetError(txtCodCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtNomeCliente.Text == "")
            {
                errCliente.SetError(txtNomeCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtNomefCliente.Text == "")
            {
                errCliente.SetError(txtNomefCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtEnderecoCliente.Text == "")
            {
                errCliente.SetError(txtEnderecoCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtCidadeCliente.Text == "")
            {
                errCliente.SetError(txtCidadeCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtBairroCliente.Text == "")
            {
                errCliente.SetError(txtBairroCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtCompCliente.Text == "")
            {
                errCliente.SetError(txtCompCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (txtEmailCliente.Text == "")
            {
                errCliente.SetError(txtEmailCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.Clear();
            }

            if (mskRgCliente.MaskFull)
            {
                errCliente.SetError(mskRgCliente, "");
            }
            else
            {
                errCliente.SetError(mskRgCliente, "Quantidade de caracteres errado");
                a = true;
            }

            if (mskCpfCliente.MaskFull)
            {
                errCliente.SetError(mskCpfCliente, "");
            }
            else
            {
                errCliente.SetError(mskCpfCliente, "Quantidade de caracteres errado");
                a = true;
            }

            if (mskCnpjCliente.MaskFull)
            {
                errCliente.SetError(mskCnpjCliente, "");
            }
            else
            {
                errCliente.SetError(mskCnpjCliente, "Quantidade de caracteres");
                a = true;
            }

            if (mskCepCliente.MaskFull)
            {
                errCliente.SetError(mskCepCliente, "");
            }
            else
            {
                errCliente.SetError(mskCepCliente, "Quantidade de caracteres errado");
                a = true;
            }

            if (mskCelularCliente.MaskFull)
            {
                errCliente.SetError(mskCelularCliente, "");
            }
            else
            {
                errCliente.SetError(mskCelularCliente, "Quantidade de caracteres errado");
                a = true;
            }

            if (mskTelCliente.MaskFull)
            {
                errCliente.SetError(mskTelCliente, "");
            }
            else
            {
                errCliente.SetError(mskTelCliente, "Quantidade de caracteres errado");
                a = true;
            }

            if (dtpNascClientes.Checked == false)
            {
                errCliente.SetError(dtpNascClientes, "Coloque uma data");
                a = true;
            }
            else
            {
                errCliente.SetError(dtpNascClientes, "");
            }

            if (cmbSexoCliente.Text == "")
            {
                errCliente.SetError(cmbSexoCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.SetError(cmbSexoCliente, "");
            }

            if (cmbUfCliente.Text == "")
            {
                errCliente.SetError(cmbUfCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.SetError(cmbUfCliente, "");
            }

            if (cmbEcCliente.Text == "")
            {
                errCliente.SetError(cmbEcCliente, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errCliente.SetError(cmbEcCliente, "");
            }

            if(a == true)
            {
                MessageBox.Show("Erro!!, ocorreu algum erro de digitação","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           else
            {
                if (!Directory.Exists("C:\\EmpresaTião\\Clientes"))
                {
                    Directory.CreateDirectory("C:\\EmpresaTião\\Clientes");
                }
                nome = "C:\\EmpresaTião\\Clientes\\" + txtNomeCliente.Text + ".txt";

                File.WriteAllText(nome, "código: " + txtCodCliente.Text + "\r\n");
                File.AppendAllText(nome, "razão social: " + txtNomeCliente.Text + "\r\n");
                File.AppendAllText(nome, "nome fantasia: " + txtNomefCliente.Text + "\r\n");
                File.AppendAllText(nome, "endereço: " + txtEnderecoCliente.Text + "\r\n");
                File.AppendAllText(nome, "cidade: " + txtCidadeCliente.Text + "\r\n");
                File.AppendAllText(nome, "bairro: " + txtBairroCliente.Text + "\r\n");
                File.AppendAllText(nome, "complemento: " + txtCompCliente.Text + "\r\n");
                File.AppendAllText(nome, "email: " + txtEmailCliente.Text + "\r\n");
                File.AppendAllText(nome, "observação: " + rchObservacaoCliente.Text + "\r\n");
                File.AppendAllText(nome, "nascimento: " + dtpNascClientes.Text + "\r\n");
                File.AppendAllText(nome, "CEP: " + mskCepCliente.Text + "\r\n");
                File.AppendAllText(nome, "Celular: " + mskCelularCliente.Text + "\r\n");
                File.AppendAllText(nome, "CNPJ: " + mskCnpjCliente.Text + "\r\n");
                File.AppendAllText(nome, "Telefone: " + mskTelCliente.Text + "\r\n");
                File.AppendAllText(nome, "RG: " + mskRgCliente.Text + "\r\n");
                File.AppendAllText(nome, "CPF: " + mskCpfCliente.Text + "\r\n");
                File.AppendAllText(nome, "Estado Civil: " + cmbEcCliente.Text + "\r\n");
                File.AppendAllText(nome, "UF: " + cmbUfCliente.Text + "\r\n");
                File.AppendAllText(nome, "Sexo: " + cmbSexoCliente.Text + "\r\n");

                MessageBox.Show("seu cadastro foi salvo com sucesso!", "salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExcluirCliente.Enabled = true;
                btnSlvCliente.Enabled = false;
                btnAltCliente.Enabled = true;
                btnConsCliente.Enabled = true;
                grpCdsCliente.Enabled = false;
                Arq = "";
            }
            

        }

        private void grpCdsCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // programando botão excluir. Para lógicamente excluir o caadastro e também deixar os campos em branco.

            if (MessageBox.Show("Voce tem certeza que deseja excluir? O seu cadastro irá ser deletado", "Questão", MessageBoxButtons.YesNo,  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Arq = "C:\\EmpresaTião\\Clientes\\" + txtNomeCliente.Text + ".txt";
                File.Delete(Arq);
                MessageBox.Show("O arquivo com o nome de: " + txtNomeCliente.Text + " e código: " + txtCodCliente.Text + " foi apagado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExcluirCliente.Enabled = false;
                btnSlvCliente.Enabled = true;
                btnConsCliente.Enabled = false;
                btnAltCliente.Enabled = false;

                txtNomefCliente.Text = "";
                dtpNascClientes.Text = "";
                txtCodCliente.Text = "";
                cmbEcCliente.Text = "";
                cmbSexoCliente.Text = "";
                cmbUfCliente.Text = "";
                txtNomeCliente.Text = "";
                mskRgCliente.Text = "";
                mskCnpjCliente.Text = "";
                mskTelCliente.Text = "";
                mskCelularCliente.Text = "";
                mskCepCliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtEmailCliente.Text = "";
                txtCompCliente.Text = "";
                txtBairroCliente.Text = "";
                txtCidadeCliente.Text = "";
                mskCpfCliente.Text = "";
                rchObservacaoCliente.Text = "";
                grpCdsCliente.Enabled = true;
                lblNobg.Visible = true;
                txtCodCliente.Focus();
            }
        }

        private void btnConsCliente_Click(object sender, EventArgs e)
         {
            // programando o botão consultar para que ele abra um novo formulário chamado consulte
            if (Arq != "C:\\EmpresaTião\\Clientes\\" + txtNomeCliente.Text + ".txt")
            {
                consulta = "C:\\EmpresaTião\\Clientes\\" + txtNomeCliente.Text + ".txt";
                frmConsulta cdsCliente = new frmConsulta(consulta, txtNomeCliente.Text);
                cdsCliente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro! Não há o que consultar, pois o arquivo foi excluído");
            }
            btnConsCliente.Enabled = false;
        }

        private void btnAltCliente_Click(object sender, EventArgs e)
        {
            // programando botão alterar, liberando novamente os campos para que ele altere

            btnConsCliente.Enabled = false;
            btnSlvCliente.Enabled = true;
            btnAltCliente.Enabled = false;
            btnExcluirCliente.Enabled = false;
            grpCdsCliente.Enabled = true;
            Arq = "C:\\EmpresaTião\\Clientes\\" + txtNomeCliente.Text + ".txt";
            File.Delete(Arq);
        }

        private void cmbUfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbEcCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbSexoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomefCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbSexoCliente_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

