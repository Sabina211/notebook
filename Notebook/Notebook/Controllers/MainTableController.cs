using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Notebook.Controllers
{
    public class MainTableController : Controller
    {

        public IActionResult Index()
        {
            return View(new Views.MainTable.IndexModel());
        }
        public IActionResult Contact(Guid? Id)
        {
            return View(new Views.MainTable.ContactModel(Id));
        }
    }
}
