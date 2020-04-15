using AutoMapper;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Web.Areas.Administrador.ViewModels;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class CategoriesController : BaseController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoriesController));
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoriesController(ICategoryRepository categoryRepository, ICategoryService categoryService, IMapper mapper, INotifier notifier) : base(notifier)
        {
            _categoryRepository = categoryRepository;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(CategoryViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            _categoryService.Save(_mapper.Map<Category>(model));

            return Redirect("Index");
        }
       
        public ActionResult Update(int id)
        {
            if (id == 0) return Redirect("Index");

            var category = _categoryRepository.GetById(id);

            return View("Create", _mapper.Map<CategoryViewModel>(category));
        }
        public ActionResult Update(CategoryViewModel model)
        {
            if (!ModelState.IsValid) return View("Create", model);

            _categoryService.Update(_mapper.Map<Category>(model));

            return Redirect("Index");
        }
       
        public ActionResult Delete(int id)
        {
            _categoryService.Remove(id);

            return Redirect("Index");
        }
    }
}