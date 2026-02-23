using Microsoft.AspNetCore.Mvc;
using MyOnlineCV.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace MyOnlineCV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var vm = new CV
        {
            FullName = "Lesego Marota",
            TitleLine = "BCAD Student · Aspiring Software Developer",
            LocationLine = "Gauteng, South Africa",
            ProfileImageUrl = "/img/profile.jpg",

            About = new AboutSection
            {
                Summary =
                    "I’m a third-year student at Emeris Ruimsig (formerly known as IIE MSA), pursuing a Bachelor of Computer and Information Sciences in Application Development (BCAD). " +
                    "My academic journey has provided me with a strong foundation in Java, C#, SQL, network engineering, cybersecurity principles, and cloud computing, utilising Microsoft Azure. " +
                    "I am passionate about technology, problem-solving, and continuous learning, and I am eager to apply my skills in real-world projects while exploring different areas of the tech industry. " +
                    "My goal is to continually build my technical expertise while making meaningful contributions to the tech community."
            },

            Projects = new List<ProjectItem>
            {
                new ProjectItem
                {
                    Name = "Contract Monthly Claim System",
                    Description = "Web application for managing monthly contract claims with authenticated user access and database-backed workflows.",
                    TechStack = "ASP.NET Core MVC · EF Core · ASP.NET Identity · SQL Server",
                    RepoUrl = "https://github.com/Marota-Lesego-ST10448763/ContractMonthlyClaimSystems.git",
                    DemoEmbedUrl = "https://www.youtube.com/embed/s4ssaoe6orw?si=hDsUFYMsRy8Zzqpy", //plaay the youtbe video on the website
                    DemoLinkUrl = "https://youtu.be/s4ssaoe6orw", //the youtube button link
                },
            },

            Education = new List<EducationItem>
            {
                new EducationItem
                {
                    Qualification = "Bachelor of Computer and Information Sciences in Application Development (BCAD)",
                    Institution = "Emeris Ruimsig (formerly IIE MSA)",
                    Year = "Expected: Feb 2024 - Nov 2026"
                }
            },
            Contact = new ContactSection
            {
                LinkedInUrl = "https://www.linkedin.com/in/lesego-marota-0ba506302/",
                GitHubUrl = "https://github.com/Marota-Lesego-ST10448763"
            },
        };

        return View(vm);
    }
}
