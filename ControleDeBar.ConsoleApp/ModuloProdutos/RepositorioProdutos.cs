using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.CadastroDeProdutos
{
    public class RepositorioProdutos : RepositorioBase
    {
        public RepositorioProdutos(ArrayList lista)
        {
            listaRegistros = lista;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Produtos)base.SelecionarPorId(id);
        }
    }
}
