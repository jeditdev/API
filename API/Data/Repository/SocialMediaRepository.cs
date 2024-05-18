using API.Data.Context;
using API.Data.DTO.SocialMediaDTO;
using API.Data.IRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly SocialMediaContext _socialMediaContext;
        private readonly IMapper _mapper;
        public SocialMediaRepository(SocialMediaContext socialMediaContext, 
                                     IMapper mapper)
        {
            _socialMediaContext = socialMediaContext;
            _mapper = mapper;
        }

        public async Task<List<GetUserPostDTO>> GetUserDetails()
        {
            var userDetails = await _socialMediaContext
                            .Users
                            .Include("Posts")
                            .Include("Comments")
                            .AsNoTracking()
                            .ToListAsync();

            if (userDetails == null)
            {
                return null;
            }

            return _mapper.Map<List<GetUserPostDTO>>(userDetails);
        }
    }
}
