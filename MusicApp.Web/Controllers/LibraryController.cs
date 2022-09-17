using Microsoft.AspNetCore.Mvc;
using MusicApp.Services.DTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryManager _libraryManager;

        public LibraryController(ILibraryManager libraryManager)
        {
            _libraryManager = libraryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _libraryManager.GetSongsLibrary());
        }

        [HttpGet]
        public async Task<IActionResult> SetArtistsToSong(int? songId)
        {
            return View(await _libraryManager.GetSongWithArtists(songId));
        }

        [HttpPost]
        public async Task<IActionResult> SetArtistsToSong(SongWithArtistsDTO dto)
        {
            await _libraryManager.SetArtistsToSong(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> SetAlbumsToSong(int? songId)
        {
            return View(await _libraryManager.GetSongsWithAlbums(songId));
        }

        [HttpPost]
        public async Task<IActionResult> SetAlbumsToSong(SongWithAlbumsDTO dto)
        {
            await _libraryManager.SetAlbumsToSong(dto);
            return RedirectToAction(nameof(Index));
        }
    }
}
