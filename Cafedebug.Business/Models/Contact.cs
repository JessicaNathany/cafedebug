using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Models
{
    public class Contact : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
