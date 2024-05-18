using API.Data.DTO.SocialMediaDTO;

namespace API.Data.IRepository
{
    public interface ISocialMediaRepository
    {
        public Task<List<GetUserPostDTO>> GetUserDetails();
    }
}
