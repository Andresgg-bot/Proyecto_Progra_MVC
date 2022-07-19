using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra_MVC.Models.DataModels
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public string PhysicalActivity { get; set; }
    }
}
