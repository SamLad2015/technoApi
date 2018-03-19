using System.Collections.Generic;
using technoApi.Models.Profile;

namespace technoApi.Interfaces.Services
{
    public interface ITitleService
    {
        IEnumerable<Title> GetAllTitles();
    }
}