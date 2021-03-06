// <auto-generated />
using FAQList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQList.Migrations
{
    [DbContext(typeof(QuestionContext))]
    partial class QuestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQList.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CategoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionMSG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicID")
                        .HasColumnType("int");

                    b.Property<string>("TopicType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            CategoryID = 1,
                            CategoryType = "General",
                            QuestionMSG = "What is Bootstrap? - A CSS Framework for creating responsive web apps for multiple screen sizes",
                            TopicID = 1,
                            TopicType = "Bootstrap"
                        },
                        new
                        {
                            QuestionID = 2,
                            CategoryID = 2,
                            CategoryType = "General",
                            QuestionMSG = "What is C#? - a general purpose object oriented language that uses a concise java like syntax",
                            TopicID = 2,
                            TopicType = "C#"
                        },
                        new
                        {
                            QuestionID = 3,
                            CategoryID = 3,
                            CategoryType = "General",
                            QuestionMSG = "What is javascript?- a general purpose scripting language that executes in a web browser",
                            TopicID = 3,
                            TopicType = "Javascript"
                        },
                        new
                        {
                            QuestionID = 4,
                            CategoryID = 2,
                            CategoryType = "History",
                            QuestionMSG = "When was bootstrap released ? - 2011",
                            TopicID = 1,
                            TopicType = "Bootstrap"
                        },
                        new
                        {
                            QuestionID = 5,
                            CategoryID = 2,
                            CategoryType = "History",
                            QuestionMSG = "When was C# released? - 2002",
                            TopicID = 2,
                            TopicType = "C#"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
