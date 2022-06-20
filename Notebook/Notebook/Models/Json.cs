using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Models
{
    public class Json
    {
        public static void SerializeContactsJson(List<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText("Contacts.json", json);
        }

        public static List<Contact> DeserializeContactsJson()
        {
            List<Contact> contacts = new List<Contact>();
            List<Contact> contacts2 = new List<Contact>();
            if (File.Exists("Contacts.json"))
            {
                using (StreamReader fileStream = new StreamReader("Contacts.json"))
                {
                    string text2 = fileStream.ReadToEnd();
                   // string text = File.ReadAllText("Contacts.json");
                    //contacts = JsonConvert.DeserializeObject<List<Contact>>(text);
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(text2);
                }
            }
            return contacts;
        }
    }
}
