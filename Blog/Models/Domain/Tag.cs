namespace Blog.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public string DispalyName { get; set; }

        public ICollection <BlogPost> BlogPosts { get; set; } //one tag can have multiple blogpost //

    }
}
