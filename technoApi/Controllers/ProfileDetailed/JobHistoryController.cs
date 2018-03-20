using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Controllers.ProfileDetailed
{
    public class JobHistoryController : Controller
    {
        private readonly IJobHistoryService _jobHistoryService;

        public JobHistoryController(IJobHistoryService jobHistoryService)
        {
            _jobHistoryService = jobHistoryService;
        }
        
        [Route("api/profile/{profileId}/[controller]"), HttpGet("{profileId}", Name = "GetProfileJobHistory")]
        public IActionResult Get(int profileId)
        {
            var jobHistoryVms = Mapper.Map<IEnumerable<Models.Profile.JobHistory>, 
                IEnumerable<JobHistoryViewModel>>(_jobHistoryService.GetProfileJobHistory(profileId));
            return new OkObjectResult(jobHistoryVms);
        }

        [Route("api/[controller]/{id}"), HttpGet("{id}", Name = "GetJobHistory")]
        public IActionResult GetJobHistory(int id)
        {
            var jobHistoryVm = Mapper.Map<Models.Profile.JobHistory, 
                JobHistoryViewModel>(_jobHistoryService.GetJobHistory(id)
            );
            return new OkObjectResult(jobHistoryVm);
        }
    }
}