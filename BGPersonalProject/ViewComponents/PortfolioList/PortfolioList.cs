using Microsoft.AspNetCore.Mvc;

namespace BGPersonalProject.ViewComponents.PortfolioList;

public class PortfolioList:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
