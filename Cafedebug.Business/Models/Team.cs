namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Patrocinador
    /// </summary>
    public class Team : Entity
    {
        public string Name { get; set; }
        public string UrlGitHub { get; set; }
        public string UrlInstagram { get; set; }
        public string UrlLinkedin { get; set; }
        public string UrlImage { get; set; }
        public string Job { get; set; }
    }
}
