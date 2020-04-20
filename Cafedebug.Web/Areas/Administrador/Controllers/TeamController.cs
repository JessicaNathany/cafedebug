using System;
using System.Collections.Generic;
using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Services;
using Cafedebug.Web.Areas.Site.ViewModels;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class TeamController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TeamController));
        private readonly ITeamRepository _teamRepository;
        private readonly ITeamService _teamService;

        private readonly IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper, ITeamService teamService)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
            _teamService = teamService;
        }
        public ActionResult Index()
        {
            var team = _teamRepository.GetAll();

            return PartialView("_Team",_mapper.Map<List<TeamViewModel>>(team));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TeamViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            _teamService.Save(_mapper.Map<Team>(model));

            return RedirectToAction("Create","Team");
        }

        public ActionResult Update(int id)
        {
            if (id == 0) return Redirect("Index");

            var team = _teamRepository.GetById(id);

            return View("Create", _mapper.Map<TeamViewModel>(team));
        }
        public ActionResult Update(TeamViewModel model)
        {
            if (!ModelState.IsValid) return View("Create", model);

            _teamService.Update(_mapper.Map<Team>(model));

            return Redirect("Index");
        }

        public ActionResult Delete(int id)
        {
            _teamService.DeleteById(id);

            return Redirect("Index");
        }
    }
}