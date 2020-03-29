using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodeController : BaseController
    {
        private readonly IEpisodeRepository _episodeRepository;
        public EpisodeController(INotifier notifier, IEpisodeRepository episodeRepository) : base(notifier)
        {
            _episodeRepository = episodeRepository;
        }

        public ActionResult Index(PageRequest page)
        {
            var result = _episodeRepository.GetPaged(page); 
            return View();
        }

        public ActionResult NewEpisode()
        {
            return View();
        }

        public ActionResult GetEpisodies()
        {
            return View();
        }

        public ActionResult MoreEpisode()
        {
            return View();
        }
    }
}