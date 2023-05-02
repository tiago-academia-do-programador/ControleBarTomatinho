using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.RegistroGarcons
{
    public class TelaGarcons : TelaBase
    {
        private RepositorioGarcons repositorioGarcons;
        private string nomeGarcom;

        public TelaGarcons(RepositorioGarcons repositorioGarcons)
        {
            nomeEntidade = "Garçon";
            sufixo = "s";
            this.repositorioBase = repositorioGarcons;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -30}", "Id", "Nome do Garçom");

            Console.WriteLine("---------------------------------------------");

            foreach (Garcons garcons in registros)
            {
                Console.WriteLine("{0, -10} | {1, -30} ", garcons.id, garcons.nomeGarcom);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do garçom: ");
            string garcons = Console.ReadLine();

            return new Garcons(garcons);
        }
    }
}
