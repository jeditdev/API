using API.DomainModels.SocialMedia;

namespace API.Data.DTO.SocialMediaDTO
{
    public class GetUserPostDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public List<Post> posts { get; set; }
        public List<Comment> comments { get; set; }
    }
}
