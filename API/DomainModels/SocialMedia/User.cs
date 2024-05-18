using System.ComponentModel.DataAnnotations;

namespace API.DomainModels.SocialMedia
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }


        //Navigation Properties
        public List<Comment> Comments { get; set; }
        public List<Post> Posts { get; set; }

       
    }
}
