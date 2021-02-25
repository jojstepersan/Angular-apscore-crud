using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public interface IGeneroService
    {
        int Insert(Genero model);
        int Update(Genero model);
    }
}
