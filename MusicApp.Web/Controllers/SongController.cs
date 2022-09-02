using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class SongController : BaseController<Song>
    {
        public SongController(ISongService songService) : base(songService) {}

        public override async Task<IActionResult> All()
        {
            return View(await _service.All());
        }
    }
}
