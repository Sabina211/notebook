using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Contact(
            string Name, 
            string Surname, 
            string Patronymic, 
            string PhoneNumber, 
            string Address, 
            string Description)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Description = Description;
        }
        public Contact()
        { }


    }
}
