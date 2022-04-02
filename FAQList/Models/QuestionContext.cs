using Microsoft.EntityFrameworkCore;
namespace FAQList.Models
{
    public class QuestionContext : DbContext
    {
        public QuestionContext(DbContextOptions<QuestionContext> options)
            : base(options)
        { }
        public DbSet<Question> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 1,
                    QuestionMSG = "What is Bootstrap? - A CSS Framework for creating responsive web apps for multiple screen sizes",
                    CategoryID = 1,
                    CategoryType = "General",
                    TopicType = "Bootstrap",
                    TopicID = 1,
                },
                new Question
                {
                    QuestionID = 2,
                    QuestionMSG = "What is C#? - a general purpose object oriented language that uses a concise java like syntax",
                    CategoryID = 2,
                    CategoryType = "General",
                    TopicType = "C#",
                    TopicID = 2,
                },
                new Question
                {
                    QuestionID = 3,
                    QuestionMSG = "What is javascript?- a general purpose scripting language that executes in a web browser",
                    CategoryID = 3,
                    CategoryType = "General",
                    TopicType = "Javascript",
                    TopicID = 3,
                },
                new Question
                {
                    QuestionID = 4,
                    QuestionMSG = "When was bootstrap released ? - 2011",
                    CategoryID = 2,
                    CategoryType = "History",
                    TopicType = "Bootstrap",
                    TopicID = 1,
                },
                new Question
                {
                    QuestionID = 5,
                    QuestionMSG = "When was C# released? - 2002",
                    CategoryID = 2,
                    CategoryType = "History",
                    TopicType = "C#",
                    TopicID = 2,
                }
            );
        }
    }
}
