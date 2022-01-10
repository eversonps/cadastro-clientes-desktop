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

    public partial class frmCadastroEmpregado : Form
    {

        // declaração de variaveis
        string nome, Arq, consulta;
        bool a;
        public frmCadastroEmpregado()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroEmpregado_FormClosed(object sender, FormClosedEventArgs e)
        {
            // programando caso o usuário feche o formulario de cadastro dos empregados. Isso irá fazer ele voltar
            // para para o menu inicial.

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

        private void mskDataemissaoEmpre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNomeEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando digitos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando digitos
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomefantasiaEmpre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomefantasiaEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando digitos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCrachaEmpre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCrachaEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando digitos
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPisEmpre_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtPisEmpre_Leave(object sender, EventArgs e)
        {

        }

        private void txtPisEmpre_Enter(object sender, EventArgs e)
        {

        }

        private void btnSlvEmpre_Click(object sender, EventArgs e)
        {
            //programando botão incluir, já validando os campos.

            a = false;
            if (dtpAdmissaoEmpre.Checked == false)
            {
                errEmpre.SetError(dtpAdmissaoEmpre, "Coloque uma data");
                a = true;
            }
            else
            {
                errEmpre.SetError(dtpAdmissaoEmpre, "");
            }

            if (mskTelEmpre.MaskFull)
            {
                errEmpre.SetError(mskTelEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskTelEmpre, "Quantidade de caracteres errado");
                a = true;
            }

            if (mskCelularEmpre.MaskFull)
            {
                errEmpre.SetError(mskCelularEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskCelularEmpre, "Quantidade de caracteres errado");
                a = true;
            }

            if (dtpNascEmpre.Checked == false)
            {
                errEmpre.SetError(dtpNascEmpre, "Coloque uma data");
                a = true;
            }
            else
            {
                errEmpre.SetError(dtpNascEmpre, "");              
            }

            if (cmbSexoEmpre.Text == "")
            {
                errEmpre.SetError(cmbSexoEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(cmbSexoEmpre, "");
            }

            if (cmbEcEmpre.Text == "")
            {
                errEmpre.SetError(cmbEcEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(cmbEcEmpre, "");
            }

            if (txtEnderecoEmpre.Text == "")
            {
                errEmpre.SetError(txtEnderecoEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtEnderecoEmpre, "");
            }

            if (txtCidadeEmpre.Text == "")
            {
                errEmpre.SetError(txtCidadeEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtCidadeEmpre, "");
            }

            if (txtBairroEmpre.Text == "")
            {
                errEmpre.SetError(txtBairroEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtBairroEmpre, "");
            }

            if (txtCompEmpre.Text == "")
            {
                errEmpre.SetError(txtCompEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtCompEmpre, "");
            }

            if (txtEmailEmpre.Text == "")
            {
                errEmpre.SetError(txtEmailEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtEmailEmpre, "");
            }

            if (txtNumtrabalhoEmpre.Text == "")
            {
                errEmpre.SetError(txtNumtrabalhoEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtNumtrabalhoEmpre, "");
            }

            if (mskSerieEmpre.MaskFull)
            {
                errEmpre.SetError(mskSerieEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskSerieEmpre, "Quantidade de caracteres inválido");
                a = true;
            }

            if (txtNomeEmpre.Text == "")
            {
                errEmpre.SetError(txtNomeEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtNomeEmpre, "");
            }

            if (txtCodEmpre.Text == "")
            {
                errEmpre.SetError(txtCodEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtCodEmpre, "");
            }

            if (dtpEmissaoEmpre.Checked == false)
            {
                errEmpre.SetError(dtpEmissaoEmpre, "Coloque uma data");
                a = true;
            }
            else
            {
                errEmpre.SetError(dtpEmissaoEmpre, "");
            }

            if (txtNomefantasiaEmpre.Text == "")
            {
                errEmpre.SetError(txtNomefantasiaEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtNomefantasiaEmpre, "");
            }

            if (mskRgEmpre.MaskFull)
            {
                errEmpre.SetError(mskRgEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskRgEmpre, "Quantidade de caracteres inválido");
                a = true;
            }

            if (mskRgEmpre.MaskFull)
            {
                errEmpre.SetError(mskRgEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskRgEmpre, "Quantidade de caracteres inválido");
                a = true;
            }

            if (mskCpfEmpre.MaskFull)
            {
                errEmpre.SetError(mskCpfEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskCpfEmpre, "Quantidade de caracteres inválido");
                a = true;
            }

            if (mskCnpjEmpre.MaskFull)
            {
                errEmpre.SetError(mskCnpjEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskCnpjEmpre, "Quantidade de caracteres inválido");
                a = true;
            }

            if (mskCepEmpre.MaskFull)
            {
                errEmpre.SetError(mskCepEmpre, "");
            }
            else
            {
                errEmpre.SetError(mskCepEmpre, "Quantidade de caracteres inválidos");
                a = true;
            }

            if (cmbUfEmpre.Text == "")
            {
                errEmpre.SetError(cmbUfEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(cmbUfEmpre, "");
            }

            if (txtCrachaEmpre.Text == "")
            {
                errEmpre.SetError(txtCrachaEmpre, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errEmpre.SetError(txtCrachaEmpre, "");
            }

            if (a == true)
            {
                MessageBox.Show("Erro!!, ocorreu algum erro de digitação", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else           
            {
                if (!Directory.Exists("C:\\EmpresaTião\\Empregados"))
                {
                    Directory.CreateDirectory("C:\\EmpresaTião\\Empregados");
                }
                nome = "C:\\EmpresaTião\\Empregados\\" + txtNomeEmpre.Text + ".txt";

                File.WriteAllText(nome, "código: " + txtCodEmpre.Text + "\r\n");
                File.AppendAllText(nome, "nome: " + txtNomeEmpre.Text + "\r\n");
                File.AppendAllText(nome, "nome fantasia: " + txtNomefantasiaEmpre.Text + "\r\n");
                File.AppendAllText(nome, "endereço: " + txtEnderecoEmpre.Text + "\r\n");
                File.AppendAllText(nome, "cidade: " + txtCidadeEmpre.Text + "\r\n");
                File.AppendAllText(nome, "bairro: " + txtBairroEmpre.Text + "\r\n");
                File.AppendAllText(nome, "complemento: " + txtCompEmpre.Text + "\r\n");
                File.AppendAllText(nome, "email: " + txtEmailEmpre.Text + "\r\n");
                File.AppendAllText(nome, "observação: " + rchObservacaoEmpre.Text + "\r\n");
                File.AppendAllText(nome, "nascimento: " + dtpNascEmpre.Text + "\r\n");
                File.AppendAllText(nome, "CEP: " + mskCepEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Celular: " + mskCelularEmpre.Text + "\r\n");
                File.AppendAllText(nome, "CNPJ: " + mskCnpjEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Telefone: " + mskTelEmpre.Text + "\r\n");
                File.AppendAllText(nome, "RG: " + mskRgEmpre.Text + "\r\n");
                File.AppendAllText(nome, "CPF: " + mskCpfEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Estado Civil: " + cmbEcEmpre.Text + "\r\n");
                File.AppendAllText(nome, "UF: " + cmbUfEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Pis: " + mskPisEmpre.Text + " R$" + "\r\n");
                File.AppendAllText(nome, "Nº do crachá: " + txtCrachaEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Data de admissão: " + dtpAdmissaoEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Data de emissão: " + dtpEmissaoEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Número: " + txtNumtrabalhoEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Série: " + mskSerieEmpre.Text + "\r\n");
                File.AppendAllText(nome, "Sexo: " + cmbSexoEmpre.Text + "\r\n");

                MessageBox.Show("seu cadastro foi salvo com sucesso!", "salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExcluirEmpre.Enabled = true;
                btnSlvEmpre.Enabled = false;
                btnAltEmpre.Enabled = true;
                btnConsEmpre.Enabled = true;
                grpDadosEmpre.Enabled = false;
                grpCartEmpre.Enabled = false;
                Arq = "";
            }
        }

  
        private void btnAltEmpre_Click_1(object sender, EventArgs e)
        {
            // programando botão alterar.

            btnConsEmpre.Enabled = false;
            btnSlvEmpre.Enabled = true;
            btnAltEmpre.Enabled = false;
            btnExcluirEmpre.Enabled = false;
            grpCartEmpre.Enabled = true;
            grpDadosEmpre.Enabled = true;
            Arq = "C:\\EmpresaTião\\Empregados\\" + txtNomeEmpre.Text + ".txt";
            File.Delete(Arq);
        }

        private void txtNomeEmpre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPisEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando digitos
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumtrabalhoEmpre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumtrabalhoEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueando digitos
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbSexoEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueando digitos
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbEcEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueando digitos
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbUfEmpre_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbUfEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueando digitos
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmCadastroEmpregado_Load(object sender, EventArgs e)
        {

        }

        private void grpDadosEmpre_Enter(object sender, EventArgs e)
        {

        }

        private void mskRgEmpre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpNascEmpre_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpAdmissaoEmpre_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpEmissaoEmpre_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void grpCdsEmpre_Enter(object sender, EventArgs e)
        {

        }

        private void rchObservacaoEmpre_TextChanged(object sender, EventArgs e)
        {
            // programando a label do " *não obrigatório ".
            lblNobg.Visible = false;
            if (rchObservacaoEmpre.Text == "")
            {
                lblNobg.Visible = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

    

        private void btnConsEmpre_Click(object sender, EventArgs e)
        {
            // programando botão consultar para abrir um novo formulário chamado consulta.
            if (Arq != "C:\\EmpresaTião\\Empregados\\" + txtNomeEmpre.Text + ".txt")
            {
                consulta = "C:\\EmpresaTião\\Empregados\\" + txtNomeEmpre.Text + ".txt";
                frmConsulta cdsEmpregados = new frmConsulta(consulta, txtNomeEmpre.Text);
                cdsEmpregados.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro! Não há o que consultar, pois o arquivo foi excluído");
            }
            btnConsEmpre.Enabled = false;
        }

       
      

        private void btnExcluirEmpre_Click(object sender, EventArgs e)
        {
            // programando botão de excluir.
            if (MessageBox.Show("Voce tem certeza que deseja excluir? O seu cadastro irá ser deletado", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Arq = "C:\\EmpresaTião\\Empregados\\" + txtNomeEmpre.Text + ".txt";
                File.Delete(Arq);
                MessageBox.Show("O arquivo com o nome de: " + txtNomeEmpre.Text + " e código: " + txtCodEmpre.Text + " foi apagado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnExcluirEmpre.Enabled = false;
                btnSlvEmpre.Enabled = true;
                btnAltEmpre.Enabled = false;
                btnConsEmpre.Enabled = false;

                txtCodEmpre.Text = "";
                dtpAdmissaoEmpre.Text = "";
                dtpEmissaoEmpre.Text = "";
                dtpNascEmpre.Text = "";
                txtNomeEmpre.Text = "";
                cmbEcEmpre.Text = "";
                cmbUfEmpre.Text = "";
                txtNomefantasiaEmpre.Text = "";
                mskRgEmpre.Text = "";
                mskCnpjEmpre.Text = "";
                mskSerieEmpre.Text = "";
                mskTelEmpre.Text = "";
                mskCelularEmpre.Text = "";
                mskCepEmpre.Text = "";
                txtCrachaEmpre.Text = "";
                txtEnderecoEmpre.Text = "";
                txtCompEmpre.Text = "";
                txtBairroEmpre.Text = "";
                txtCidadeEmpre.Text = "";
                txtEmailEmpre.Text = "";
                txtNumtrabalhoEmpre.Text = "";
                mskPisEmpre.Text = "";
                mskCpfEmpre.Text = "";
                rchObservacaoEmpre.Text = "";
                cmbSexoEmpre.Text = "";
                lblNobg.Visible = true;
                grpDadosEmpre.Enabled = true;
                grpCartEmpre.Enabled = true;
                txtNomeEmpre.Focus();
            }           
        }            
    }
}
