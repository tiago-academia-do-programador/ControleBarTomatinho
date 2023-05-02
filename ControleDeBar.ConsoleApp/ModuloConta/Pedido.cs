using ControleDeBar.ConsoleApp.CadastroDeProdutos;
using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Pedido : EntidadeBase
    {

        public Produtos produto;
        public string nome;
        public string valor;
        public string quantidade;

        public Pedido(Produtos produto, string nome, string valor, string quantidade)
        {
            this.produto = produto;
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            return;

        }
    }
}
