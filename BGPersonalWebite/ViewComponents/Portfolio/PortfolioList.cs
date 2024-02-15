using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BGPersonalWebite.ViewComponents.Portfolio;

public class PortfolioList:ViewComponent
{
    private readonly IPortfolioService _portfolioService;
    public PortfolioList(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }
    public IViewComponentResult Invoke()
    {
        var values=_portfolioService.GetList();
        return View(values);
    }
}
