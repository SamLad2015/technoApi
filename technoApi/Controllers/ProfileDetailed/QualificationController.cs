using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.ViewModels;

namespace technoApi.Controllers.ProfileDetailed
{
    public class QualificationController : Controller
    {
        private readonly IQualificationService _qualificationService;

        public QualificationController(IQualificationService qualificationService)
        {
            _qualificationService = qualificationService;
        }
        
        [Route("api/profile/{profileId}/[controller]"), HttpGet("{profileId}", Name = "GetProfileQualifications")]
        public IActionResult Get(int profileId)
        {
            var qualificationVms = Mapper.Map<IEnumerable<Models.Profile.Qualification>, 
                IEnumerable<QualificationViewModel>>(_qualificationService.GetProfileQualifications(profileId));
            return new OkObjectResult(qualificationVms);
        }

        [Route("api/[controller]/{id}"), HttpGet("{id}", Name = "GetQualification")]
        public IActionResult GetQualification(int id)
        {
            var qualificationVm = Mapper.Map<Models.Profile.Qualification, 
                QualificationViewModel>(_qualificationService.GetQualification(id)
            );
            return new OkObjectResult(qualificationVm);
        }
    }
}