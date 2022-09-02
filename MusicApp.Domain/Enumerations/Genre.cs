using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Enumerations
{
    public enum Genre
    {
        Pop = 1,
        Rock = 2,
        Metal = 3,
        [Display(Name = "Hip-Hop")]
        HipHop = 4,
        Dance = 5,
        House = 6,
        Techno = 7,
        Jazz = 8,
        Blues = 9,
        Soul = 10,
        RnB = 11,
        Trap = 12
    }
}
