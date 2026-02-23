namespace MyOnlineCV.Models;

public class CV
{
    public string FullName { get; set; } = "Lesego Marota ";
    public string TitleLine { get; set; } = "Third-year Computer Science Student";
    public string LocationLine { get; set; } = "Gauteng, South Africa";
    public string? ProfileImageUrl { get; set; } = "/img/profile.jpg"; // there must be a file in wwwroot/img

    public AboutSection About { get; set; } = new();

    public SkillsSection Skills { get; set; } = new();

    public List<ProjectItem> Projects { get; set; } = new();

    public List<EducationItem> Education { get; set; } = new();

    public ContactSection Contact { get; set; } = new();
}

public class AboutSection
{
    public string Summary { get; set; } =
        "I’m a third-year student at Emeris Ruimsig (formerly IIE MSA), currently completing a Bachelor of Computer and Information Sciences in Application Development (BCAD). " +
        "I’ve built a strong foundation in C#, Java, SQL, and cloud development using Microsoft Azure, with exposure to networking and cybersecurity principles. " +
        "I enjoy solving problems, learning continuously, and applying my skills to real-world projects while exploring different areas of the tech industry.";
}

public class SkillsSection
{
    public List<string> LanguagesAndData { get; set; } = new()
    {
        "C#", "Java", "SQL", "Kotlin"
    };

    public List<string> Cloud { get; set; } = new()
    {
        "Microsoft Azure", "Cloud Development"
    };

    public List<string> CoreConcepts { get; set; } = new()
    {
        "Network Engineering Principles", "CompTIA Principles"
    };

    public List<string> SoftSkills { get; set; } = new()
    {
        "Teamwork", "Problem Solving"
    };
}

public class ProjectItem
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string TechStack { get; set; } = "";
    public string RepoUrl { get; set; } = "";
    public string? DemoEmbedUrl { get; set; }

    // Optional: a normal link to the demo page
    public string? DemoLinkUrl { get; set; }
}

public class EducationItem
{
    public string Qualification { get; set; } = "";
    public string Institution { get; set; } = "";
    public string Year { get; set; } = "";
}

public class ContactSection
{
    public string LinkedInUrl { get; set; } = "https://www.linkedin.com/in/lesego-marota-0ba506302/";
    public string GitHubUrl { get; set; } = "https://github.com/Marota-Lesego-ST10448763";
}