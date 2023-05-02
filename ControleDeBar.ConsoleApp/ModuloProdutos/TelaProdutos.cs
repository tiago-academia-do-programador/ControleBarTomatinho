using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.CadastroDeProdutos
{
    public class TelaProdutos : TelaBase
    {
        private RepositorioProdutos repositorioprodutos;


        public TelaProdutos(RepositorioProdutos repositorioProdutos)
        {
            nomeEntidade = "Produto";
            sufixo = "s";
            this.repositorioBase = repositorioProdutos;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} ", "Id", "Nome Do Produto", "Valor do Produto");

            Console.WriteLine("------------------------------------------------------------------");

            foreach (Produtos produtos in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produtos.id, produtos.nomeProduto, produtos.preco);
            }
        }
        //public string preco;
        //public string nomeProduto;

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            string preco = Console.ReadLine();




            return new Produtos(nomeProduto, preco);
        }
    }
}
