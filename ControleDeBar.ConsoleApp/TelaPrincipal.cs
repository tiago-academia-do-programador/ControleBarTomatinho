using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle do Bar\n");

            Console.WriteLine("Digite 1 para Cadastrar Mesa");
            Console.WriteLine("Digite 2 para Cadastrar Produtos");
            Console.WriteLine("Digite 3 para Cadastrar Garcons");
            Console.WriteLine("Digite 4 para Cadastrar Pedidos");
            Console.WriteLine("Digite 5 para Cadastrar Conta\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

    }
}
