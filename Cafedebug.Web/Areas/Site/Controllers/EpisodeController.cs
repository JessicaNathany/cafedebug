using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Web.Areas.Administrador.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodeController : BaseController
    {
        private readonly IEpisodeRepository _episodeRepository;
        private readonly IEpisodeService _episodeService;
        private IMapper _mapper;
        public EpisodeController(INotifier notifier, IEpisodeRepository episodeRepository, IEpisodeService episodeService, IMapper mapper) : base(notifier)
        {
            _episodeRepository = episodeRepository;
            _episodeService = episodeService;
            _mapper = mapper;
        }

        public ActionResult Index(PageRequest page)
        {
            var result = _episodeRepository.GetPaged(page); 
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(EpisodeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            _episodeService.Save(_mapper.Map<Episode>(model));

            return Redirect("Index");
        }

        public ActionResult Update(int id)
        {
           if(id == 0) return Redirect("Index");

            var episode = _episodeRepository.GetById(id);

            return View("Create", _mapper.Map<EpisodeViewModel>(episode));
        }

        public ActionResult Update(EpisodeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            _episodeService.Save(_mapper.Map<Episode>(model));

            return Redirect("Index");
        }

        public void Delete(int id)
        {
            _episodeService.Delete(id);

        }

    }
}