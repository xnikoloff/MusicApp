using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        Task<List<T>> All();
    }
}
