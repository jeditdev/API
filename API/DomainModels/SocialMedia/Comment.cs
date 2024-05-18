using System.ComponentModel.DataAnnotations;

namespace API.DomainModels.SocialMedia
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }

        //Navigation Property
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
