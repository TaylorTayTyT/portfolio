using System;
public class ProjectObject
{
    public string Title { get; set; }
    public string description { get; set; }
    public string github { get; set; }

    public string[] technologies { get; set; }
    public string img { get; set; }

    public ProjectObject(string Title, string description, string github, string[] technologies, string img)
    {
        this.Title = Title;
        this.description = description;
        this.github = github;
        this.technologies = technologies;
        this.img = img;
    }
}
