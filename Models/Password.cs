using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password_Manager_App.Models
{
    public class Password
    {
        public int Id { get; set; }
        public string Platform { get; set; }
        public string PlatformPassword { get; set; }

        public Password()
        {

        }
    }
}
