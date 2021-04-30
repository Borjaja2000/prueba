using prueba.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Controllers
{
    public class CochesController : Controller
    {
        RepositoryCoches repo;
        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetCoches());
        }
        public IActionResult Details(int id)
        {
            return View(this.repo.FindCoche(id));
        }
    }
}
