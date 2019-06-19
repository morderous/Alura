using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        [Route("categorias", Name = "ListaCategorias")]
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categoria = dao.Lista();
            ViewBag.Categorias = categoria;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);

            return RedirectToAction("Index", "Categoria");
        }

        public ActionResult Form()
        {
            return View();
        }

        [Route("categorias/{id}", Name = "VisualizaCategoria")]
        public ActionResult Visualiza(int id)
        {
            CategoriasDAO dao = new CategoriasDAO();
            CategoriaDoProduto categoria = dao.BuscaPorId(id);
            ViewBag.Produto = categoria;
            return View();

        }
    }
}