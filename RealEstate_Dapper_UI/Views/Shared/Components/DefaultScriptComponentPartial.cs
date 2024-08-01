using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Views.Shared.Components
{
    public class DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
