using System.Threading.Tasks;
using AngularEshop.Core.Interfaces;
using AngularEshop.Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.WebApi.Controllers
{
    public class SliderController : SiteBaseController
    {
        #region Constrauctor

        private ISliderService sliderService;

        public SliderController(ISliderService sliderService)
        {
            this.sliderService = sliderService;
        }

        #endregion

        #region AllActiveSliders
        
        [HttpGet("GetActiveSliders")]
        public async Task<IActionResult> GetActiveSliders()
        {
            var sliders = await sliderService.GetActiveSliders();
            return JsonResponseStatus.Success(sliders);
        }
        #endregion

    }
}