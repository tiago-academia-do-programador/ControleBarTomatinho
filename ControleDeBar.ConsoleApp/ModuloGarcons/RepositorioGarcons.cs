using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.RegistroGarcons
{
    public class RepositorioGarcons : RepositorioBase
    {
        public RepositorioGarcons(ArrayList lista)
        {
            listaRegistros = lista;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Garcons)base.SelecionarPorId(id);
        }
    }
}
