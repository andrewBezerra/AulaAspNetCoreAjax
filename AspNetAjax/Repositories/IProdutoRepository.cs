using AspNetAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAjax.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Listar();
        void Adicionar(Produto produto);
    }
}
