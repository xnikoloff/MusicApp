using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _service;
        public SongController(ISongService songService)
        {

        }

        public async Task<IActionResult> All()
        {
            return View(await _service.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Song song)
        {
            //await ((ISongService)_service).Create(song);
            return RedirectToAction(nameof(All));
        }
    }
}
