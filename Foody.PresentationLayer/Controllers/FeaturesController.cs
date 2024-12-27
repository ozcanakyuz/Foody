using Foody.BusinnesLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class FeaturesController : Controller
    {
        public readonly IFeatureService _featureService;
        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult FeatureList()
        {
            var values = _featureService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            feature.Status = false;
            _featureService.TInsert(feature);
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _featureService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("FeatureList");
        }
        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
            return RedirectToAction("FeatureList");
        }
    }
}
