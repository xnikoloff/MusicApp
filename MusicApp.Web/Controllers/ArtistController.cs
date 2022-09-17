using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _service;
        public ArtistController(IArtistService artistService)
        {

        }

        public async Task<IActionResult> All()
        {
            return View(await _service.All());
        }
    }
}
