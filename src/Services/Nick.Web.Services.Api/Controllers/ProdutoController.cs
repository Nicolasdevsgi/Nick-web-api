using Microsoft.AspNetCore.Mvc;
using Nick.Web.Domain.Produtos;
using Nick.Web.Domain.Produtos.Repositorys;
using Nick.Web.Infra.Data.Transactions;
using System;
using System.Collections.Generic;

namespace Nick.Web.Services.Api.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IUnitOfWork _uow;

        public ProdutoController(IProdutoRepository produtoRepository, IUnitOfWork uow)
        {
            _produtoRepository = produtoRepository;
            _uow = uow;
        }

        [Route("produto")]
        [HttpGet]
        public IEnumerable<Produto> BuscarProduto(Produto produto)
        {
            return _produtoRepository.BuscarTodos(produto);
        }

        [Route("produto/{id}")]
        [HttpGet]
        public Produto BuscarPorId(Guid id)
        {
            return _produtoRepository.BuscarPorId(id);
        }

        [Route("produto")]
        [HttpPost]
        public Produto CriarProduto([FromBody] Produto produto)
        {
            _produtoRepository.Adicionar(produto);
            _uow.Commit();

            return produto;
        }

        [Route("produto/{id}")]
        [HttpPut]
        public Produto AtualizarProduto([FromBody] Produto produto, Guid id)
        {
            BuscarPorId(id);
            _produtoRepository.Atualizar(produto);
            _uow.Commit();

            return produto;
        }

        [Route("produto/{id}")]
        [HttpDelete]
        public void RemoverProduto(Guid id)
        {
            _produtoRepository.Remover(id);
            _uow.Commit();
        }
    }
}
