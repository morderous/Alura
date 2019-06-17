using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(String nome, float preco, String descricao, int quantidade, int categoriaId)
        {
            Produto produto = new Produto()
            {
                Nome = nome,
                Preco = preco,
                Descricao = descricao,
                Quantidade = quantidade,
                CategoriaId = categoriaId
            };

            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);

            return View();
        }
}