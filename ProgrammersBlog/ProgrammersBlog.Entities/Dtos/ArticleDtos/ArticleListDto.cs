using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }
    }
}
