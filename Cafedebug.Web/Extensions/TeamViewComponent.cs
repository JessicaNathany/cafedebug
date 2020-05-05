using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Site.Extensions
{
    public class TeamViewComponent : ViewComponent
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        public TeamViewComponent(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var team = _teamRepository.GetAll();

            return View(_mapper.Map<List<TeamViewModel>>(team));
        }
    }
 
}
