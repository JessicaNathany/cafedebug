using System;

namespace Cafedebug.Business.Models
{
    public class News : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        // relation
        public int ImageId { get; set; }

        public Image Image { get; set; }

        public string NewsLink { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
