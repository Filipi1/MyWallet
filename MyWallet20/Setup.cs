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
using MyWallet;
using MyWallet20;

namespace MyWallet
{
    public partial class SetupForm : Form
    {
        private bool MovimentoLigado;
        private int posX, posY;

        private String vercaoPrograma;

        public SetupForm()
        {
            InitializeComponent();
            JanelaPrincipal janela = new JanelaPrincipal();
            vercaoPrograma = janela.vercaoPrograma;

            txtPrograma.Text = "MyWallet v" + vercaoPrograma;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizacoes_Click(object sender, EventArgs e)
        {
            verificarAtualizacao("2.0");
        }

        private void verificarAtualizacao(String vercaoRecente)
        {
            if (vercaoPrograma != vercaoRecente)
            {
                MessageBox.Show("Nova versão do MyWallet disponível! Clique em 'OK' para iniciar o download da nova versão.", "Atualização Encontrada!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seu MyWallet já está com a versão mais recente!", "MyWallet Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void verificaVercao()
        {
            String folder = @"temp";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            StreamWriter writer = new StreamWriter(@"temp\\versao.txt");
            writer.Write(vercaoPrograma.ToString());
            writer.Dispose();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            MovimentoLigado = true;
            posX = this.Left - MousePosition.X;
            posY = this.Top - MousePosition.Y;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ( MovimentoLigado )
            {
                this.Left = posX + MousePosition.X;
                this.Top = posY + MousePosition.Y;
            }
        }

        private void btnSHistorico_Click(object sender, EventArgs e)
        {
            verificaVercao();
        }

        private void btnZerarsaldo_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Você realmente deseja ZERAR O SEU SALDO? Esta ação é IRREVERSÍVEL.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( dialog == System.Windows.Forms.DialogResult.Yes)
            {
                Saldo saldoFinal = new Saldo();
                saldoFinal.setSaldo(0.00);

                StreamWriter writer = new StreamWriter(@"files\\saldo.txt");
                writer.WriteLine("0,00");
                writer.Dispose();

                JanelaPrincipal janela = new JanelaPrincipal();
                janela.atualizarPrograma();
                janela.Dispose();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            JanelaPrincipal janela = new JanelaPrincipal();
            janela.Refresh();
            janela.Dispose();

            this.Close();
        }

        private void btnLimparht_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Você realmente deseja LIMPAR O HISTÓRICO? Esta ação é IRREVERSÍVEL.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                JanelaPrincipal janela = new JanelaPrincipal();
                janela.zerarHistórico();
                janela.Dispose();
            }
        }

        private void btnTemaC_Click(object sender, EventArgs e)
        {
            JanelaPrincipal janela = new JanelaPrincipal();
            //janela.mudarTema(Color.DarkBlue);
            janela.Dispose();
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            MovimentoLigado = false;
        }
    }
}