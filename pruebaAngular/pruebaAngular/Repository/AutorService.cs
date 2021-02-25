using pruebaAngular.Helpers;
using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public class AutorService : IAutorService
    {

        private readonly IRepositoryBase<Autor> _repository;
        public AutorService(IRepositoryBase<Autor> repository)
        {
            _repository = repository;
        }
        public int Insert(Autor model)
        {
            model.idAutor = SequenceTools.NextValSequence("AUTOR_SEQ");
            _repository.Insert(model);
            return model.idAutor;
        }

        public int Update(Autor model)
        {
            _repository.Update(model);
            return model.idAutor;
        }
    }
}
