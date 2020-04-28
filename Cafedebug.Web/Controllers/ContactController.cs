using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Web.ViewModels;
using log4net;
using Microsoft.AspNetCore.Mvc;


namespace Cafedebug.Web.Controllers
{
    public class ContactController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ContactController));

        private readonly IContactService _contactService;
        private IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult ContactUs(ContactViewModel model)
        {
            if (!ModelState.IsValid) return PartialView("_Contact");

            _contactService.Save(_mapper.Map<Contact>(model));

            return RedirectToAction("Index","Home");
        }
    }
}