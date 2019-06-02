using Cafedebug.Service.Interface;
using Cafedebug.Model;
using System.Collections.Generic;
using log4net;
using Cafedebug.Repository.Interface;
using Unity;

namespace Cafedebug.Service
{
    /// <summary>
    /// Servicço da Categoria
    /// </summary>
    public class CategoriaService : ICategoriaService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoriaService));

        [Dependency]
        public ICategoriaRepository CategoriaRepository { get; set; }


        /// <summary>
        /// Salva uma categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Categoria obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Update(Categoria obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Categoria obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de categorias
        /// </summary>
        /// <returns></returns>
        public IList<Categoria> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Recupera uma categoria pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
