using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;
using WebApplication1.Dao;

using PagedList;

namespace WebApplication1.Controllers
{
    public class ClientesController : Controller
    {
        ClientesDao clientesDao = new ClientesDao();
        // GET: Clientes
        public ActionResult ListadoClientes(int pagina = 1)
        {
            var listado = clientesDao.ListarClientes();
            return View(listado.ToPagedList(pagina, 15));
        }
    }
}