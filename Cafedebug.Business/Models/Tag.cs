using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade Tag
    /// </summary>
    public class Tag : Entity
    {
        /// <summary>
        /// Descrição da Tag
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Lista de episodios que está relacionado a tag
        /// </summary>
        public IList<EpisodioTag> EpisodiosTags { get; set; }
    }
}
