using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook.Models;

namespace Notebook.Views.MainTable
{
    public class ContactModel : PageModel
    {
        public Guid? Id { get; set; }
        public Contact CurrentContact { get; set; }
        public ContactModel(Guid? Id)
        {
            List<Contact> contacts = new Repository().GetContacts();
            this.Id = Id;
            CurrentContact = contacts.Find(e=>e.Id==Id);
        }
        public void OnGet()
        {
        }
    }
}
