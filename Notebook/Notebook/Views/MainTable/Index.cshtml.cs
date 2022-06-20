using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook.Models;

namespace Notebook.Views.MainTable
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Contact> Contacts { get; set; }
        
        public void OnGet()
        {
            Repository repository = new Repository();
            Contacts = repository.GetContacts();
        }
    }
}
