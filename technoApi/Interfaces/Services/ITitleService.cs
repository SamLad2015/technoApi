using System.Collections.Generic;
using technoApi.Models;

namespace technoApi.Interfaces.Services
{
    public interface ITitleService
    {
        IEnumerable<Title> GetAllTitles();
    }
}