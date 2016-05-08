
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using CB.Data.Common.CRUD;

    class Gost : CB.Data.Common.CRUD.ICreateService<Gost>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GostID { get; set; }
        public string ImeIPrezime { get; set; }

        public Task<Gost> CreateAsync(Gost entity)
        {
            throw new NotImplementedException();
        }
    }
}
