
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using CB.Data.Common.CRUD;

    class Administrator
    {
        
        public string Password { get; set; }
        public Administrator(string p)
        {
            Password = p;
        }
    }
}
