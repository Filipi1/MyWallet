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
using MyWallet20;

namespace MyWallet
{
    public partial class Updates : Form
    {
        private bool movimentoLigado;
        private int posX, posY;

        private Novidades novidades = new Novidades();

        public Updates()
        {
            InitializeComponent();
            atualizarNovidades();
        }

        private void atualizarNovidades()
        {
            lblVersao.Text = novidades.getProgramaVersao();
            lblNotas.Text = novidades.getNota1();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            movimentoLigado = true;
            posY = this.Top - MousePosition.Y;
            posX = this.Left - MousePosition.X;
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            movimentoLigado = false;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimentoLigado)
            {
                this.Top = posY + MousePosition.Y;
                this.Left = posX + MousePosition.X;
            }
        }
    }
}
