using ControleDeBar.ConsoleApp.CadastroDeProdutos;
using ControleDeBar.ConsoleApp.CadastroMesa;
using ControleDeBar.ConsoleApp.RegistroGarcons;
using System.Collections;
namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);

            TelaPrincipal telaPrincipal = new TelaPrincipal();

            RepositorioProdutos repositorioProdutos = new RepositorioProdutos(new ArrayList());
            TelaProdutos telaProdutos = new TelaProdutos(repositorioProdutos);

            RepositorioGarcons retorioGarcons = new RepositorioGarcons(new ArrayList());
            TelaGarcons telaGarcons = new TelaGarcons(retorioGarcons);


            while (true)
            {
                string opcao = telaPrincipal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoMesa = telaMesa.ApresentarMenu();

                    if (opcaoMesa == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (opcaoMesa == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoMesa == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (opcaoMesa == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }

                    continue;

                }
                else if (opcao == "2")
                {
                    string opcaoProdutos = telaProdutos.ApresentarMenu();

                    if (opcaoProdutos == "1")
                    {
                        telaProdutos.InserirNovoRegistro();
                    }
                    else if (opcaoProdutos == "2")
                    {
                        telaProdutos.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoProdutos == "3")
                    {
                        telaProdutos.EditarRegistro();
                    }
                    else if (opcaoProdutos == "4")
                    {
                        telaProdutos.ExcluirRegistro();
                    }

                    continue;
                        

                }
                else if (opcao == "3")
                {

                    string opcaoGarcons = telaGarcons.ApresentarMenu();

                    if (opcaoGarcons == "1")
                    {
                        telaGarcons.InserirNovoRegistro();
                    }
                    else if (opcaoGarcons == "2")
                    {
                        telaGarcons.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (opcaoGarcons == "3")
                    {
                        telaGarcons.EditarRegistro();
                    }
                    else if (opcaoGarcons == "4")
                    {
                        telaGarcons.ExcluirRegistro();
                    }

                    continue;
                }
            }
        }
    }
}