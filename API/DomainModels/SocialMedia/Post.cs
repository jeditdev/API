using System.ComponentModel.DataAnnotations;

namespace API.DomainModels.SocialMedia
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }


        //Navigation Property
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
