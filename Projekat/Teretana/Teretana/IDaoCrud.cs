using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana
{
    public interface IDaoCrud<T>
    {
        long create(T entity); // INSERT INTO a long će biti aut kreirani id reda
        T read(T entity); // SELECT FROM WHERE ..
        T update(T entity); // UPDATE
        void delete(T entity); // DELETE
        T getById(int id); // SELECT .. WHRE ID=
        List<T> getAll(); // SELECT *
        List<T> getByExample(string name, string value); // SELECT .. WHERE name=value
    }
}
