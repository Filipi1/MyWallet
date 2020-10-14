using MyWallet;
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
using Windows.Forms;

namespace MyWallet20
{
    public partial class JanelaPrincipal : Form
    {
        private bool MovimentoLigado;
        private int posX, posY, situacao, numTema;

        private Saldo saldoFinal = new Saldo();
        private Novidades novidades = new Novidades();

        public String vercaoPrograma = "2.0"; // VERSÃO ATUAL DO PROGRAMA
        
        public JanelaPrincipal()
        {
            InitializeComponent();
            atualizarPrograma();
            atualizarHistorico();
            txtNomePrograma.Text = "MyWallet v" + vercaoPrograma;
            mostrarAtualizacoes();
        }
        //FUNÇÕES DOS BOTÕES
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            validarOperacao();

            if ( situacao == 1) {
                MessageBox.Show("Você deve preencher o campo do DINHEIRO, para informar a quantia a ser retirada ou depositada.", "Error 305: Insira uma quantia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                situacao = 5;
                } else if ( situacao == 2) {
                    MessageBox.Show("Você deve escolher uma opção no campo de OPERAÇÃO, para informar qual o tipo de operação você fará.", "Error 306: Escolha uma operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    situacao = 5;
                        } else if ( situacao == 3) {
                            MessageBox.Show("Você deve preencher o campo do GASTO/FORNECEDOR, para registrar seus gastos e ganhos organizadamente.", "Error 307: Insira um produto ou fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            situacao = 5;
            } else {
                DialogResult dialogResult;
                if (cmbOperacao.Text == "SAQUE")
                    dialogResult = MessageBox.Show("Você realmente deseja SACAR a quantia de '" + txbDinheiro.Text + "' do seu saldo? \n\nSeu novo saldo:", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                else
                    dialogResult = MessageBox.Show("Você realmente deseja DEPOSITAR a quantia de '" + txbDinheiro.Text + "' no seu saldo? \n\nSeu novo saldo:", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    atualizarPrograma();
                    salvarSaldo();
                    salvarHistorico(cmbOperacao.Text, txbGastoForn.Text, txbComplemento.Text);
                    situacao = 0;
                } else
                {
                    MessageBox.Show("Operação cancelada com sucesso!", "Operação Abortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            SetupForm janelaSetup = new SetupForm();
            janelaSetup.Show();
        }
        //MUDANÇAS NOS COMPONENTES
        private void txbGastoForn_TextChanged(object sender, EventArgs e)
        {
            if (txbGastoForn.Value == "")
            {
                corTabValidacao("X", Color.DarkRed);
            }
            else
            {
                corTabValidacao("OK", Color.FromArgb(100, 0, 200, 83));
            }
        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgBarOperacao.BackColor = Color.FromArgb(100, 0, 200, 83);

            if (cmbOperacao.Text == "DEPÓSITO")
            {
                lblGasto.Text = "FORNCECEDOR:";
                txbGastoForn.HintValue = "Ex': Salário do Mês";
            }
            else
            {
                lblGasto.Text = "GASTO:";
                txbGastoForn.HintValue = "Ex': Câmera Fotográfica";
            }
        }

        private void txbComplemento_TextChanged(object sender, EventArgs e)
        {
            int textoEscrevido = txbComplemento.TextLength;
            lblProgressoComp.Text = textoEscrevido + " / 120";

        }

        string valor;
        private void txbDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txbDinheiro.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txbDinheiro_Leave(object sender, EventArgs e)
        {
            valor = txbDinheiro.Text.Replace("R$", "");
            txbDinheiro.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txbDinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txbDinheiro.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txbDinheiro.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txbDinheiro.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txbDinheiro.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txbDinheiro.Text.StartsWith("0,"))
                {
                    txbDinheiro.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txbDinheiro.Text.Contains("00,"))
                {
                    txbDinheiro.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txbDinheiro.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txbDinheiro.Text;
            txbDinheiro.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txbDinheiro.Select(txbDinheiro.Text.Length, 0);
        }
        //MÉTODOS PERSONALIZADOS
        private String getVercao()
        {
            return vercaoPrograma;
        }

        private void corTabValidacao(String texto, Color cor)
        {
            imgBarGastoForn.BackColor = cor;
            btnIndicador.Text = texto;
            btnIndicador.BackColor = cor;
            btnIndicador.FlatAppearance.MouseDownBackColor = cor;
            btnIndicador.FlatAppearance.MouseOverBackColor = cor;
        }

        private void salvarHistorico(String operacao, String gastoForn , String complemento) // SALVA O HISTÓRICO NO ARQUIVO 'REGISTRO.TXT'. 
        {
            String forngasto;
            if (operacao == "SAQUE")
                forngasto = "GASTO: ";
            else
                forngasto = "FORNECEDOR: ";

            StreamReader reader = new StreamReader(@"files\\registro.txt");
            String historico = reader.ReadToEnd();
            reader.Dispose();

            StreamWriter writer = new StreamWriter(@"files\\registro.txt");
            writer.WriteLine("TIPO: " + operacao);
            writer.WriteLine(forngasto + gastoForn);
            if (!complemento.Equals("")) {
                writer.WriteLine("COMPLEMENTO: " + complemento);
            }
            writer.WriteLine("");
            writer.WriteLine(historico);
            writer.Dispose();

            atualizarHistorico();
        }

        private void salvarSaldo() // SALVA O SALDO NO ARQUIVO 'SALDO.TXT'.
        {
            String textoRecebido = txbDinheiro.Text.Replace("R$", "").Replace(" ", "").Replace("00,", "");
            Double.TryParse(textoRecebido, out double saldoTemp);

            double saldoParcial = saldoTemp + saldoFinal.getSaldo();
            saldoFinal.setSaldo(saldoParcial);

            StreamWriter writer = new StreamWriter(@"files\\saldo.txt");
            writer.WriteLine(saldoFinal.getSaldo());
            writer.Dispose();

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            lblSaldo.Text = string.Format("{0:C}", Convert.ToDouble(saldoFinal.getSaldo()));
        }

        public void atualizarPrograma() // CERTIFICA-SE QUE A PASTA FILES E O ARQUIVO 'SALDO.TXT' EXISTAM E ATUALIZA O SALDO.
        {
            String folder = @"files";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!File.Exists(@"files\\saldo.txt"))
            {
                StreamWriter writer = new StreamWriter(@"files\\saldo.txt");
                writer.WriteLine(saldoFinal.getSaldo());
                writer.Dispose();
            }

            if (!File.Exists(@"files\\tema.txt"))
            {
                StreamWriter writerTema = new StreamWriter(@"files\\tema.txt");
                writerTema.WriteLine("1");
                writerTema.Dispose();
            }

            StreamReader reader = new StreamReader(@"files\\saldo.txt");
            String textoObtido = reader.ReadLine().ToString();
            lblSaldo.Text = "R$ " + textoObtido;
            Double.TryParse(textoObtido, out double saldoTemp);
            saldoFinal.setSaldo(saldoTemp);
            reader.Dispose();

            StreamReader readerTema = new StreamReader(@"files\\tema.txt");
            String tema = readerTema.ReadLine();
            int.TryParse(tema, out int temaEscolhido);
            readerTema.Dispose();

            /*
            if (temaEscolhido == 2)
            {
                Color corTop = Color.FromArgb(55, 71, 79); // Barra Superior
                Color corPrimaria = Color.FromArgb(38, 50, 56); // Cor Fundo JanelaPrincipal
                Color corSecundaria = Color.FromArgb(21, 27, 31); // Cor Fundo imgBackMoney
                Color corTernaria = Color.Gold; // Cor LBLS das TXBS
                Color corHistorico = Color.HotPink;
                Color corFundoHistorico = Color.FromArgb(92, 92, 92);
                mudarTema(corTop, corPrimaria, corSecundaria, corTernaria, corHistorico, corFundoHistorico);
            } else
            {
                Color corTop = Color.FromArgb(240, 240, 240); // Barra Superior
                Color corPrimaria = Color.FromArgb(255, 255, 255); // Cor Fundo JanelaPrincipal
                Color corSecundaria = Color.FromArgb(200, 200, 200); // Cor Fundo imgBackMoney
                Color corTernaria = Color.FromArgb(63, 81, 181); // Cor LBLS das TXBS
                Color corHistorico = Color.HotPink;
                Color corFundoHistorico = Color.FromArgb(220, 220, 220);
                mudarTema(corTop, corPrimaria, corSecundaria, corTernaria, corHistorico, corFundoHistorico);
            }
            */
        }

        public void atualizarHistorico()
        {
            if (!File.Exists(@"files\\registro.txt"))
            {
                StreamWriter writer = new StreamWriter(@"files\\registro.txt");
                writer.Dispose();
            }

            StreamReader reader = new StreamReader(@"files\\registro.txt");
            txbHistorico.Text = reader.ReadToEnd();
            reader.Dispose();
        }

        public void zerarHistórico()
        {
            File.Delete(@"files\\registro.txt");
            atualizarHistorico();
            Application.Restart();
        }

        private void validarOperacao()
        {
            if (txbDinheiro.Text == "R$ 0,00" || cmbOperacao.Text == "" || imgBarGastoForn.BackColor == Color.DarkRed)
            {
                if (txbDinheiro.Text == "R$ 0,00") { situacao = 1; }
                if (cmbOperacao.Text == "") { situacao = 2; }
                if (imgBarGastoForn.BackColor == Color.DarkRed) { situacao = 3; }
            }
            else
            {
                situacao = 4;
            }
        }

        private void mostrarAtualizacoes()
        {
            if (!File.Exists(@"files\\update.txt"))
            {
                StreamWriter writerUpdate = new StreamWriter(@"files\\update.txt");
                writerUpdate.Write("1");
                writerUpdate.Dispose();
            }

            StreamReader reader = new StreamReader(@"files\\update.txt");
            int.TryParse(reader.ReadLine(), out int valorUpdate);
            reader.Dispose();

            if (valorUpdate == 1)
            {
                StreamWriter writer = new StreamWriter(@"files\\update.txt");
                writer.Write("0");
                Updates update = new Updates();
                update.Show();
            }
        }

        public void mudarTema(Color corTop, Color corPrimary, Color corSecundaria, Color corTernaria, Color corHistorico, Color corFundoHistorico)
        {
            topBar.BackColor = corTop;
            this.BackColor = corPrimary;
            imgBackMoney.BackColor = corSecundaria;
            lblSaldo.BackColor = corSecundaria;
            cmbOperacao.BackColor = corSecundaria;
            txbGastoForn.BackColor = corSecundaria;
            txbComplemento.BackColor = corSecundaria;
            lblGasto.ForeColor = corTernaria;
            lblOperacao.ForeColor = corTernaria;
            lblComplemento.ForeColor = corTernaria;  
            lblHistorico.ForeColor = corHistorico;
            painelHistorico.BackColor = corFundoHistorico;
            txbHistorico.BackColor = corFundoHistorico;
            imgBackOperacao.BackColor = corFundoHistorico;
            imgBackGasto.BackColor = corFundoHistorico;
            imgBackComplemento.BackColor = corFundoHistorico;
            lblGasto.BackColor = corFundoHistorico;
            lblOperacao.BackColor = corFundoHistorico;
            lblComplemento.BackColor = corFundoHistorico;
        }
        // MOVIMENTO DE JANELA
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            MovimentoLigado = true;
            posX = this.Left - MousePosition.X;
            posY = this.Top - MousePosition.Y;
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            MovimentoLigado = false;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovimentoLigado)
            {
                this.Left = posX + MousePosition.X;
                this.Top = posY + MousePosition.Y;
            }
        }
    }
}