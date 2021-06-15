using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dll.Models
{
    public class Contact
    {
        public long ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}