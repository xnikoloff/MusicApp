using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Entities;
using MusicApp.Services.DTOs.AlbumDTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int? id)
        {
            return View(await _albumService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            List<AllAlbumsDTO> songs = await _albumService.All();

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
        public async Task<IActionResult> Create(CreateAlbumDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            if (dto.ReleaseDate > DateTime.Now)
            {
                ModelState.AddModelError(nameof(dto.ReleaseDate), "Release Date is required");
            }

            await _albumService.Create(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            Album album = await _albumService.GetById(id);

            return View(new UpdateAlbumDTO
            {
                Id = album.Id,
                Name = album.Name,
                ReleaseDate = album.ReleaseDate
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateAlbumDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            if(dto.ReleaseDate > DateTime.Now)
            {
                ModelState.AddModelError(nameof(dto.ReleaseDate), "Release Date cannot be in the future");
                return View(dto);
            }

            await _albumService.Update(dto);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            await _albumService.Delete(id);
            return RedirectToAction(nameof(All));
        }
    }
}
