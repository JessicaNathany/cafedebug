using System;
using System.Collections.Generic;
using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Services;
using Cafedebug.Web.Areas.Administrador.ViewModels;
using Cafedebug.Web.Extensions;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    [Area(nameof(Areas.Administrador))]
    [Route("administrador/debbuguers")]
    public class TeamController : BaseController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TeamController));
        private readonly ITeamRepository _teamRepository;
        private readonly ITeamService _teamService;
        private readonly IFileService _fileService;

        private readonly IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper, ITeamService teamService, IFileService fileService, INotifier notifier) : base(notifier)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
            _teamService = teamService;
            _fileService = fileService;
        }

        public ActionResult Index(DataTableParameters dtParameters)
        {

            if (!Request.IsAjaxRequest())
            {
                return View("Index");
            }


            var team = _teamRepository.GetPaged(new PageRequest { Page = dtParameters.Start, ItemsPerPage = dtParameters.Length });
            var data = _mapper.Map<IEnumerable<TeamViewModel>>(team.Items);

            return Json(new
            {
                draw = dtParameters.Draw,
                recordsTotal = team.TotalItems,
                recordsFiltered = team.Items.Count,
                data
            });
        }

     
        [Route("novo-debbuger")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-debbuger")]
        public ActionResult Create(TeamViewModel model)
        
        {
            if (!ModelState.IsValid) return View(model);

            model.UrlImage = "";

            _teamService.Save(_mapper.Map<Team>(model));


            _fileService.UploadImage(model.ImagemUpload);

            return RedirectToAction("Create", "Team");
        }


        [Route("editar-debbuger/{code:guid}")]
        public ActionResult Update(Guid code)
        {
            var team = _teamRepository.GetByCode(code);

            return View("Create", _mapper.Map<TeamViewModel>(team));
        }

        [HttpPost]
        public ActionResult Update(TeamViewModel model)
        {
            if (!ModelState.IsValid) return View("Create", model);

            _teamService.Update(_mapper.Map<Team>(model));

            return Redirect("Index");
        }

        [Route("delete-debbuger")]
        public ActionResult Delete(int id)
        {
            _teamService.DeleteById(id);

            return Redirect("Index");
        }

        [Route("actions")]
        public ActionResult Actions()
        {
            return PartialView("Actions");
        }
    }
}