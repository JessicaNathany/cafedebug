using System;

namespace Cafedebug.Business.Models
{
    public class Banner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ImageId { get; set; }
        
        public Image Image { get; set; }

        public string Url { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Active { get; set; }
    }
}
