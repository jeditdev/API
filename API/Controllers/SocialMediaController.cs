using API.Data.IRepository;
using API.GeneralModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaRepository _socialMediaRepository;
        public SocialMediaController(ISocialMediaRepository socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var userDetails = await _socialMediaRepository.GetUserDetails();

            return Ok(new GeneralResponse{
                                            Details = userDetails
                                         });
        }
    }
}
