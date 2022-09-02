using Microsoft.AspNetCore.Mvc;
using MusicApp.Services.Interfaces;

namespace MusicApp.Web.Controllers
{
    public abstract class BaseController<T> : Controller where T: class
    {
        protected readonly IServiceBase<T> _service;

        public BaseController(IServiceBase<T> service)
        {
            _service = service;
        }

        public abstract Task<IActionResult> All();
    }
}
