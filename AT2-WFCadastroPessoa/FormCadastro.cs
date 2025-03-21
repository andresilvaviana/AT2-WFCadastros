using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            {/*
               
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    Erro("Campo Nome não pode estar Vazio!");
                    return;
                }
                
                else if (string.IsNullOrEmpty(txtSobrenome.Text))
                {
                    Erro("Campo Sobrenome não pode estar Vazio!");
                    return;
                }
                
                else if (string.IsNullOrEmpty(semMaskTelefone))
                {
                    Erro("Campo Telefone não pode estar Vazio!");
                    return;
                }
              
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    Erro("Campo Email não pode estar Vazio!");
                    return;
                }

                ETipoTelefone tipoTelefone;
                
                if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
                {
                    Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                    return;
                }
                else
                {
                    if (rdbComercial.Checked)
                        tipoTelefone = ETipoTelefone.Comercial;
                    else if (rdbPessoal.Checked)
                        tipoTelefone = ETipoTelefone.Pessoal;
                    else
                        tipoTelefone = ETipoTelefone.Recado;
                }
                */
                Pessoa p1 = new Pessoa();
                p1.Cadastro = Convert.ToInt32(txtCadastro.Text);
                p1.Nome = txtNomeCompleto.Text;
                p1.Email = txtEmail.Text;

                p1.DDDCelular = mktCelular.Text.Substring(0, 2);


                Pessoa.ListaPessoas.Add(p1);

                Sucesso("Cadastrado com Sucesso!");

            }
        }
    }
}
