
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

List<string> articleInfo = Console.ReadLine().Split(", ").ToList();
string title = articleInfo[0];
string content = articleInfo[1];
string author = articleInfo[2];

//List<Article> currentArticle = new List<Article>();

Article articles = new Article(title, content, author);

int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
    string[] commands = Console.ReadLine().Split(": ");
    string command = commands[0];

    if (command == "Edit")
    {
        string newContent = commands[1];
        articles.Edit(newContent);        
    }
    else if (command == "ChangeAuthor")
    {
        string newAuthor = commands[1];
        articles.ChangeAuthor(newAuthor);
    }
    else if (command == "Rename")
    {
        string newTitle = commands[1];
        articles.Rename(newTitle);
    }

}
//Console.WriteLine($"{articles.Title} - {articles.Content}: {articles.Author}");

Console.WriteLine(articles); // когато сме направили пренаписания метод ToString, тук можем да напишем само articles вместо както е в горния Console.WriteLine


public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public void Edit(string newContend)
    {
        Content = newContend;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString() // това е вграден  метод, който ние можем да пренаписваме.
    {
        //return base.ToString(); - това е дефолтния
        return $"{Title} - {Content}: {Author}"; //тук вече сме го пренаписали с параметри, които ние искаме
    }


    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }
}
