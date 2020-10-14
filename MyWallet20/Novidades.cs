using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
    class Novidades
    {
        private bool statusVisualizada = true;
        private String programaVersao = "MyWallet v2.0"; // Nome e versão atual do programa.
        private String nota1 = "Olá, está pronto(a) para economizar ainda mais? O MyWallet está novinho em folha refeito do 0! Agora está mais fácil economizar não acha?";

        public String getProgramaVersao()
        {
            return programaVersao;
        }

        public String getNota1()
        {
            return nota1;
        }

        public void setStatusVisualizada(bool status)
        {
            statusVisualizada = status;
        }

        public bool getStatusVisualizada()
        {
            return statusVisualizada;
        }

    }
}
