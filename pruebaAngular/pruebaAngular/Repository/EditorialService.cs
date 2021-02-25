using pruebaAngular.Helpers;
using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public class EditorialService : IEditorialService
    {

        private readonly IRepositoryBase<Editorial> _repository;
        public EditorialService(IRepositoryBase<Editorial> repository) 
        {
            _repository = repository;
        }
        public int Insert(Editorial model)
        {
            model.idEditorial = SequenceTools.NextValSequence("EDITORIAL_SEQ");
            model.maximoLibros = model.maximoLibros ?? -1;
            _repository.Insert(model);
            return model.idEditorial;
        }

        public int Update(Editorial model)
        {
            _repository.Update(model);
            return model.idEditorial;
        }
    }
}
