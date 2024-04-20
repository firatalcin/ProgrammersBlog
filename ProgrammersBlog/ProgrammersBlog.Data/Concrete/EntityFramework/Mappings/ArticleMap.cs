using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.SeoAuthor).IsRequired();
            builder.Property(x => x.SeoAuthor).HasMaxLength(50);
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.SeoDescription).HasMaxLength(150);
            builder.Property(x => x.SeoTags).IsRequired();
            builder.Property(x => x.SeoTags).HasMaxLength(70);
            builder.Property(x => x.ViewsCount).IsRequired();
            builder.Property(x => x.CommentCount).IsRequired();
            builder.Property(x => x.Thumbnail).IsRequired();
            builder.Property(x => x.Thumbnail).HasMaxLength(250);
            builder.HasOne<Category>(x => x.Category).WithMany(y => y.Articles).HasForeignKey(z => z.CategoryId);
            builder.ToTable("Articles");
            builder.HasOne<User>(x => x.User).WithMany(y => y.Articles).HasForeignKey(z => z.UserId);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Note).IsRequired();

            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 11 ve Net 8 Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C# 11.0 ve .Net8 Yenilikleri",
                    SeoTags = "C#, C# 11, .Net8, .Net Core",
                    SeoAuthor = "Fırat Alçın",
                    Date = DateTime.Now,
                    UserId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11 ve Net 8 Yenilikleri",
                    ViewsCount = 100,
                    CommentCount = 1,
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C++ Yenilikleri",
                    SeoTags = "C, C++",
                    SeoAuthor = "Fırat Alçın",
                    Date = DateTime.Now,
                    UserId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ Yenilikleri",
                    ViewsCount = 50,
                    CommentCount = 1,
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "JavaScript S7 Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "JavaScript S7 Yenilikleri",
                    SeoTags = "JavaScript, JS, S7",
                    SeoAuthor = "Fırat Alçın",
                    Date = DateTime.Now,
                    UserId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JavaScript S7 Yenilikleri",
                    ViewsCount = 12,
                    CommentCount = 1,
                });
        }
    }
}
