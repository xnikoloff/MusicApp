using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.SongDTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int? id)
        {
            return View(await _songService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<AllSongsDTO> songs = await _songService.All();

            if (songs == null)
            {
                return NotFound();
            }

            return View(songs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSongDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            if(dto.Genre == 0)
            {
                ModelState.AddModelError("Genre", "Genre is required");
                return View(dto);
            }

            await _songService.Create(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            Song song = await _songService.GetById(id);

            return View(new UpdateSongDTO
            {
                Id = song.Id,
                SongTitle = song.Title,
                Genre = song.Genre
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateSongDTO dto)
        {
            await _songService.Update(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            await _songService.Delete(id);
            return RedirectToAction(nameof(All));
        }
    }
}
