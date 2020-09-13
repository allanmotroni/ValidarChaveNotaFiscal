using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerarChaveNotaFiscal
{
    public partial class GerarChaveNotaFiscal : Form
    {
        public GerarChaveNotaFiscal()
        {
            InitializeComponent();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            try
            {
                txtChave.Clear();

                string nota = txtNumeroNota.Text;
                string serie = txtSerie.Text;
                string data = dtpDataEmissao.Value.ToString("dd/MM/yyyy");
                string cnpj = txtCnpjExportador.Text;

                if (string.IsNullOrEmpty(nota) || string.IsNullOrEmpty(serie) || string.IsNullOrEmpty(cnpj))
                {
                    throw new Exception("É preciso preencher todos os campos para Gerar a Chave!");
                }

                txtChave.Text = GerarChave(nota, serie, data, cnpj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string TratarData(string data)
        {
            return data.Replace(@"/", "");
        }

        private string GerarChave(string nota, string serie, string data, string cnpj)
        {
            try
            {
                string dataEmissao = TratarData(data);
                string chaveSemDigito = GerarChaveSemDigito(nota, serie, dataEmissao, cnpj);
                string digitoVerificadorCalculado = CalculoDVNotaFiscalEletronica(chaveSemDigito);
                string chave = string.Concat(chaveSemDigito, digitoVerificadorCalculado);
                return chave;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GerarChaveSemDigito(string nota, string serie, string data, string cnpj)
        {
            try
            {
                string mes = data.Substring(2, 2);
                string ano = data.Substring(6, 2);
                return string.Format("00{3}{4}{0}00{1}{2}000000000", cnpj, serie.PadLeft(3, '0'), nota.PadLeft(9, '0'), ano, mes);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CalculoDVNotaFiscalEletronica(string chave)
        {
            try
            {
                string chaveInvertida = ReverseString(chave);
                int[] t = { 2, 3, 4, 5, 6, 7, 8, 9 };
                int somatorio = 0;
                int posicaoParaCalculo = 0;
                foreach (var v in chaveInvertida)
                {
                    somatorio = somatorio + (int.Parse(v.ToString()) * t[posicaoParaCalculo]);
                    if (posicaoParaCalculo == 7)
                    {
                        posicaoParaCalculo = 0;
                    }
                    else
                    {
                        posicaoParaCalculo += 1;
                    }
                }

                int resto = somatorio % 11;
                int dv;
                if (resto == 0 || resto == 1)
                {
                    dv = 0;
                }
                else
                {
                    dv = (11 - resto);
                }

                return dv.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ReverseString(string entrada)
        {
            char[] arrChar = entrada.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtChave.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtChave.Clear();
            txtCnpjExportador.Clear();
            txtNumeroNota.Clear();
            txtSerie.Clear();
            txtNumeroNota.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumeroNota.Focus();
        }

        private void btnCnpjBTP_Click(object sender, EventArgs e)
        {
            txtCnpjExportador.Text = "96452545000108";
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string chave = txtChaveValidar.Text;
                if (string.IsNullOrEmpty(chave))
                    throw new Exception("Favor preencher o campo Chave!");

                if (chave.Length != 44)
                    throw new Exception("Favor preencher uma Chave com 44 caracteres!");

                string digito = chave.Substring(chave.Length - 1, 1);
                string digitoCalculado = CalculoDVNotaFiscalEletronica(chave.Substring(0, chave.Length - 1));
                if (digito == digitoCalculado)
                {
                    string cnpj = chave.Substring(6, 14);
                    string serie = chave.Substring(22, 3);
                    string nota = chave.Substring(25, 9);
                    MessageBox.Show(string.Format("NFe válida!{0}{0}CNPJ: {1}{0}Número: {2}{0}Série: {3}", Environment.NewLine, cnpj, nota, serie), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NFe inválida!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
