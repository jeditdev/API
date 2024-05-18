using API.Data.DTO.SocialMediaDTO;
using API.DomainModels.SocialMedia;
using AutoMapper;

namespace API.DomainModels.MappingProfile
{
    public class SocialMediaMappingProile : Profile
    {
        public SocialMediaMappingProile()
        {
            CreateMap<User, GetUserPostDTO>().ReverseMap();
                    
        }
    }
}
