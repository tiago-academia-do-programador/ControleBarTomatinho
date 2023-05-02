using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.CadastroDeProdutos
{
    public class Produtos : EntidadeBase
    {
        public string preco;
        public string nomeProduto;

        public Produtos(string preco, string nomeProduto)
        {
            this.preco = preco;
            this.nomeProduto = nomeProduto;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produtos mesaAtualizada = (Produtos)registroAtualizado;

            preco = mesaAtualizada.preco;
            nomeProduto = mesaAtualizada.nomeProduto;
           
        }

    }
}
