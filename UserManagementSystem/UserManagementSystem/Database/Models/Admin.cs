using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Database.Models
{
    
        abstract class Admin : User
        {
            protected Admin(string name, string surname, string email, string password, int id)
                : base(name, surname, email, password, id)
            {

            }
        }
    
}
