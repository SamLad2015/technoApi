﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Models.Article;
using technoApi.Models.Widget;
using technoApi.Repositories;
using technoApi.ViewModels;

namespace technoApi.Controllers
{
    [Route("api/[controller]")]
    public class WidgetController : Controller
    {
        private readonly IWidgetService _widgetService;
        
        public WidgetController(IWidgetService widgetService)
        {
            _widgetService = widgetService;
        } 
        
        public IActionResult Get(bool isTree)
        {
            var widgetData = _widgetService.GetWidgets(-1, isTree);
            if (isTree)
            {
                var widgetVms = Mapper.Map<IEnumerable<Widget>, 
                    IEnumerable<WidgetTreeViewModel>>(widgetData);
                return new OkObjectResult(widgetVms);
            }
            else
            {
                var widgetVms = Mapper.Map<IEnumerable<Widget>, 
                    IEnumerable<WidgetListViewModel>>(widgetData);
                return new OkObjectResult(widgetVms);
            }
        }
        
        [HttpGet("{id}", Name = "GetWidget")]
        public IActionResult Get(int id)
        {
            var widgetVm = Mapper.Map<Widget, WidgetTreeViewModel>(_widgetService.GetWidget(id));
            return new OkObjectResult(widgetVm);
        }
    }
}