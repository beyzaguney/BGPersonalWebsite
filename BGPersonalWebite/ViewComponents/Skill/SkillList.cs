using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;
using BGPersonalWebsite.ViewComponents.Contact;

namespace BGPersonalWebsite.ViewComponents.Skill;

public class SkillList:ViewComponent
{
    private readonly ISkillService _skillService;
    public SkillList(ISkillService skillService)
    {
        _skillService = skillService;
    }
    public IViewComponentResult Invoke()
    {
        var values = _skillService.GetList();
        return View(values);
    }
}
