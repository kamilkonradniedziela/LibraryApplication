using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class UserModel
    {
        [DisplayName("Imię")]
        public string name { get; set; }

        [DisplayName("Nazwisko")]
        public string surrname { get; set; }
        
        [DisplayName("Hasło")]
        public string password { get; set; }
    }
}
