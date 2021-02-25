using pruebaAngular.Helpers;
using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public class GeneroService : IGeneroService
    {

        private readonly IRepositoryBase<Genero> _repository;
        public GeneroService(IRepositoryBase<Genero> repository)
        {
            _repository = repository;
        }
        public int Insert(Genero model)
        {
            model.idGenero = SequenceTools.NextValSequence("GENERO_SEQ");
            _repository.Insert(model);
            return model.idGenero;
        }

        public int Update(Genero model)
        {
            _repository.Update(model);
            return model.idGenero; 
        }
    }
}
