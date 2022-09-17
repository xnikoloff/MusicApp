using MusicApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Services.Interfaces
{
    public interface ISongService : IServiceBase<Song>
    {
        Task<int> Create(Song song);
    }
}
