using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;

namespace technoApi.Services
{
    public class JobTitleService: IJobTitleService
    {
        private readonly IJobTitleRepository _jobtitleRepository;

        public JobTitleService(IJobTitleRepository jobtitleRepository)
        {
            _jobtitleRepository = jobtitleRepository;
        }
        
        public IEnumerable<JobTitle> GetAllJobTitles()
        {
            return _jobtitleRepository.GetAll();
        }

    }
}