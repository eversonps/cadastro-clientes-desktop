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
    public partial class frmCadastroFornecedor : Form
    {
        // declaração de variaveis.
        string nome, Arq, consulta;
        bool a;
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchObservacaoCliente_TextChanged(object sender, EventArgs e)
        {
            // programando dentro da richtextbox o label "não obrigatório"
            lblNobg.Visible = false;
            if(RchObservacaoForne.Text == "")
            {
                lblNobg.Visible = true;
            }
        }

        private void frmCadastroFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // caso ele feche. programando para que ele volte par ao menu inicial.
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

        private void TxtTipoCForne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CmbEcForne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CmbUfforne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbUfforne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnExcluirForne_Click(object sender, EventArgs e)
        {
            // programando botão excluir.

            if (MessageBox.Show("Voce tem certeza que deseja excluir? O seu cadastro irá ser deletado", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Arq = "C:\\EmpresaTião\\Fornecedores\\" + TxtRazaoSocForne.Text + ".txt";
                File.Delete(Arq);
                MessageBox.Show("O arquivo com a razão social de: " + TxtRazaoSocForne.Text + " e código: " + TxtCodforne.Text + " foi apagado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnExcluirForne.Enabled = false;
                BtnSlvForne.Enabled = true;
                BtnConsForne.Enabled = false;
                BtnAltForne.Enabled = false;

                TxtFantasiaforne.Text = "";
                dtpCadastroForne.Text = "";
                TxtCodforne.Text = "";
                CmbEcForne.Text = "";
                CmbUfforne.Text = "";
                TxtEmailForne.Text = "";
                MskCepForne.Text = "";
                MskCnpjForne.Text = "";
                MskFaxForne.Text = "";
                MskTelForne.Text = "";
                TxtInscEstForne.Text = "";
                TxtNumLotForne.Text = "";
                TxtLogForne.Text = "";
                TxtRazaoSocForne.Text = "";
                TxtSiteForne.Text = "";
                TxtCidadeForne.Text = "";
                TxtBairroForne.Text = "";
                TxtCargoForne.Text = "";
                TxtCategoriaforne.Text = "";
                RchObservacaoForne.Text = "";
                lblNobg.Visible = true;
                grpCdsFornecedor.Enabled = true;
                TxtCodforne.Focus();
            }
        }

        private void BtnAltForne_Click(object sender, EventArgs e)
        {
            // programando botão alterar.

            BtnConsForne.Enabled = false;
            BtnSlvForne.Enabled = true;
            BtnAltForne.Enabled = false;
            BtnExcluirForne.Enabled = false;
            grpCdsFornecedor.Enabled = true;
            Arq = "C:\\EmpresaTião\\Fornecedores\\" + TxtRazaoSocForne.Text + ".txt";
            File.Delete(Arq);
        }

        private void TxtCodforne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtFantasiaforne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCategoriaforne_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCategoriaforne_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtRazaoSocForne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNumLotForne_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void TxtNumLotForne_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqueando caracteres
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void dtpCadastroForne_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodforne_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsForne_Click(object sender, EventArgs e)
        {
            // programando o botão consultar criando um novo formulário chamado consulta.
            if (Arq != "C:\\EmpresaTião\\Fornecedores\\" + TxtRazaoSocForne.Text + ".txt")
            {
                consulta = "C:\\EmpresaTião\\Fornecedores\\" + TxtRazaoSocForne.Text + ".txt";
                frmConsulta cdsFornecedor = new frmConsulta(consulta, TxtRazaoSocForne.Text);
                cdsFornecedor.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Erro! Não há o que consultar, pois o arquivo foi excluído");
            }
            BtnConsForne.Enabled = false;
        }

        private void BtnSlvForne_Click(object sender, EventArgs e)
        {
            // programando o botão incluir, já validando os campos.

            a = false;
            if (TxtCodforne.Text == "")
            {
                errForne.SetError(TxtCodforne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtCodforne, "");
            }

            if (TxtFantasiaforne.Text == "")
            {
                errForne.SetError(TxtFantasiaforne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtFantasiaforne, "");
            }

            if (TxtCategoriaforne.Text == "")
            {
                errForne.SetError(TxtCategoriaforne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtCategoriaforne, "");
            }

            if (TxtRazaoSocForne.Text == "")
            {
                errForne.SetError(TxtRazaoSocForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtRazaoSocForne, "");
            }

            if (TxtLogForne.Text == "")
            {
                errForne.SetError(TxtLogForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtLogForne, "");
            }

            if (TxtSiteForne.Text == "")
            {
                errForne.SetError(TxtSiteForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtSiteForne, "");
            }

            if (TxtCidadeForne.Text == "")
            {
                errForne.SetError(TxtCidadeForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtCidadeForne, "");
            }

            if (TxtBairroForne.Text == "")
            {
                errForne.SetError(TxtBairroForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtBairroForne, "");
            }

            if (MskCnpjForne.MaskFull)
            {
                errForne.SetError(MskCnpjForne, "");
            }
            else
            {
                errForne.SetError(MskCnpjForne, "Quantidade de caracteres errado");
                a = true;
            }

            if (MskCepForne.MaskFull)
            {
                errForne.SetError(MskCepForne, "");
            }
            else
            {
                errForne.SetError(MskCepForne, "Quantidade de caracteres errado");
                a = true;
            }

            if (MskFaxForne.MaskFull)
            {
                errForne.SetError(MskFaxForne, "");
            }
            else
            {
                errForne.SetError(MskFaxForne, "Quantidade de caracteres errado");
                a = true;
            }

            if (MskTelForne.MaskFull)
            {
                errForne.SetError(MskTelForne, "");
            }
            else
            {
                errForne.SetError(MskTelForne, "Quantidade de caracteres errado");
                a = true;
            }

            if (dtpCadastroForne.Checked == false)
            {
                errForne.SetError(dtpCadastroForne, "Coloque uma data");
                a = true;
            }
            else
            {
                errForne.SetError(dtpCadastroForne, "");
            }
            if (CmbUfforne.Text == "")
            {
                errForne.SetError(CmbUfforne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(CmbUfforne, "");
            }

            if (CmbEcForne.Text == "")
            {
                errForne.SetError(CmbEcForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(CmbEcForne, "");
            }

            if (TxtCargoForne.Text == "")
            {
                errForne.SetError(TxtCargoForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtCargoForne, "");
            }

            if (TxtEmailForne.Text == "")
            {
                errForne.SetError(TxtEmailForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtEmailForne, "");
            }

            if (TxtNumLotForne.Text == "")
            {
                errForne.SetError(TxtNumLotForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtNumLotForne, "");
            }

            if (TxtInscEstForne.Text == "")
            {
                errForne.SetError(TxtInscEstForne, "Não pode ficar em branco");
                a = true;
            }
            else
            {
                errForne.SetError(TxtInscEstForne, "");
            }

            if(a == true)
            {
                MessageBox.Show("Erro!!, ocorreu algum erro de digitação", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                if (!Directory.Exists("C:\\EmpresaTião\\Fornecedores"))
                {
                    Directory.CreateDirectory("C:\\EmpresaTião\\Fornecedores");
                }
                nome = "C:\\EmpresaTião\\Fornecedores\\" + TxtRazaoSocForne.Text + ".txt";

                File.WriteAllText(nome, "código: " + TxtCodforne.Text + "\r\n");
                File.AppendAllText(nome, "razão social: " + TxtRazaoSocForne.Text + "\r\n");
                File.AppendAllText(nome, "nome fantasia: " + TxtFantasiaforne.Text + "\r\n");
                File.AppendAllText(nome, "site: " + TxtSiteForne.Text + "\r\n");
                File.AppendAllText(nome, "cidade: " + TxtCidadeForne.Text + "\r\n");
                File.AppendAllText(nome, "bairro: " + TxtBairroForne.Text + "\r\n");
                File.AppendAllText(nome, "Logradouro: " + TxtLogForne.Text + "\r\n");
                File.AppendAllText(nome, "Tipo de compra: " + TxtCargoForne.Text + "\r\n");
                File.AppendAllText(nome, "email: " + TxtEmailForne.Text + "\r\n");
                File.AppendAllText(nome, "observação: " + RchObservacaoForne.Text + "\r\n");
                File.AppendAllText(nome, "data de cadastro: " + dtpCadastroForne.Text + "\r\n");
                File.AppendAllText(nome, "CEP: " + MskCepForne.Text + "\r\n");
                File.AppendAllText(nome, "Telefone: " + MskTelForne.Text + "\r\n");
                File.AppendAllText(nome, "CNPJ: " + MskCnpjForne.Text + "\r\n");
                File.AppendAllText(nome, "Numero do lote: " + TxtNumLotForne.Text + "\r\n");
                File.AppendAllText(nome, "Inscrição Estadual " + TxtInscEstForne.Text + "\r\n");
                File.AppendAllText(nome, "CPF: " + TxtCategoriaforne.Text + "\r\n");
                File.AppendAllText(nome, "Fax: " + MskFaxForne.Text + "\r\n");
                File.AppendAllText(nome, "UF: " + CmbUfforne.Text + "\r\n");
                File.AppendAllText(nome, "Estado civil: " + CmbEcForne.Text + "\r\n");

                MessageBox.Show("seu cadastro foi salvo com sucesso!", "salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnExcluirForne.Enabled = true;
                BtnSlvForne.Enabled = false;
                BtnAltForne.Enabled = true;
                BtnConsForne.Enabled = true;
                grpCdsFornecedor.Enabled = false;
                Arq = "";
            }
        }
    }
}