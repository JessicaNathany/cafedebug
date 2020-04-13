using Cafedebug.Business.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Administrador.ViewModels
{
    public class EpisodeViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Url link do episódio. (SoundCloud / Spotity)
        /// </summary>
        public string Url { get; set; }

        public string ImageUrl { get; set; }

        [NotMappedAttribute]
        public IFormFile ImageUpload { get; set; }

        public IList<EpisodeTag> EpisodiesTags { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool Ative { get; set; }
    }
}
