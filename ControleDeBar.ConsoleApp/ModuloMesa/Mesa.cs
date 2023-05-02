using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ControleDeBar.ConsoleApp.Compartilhado;

namespace ControleDeBar.ConsoleApp.CadastroMesa
{
    public class Mesa : EntidadeBase
    {

        public string conta;
        public string numeroMesa;
        public string status;

        public Mesa(string conta, string numeroMesa, string status)
        {
            this.conta = conta;
            this.numeroMesa = numeroMesa;
            this.status = status;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
          Mesa mesaAtualizada = (Mesa)registroAtualizado;

            conta = mesaAtualizada.conta;
            numeroMesa = mesaAtualizada.numeroMesa;
            status = mesaAtualizada.status;


        }
       
    }
}
