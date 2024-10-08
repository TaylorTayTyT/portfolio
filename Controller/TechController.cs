using Microsoft.AspNetCore.Mvc;

public class TechController : Controller
{
    public IActionResult Index()
    {
        string[] languages = ["HTML/CSS", "JavaScript", "Java", "TypeScript", "Python", "C", "C++", "C#", "Julia", "SQL"];
        string[] cloudSoftware = ["Firebase", "Google Cloud", "Heroku", "Netlify", "Back4App", "Docker", "GraphQL"];
        string[] stacks = ["MongoDB", "Express", "React", "Node", "Linux", "Apache", "MySQL", "PHP"];
        ViewBag.languages = languages;
        ViewBag.cloudSoftware = cloudSoftware;
        ViewBag.stacks = stacks;

        return View();
    }
}