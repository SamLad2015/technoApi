using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class TitleService: ITitleService
    {
        private readonly ITitleRepository _titleRepository;

        public TitleService(ITitleRepository titleRepository)
        {
            _titleRepository = titleRepository;
        }
        
        public IEnumerable<Title> GetAllTitles()
        {
            return _titleRepository.GetAll();
        }
    }
}