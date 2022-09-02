using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class ArtistController : BaseController<Artist>
    {
        public ArtistController(IArtistService artistService) : base(artistService) { }

        public override async Task<IActionResult> All()
        {
            return View(await _service.All());
        }
    }
}
