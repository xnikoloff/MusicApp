using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.ArtistDTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int? id)
        {
            return View(await _artistService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<AllArtistsDTO> songs = await _artistService.All();

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
        public async Task<IActionResult> Create(CreateArtistDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            await _artistService.Create(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            Artist artist = await _artistService.GetById(id);

            return View(new UpdateArtistDTO
            {
                Id = artist.Id,
                StageName = artist.StageName,
                RealName = artist.RealName,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateArtistDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            await _artistService.Update(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            await _artistService.Delete(id);
            return RedirectToAction(nameof(All));
        }
    }
}
