using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;

namespace Notebook.Models
{
    public class Repository
    {
        List<Contact> Contacts { get; set; }
        public Repository()
        {
            Contacts = new List<Contact>();
            Contacts = GetContacts();
            SaveContacts();

        }
        public List<Contact> GetContacts()
        {
            Contacts = Json.DeserializeContactsJson();
            return Contacts;
        }

        public void SaveContacts()
        {
            Json.SerializeContactsJson(Contacts);
        }

    }
}
