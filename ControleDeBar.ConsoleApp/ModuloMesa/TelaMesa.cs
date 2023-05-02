using ControleDeBar.ConsoleApp.CadastroDeProdutos;
using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.RegistroDePedidos;
using ControleDeBar.ConsoleApp.RegistroGarcons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.CadastroMesa
{
    public class TelaMesa : TelaBase
    {
        private RepositorioMesa repositorioMesa;
        

        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            nomeEntidade = "Mesa";
            sufixo = "s";
            this.repositorioBase = repositorioMesa;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Conta", "Numero da Mesa", "Status Da Mesa");

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} ", mesa.id, mesa.conta, mesa.numeroMesa, mesa.status);
            }
        }
        //conta = mesaAtualizada.conta;
        //    numeroMesa = mesaAtualizada.numeroMesa;
        //    status

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o valor da conta: ");
            string conta = Console.ReadLine();

            Console.Write("Digite o numero da mesa: ");
            string numeroMesa = Console.ReadLine();

            Console.Write("Digite o status da mesa: ");
            string status = Console.ReadLine();



            return new Mesa (conta, numeroMesa, status);
        }
    }
}
