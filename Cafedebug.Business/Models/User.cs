namespace Cafedebug.Business.Models
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool Ative { get; set; }

        // relation
        public int ImageId { get; set; }

        public Image Image { get; set; }
    }
}
