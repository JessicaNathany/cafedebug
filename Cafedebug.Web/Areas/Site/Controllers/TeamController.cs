using System;
using System.Collections.Generic;
using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Web.Areas.Site.ViewModels;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class TeamController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TeamController));
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var team = _teamRepository.GetAll();

            return PartialView("_Team",_mapper.Map<List<TeamViewModel>>(team));
        }
    }
}