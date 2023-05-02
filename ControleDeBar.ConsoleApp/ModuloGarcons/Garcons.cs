using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.RegistroGarcons
{
    public class Garcons : EntidadeBase
    {
        public string nomeGarcom;

        public Garcons(string nomeGarcom)
        {
            this.nomeGarcom = nomeGarcom;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcons garconsAtualizada = (Garcons)registroAtualizado;

            nomeGarcom = garconsAtualizada.nomeGarcom;

        }


    }
}
