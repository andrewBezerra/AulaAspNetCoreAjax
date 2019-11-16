using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetAjax.Models;

namespace AspNetAjax.Repositories
{
    public class MockProdutoRepository : IProdutoRepository
    {
        private static readonly List<Produto> Produtos = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }

        public IEnumerable<Produto> Listar()
        {
            return Produtos;
        }
    }
}
