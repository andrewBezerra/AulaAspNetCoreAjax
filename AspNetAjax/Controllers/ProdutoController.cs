using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetAjax.Models;
using AspNetAjax.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetAjax.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _rep;

        public ProdutoController(IProdutoRepository rep)
        {
            _rep = rep;
        }

        public IActionResult Index()
        {
            if(HttpContext.Request.IsAjaxRequest())
                return PartialView(_rep.Listar());
            else
                return View(_rep.Listar());
        }
        public IActionResult Adicionar()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Produto produto)
        {
            _rep.Adicionar(produto);
            return RedirectToAction(nameof(Index));
        }
    }

    public static class HttpRequestExtensions
    {
        private const string RequestedWithHeader = "X-Requested-With";
        private const string XmlHttpRequest = "XMLHttpRequest";

        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (request.Headers != null)
            {
                return request.Headers[RequestedWithHeader] == XmlHttpRequest;
            }

            return false;
        }
    }
}