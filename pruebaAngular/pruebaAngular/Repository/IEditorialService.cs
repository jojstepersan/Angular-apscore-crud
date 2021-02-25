using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public interface IEditorialService
    {
        int Insert(Editorial model);
        int Update(Editorial model);
    }
}
