using System.Collections.Generic;
using System;
using log4net;

namespace Cafedebug.Business
{
    /// <summary>
    /// Servicço da Categoria
    /// </summary>
    public class CategoriaService : ICategoriaService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoriaService));

        /// <summary>
        /// Repositório Categoria
        /// </summary>
        public Lazy<ICategoriaRepository> CategoriaRepository { get; set; }


        /// <summary>
        /// Salva uma categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Categoria obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma categoria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui uma categoria
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de categorias
        /// </summary>
        /// <returns></returns>
        public IList<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
