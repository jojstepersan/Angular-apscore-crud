using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public interface IAutorService
    {
        int Insert(Autor model);
        int Update(Autor model);
    }
}
