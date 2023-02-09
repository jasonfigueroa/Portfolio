namespace Portfolio.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Category { get; set; }
        
        /// <summary>
        /// Comma delimited string containing article tags.
        /// </summary>
        public string Tags { get; set; }
    }
}
