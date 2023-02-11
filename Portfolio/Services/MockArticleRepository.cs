using Portfolio.Models;

namespace Portfolio.Services
{
    public class MockArticleRepository : IMockArticleRepository
    {
        List<Article> _articles;
        
        public MockArticleRepository()
        {
            _articles= new List<Article>
            {
                new Article
                {
                    Id = 1,
                    Author = "Jason Figueroa",
                    Title = "Faucibus Nisl Tincidunt",
                    Description = "Erat nam at lectus urna duis convallis. Egestas tellus " +
                    "rutrum tellus pellentesque eu tincidunt tortor. Praesent tristique magna " +
                    "sit amet purus gravida quis.",
                    Body = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do " +
                    "eiusmod tempor incididunt ut labore et dolore magna aliqua. Dolor sit amet " +
                    "consectetur adipiscing. Tortor vitae purus faucibus ornare. Ullamcorper morbi " +
                    "tincidunt ornare massa. Amet consectetur adipiscing elit ut aliquam purus sit.</p>" +
                    "<p>Dictum fusce ut placerat orci. Venenatis lectus magna fringilla urna. Varius sit " +
                    "amet mattis vulputate enim nulla aliquet porttitor lacus. Ac orci phasellus egestas " +
                    "tellus rutrum tellus pellentesque eu.</p><p>Quam elementum pulvinar etiam non quam " +
                    "lacus suspendisse. Feugiat vivamus at augue eget arcu dictum varius. Volutpat blandit " +
                    "aliquam etiam erat velit.</p>",
                    IsPublished = true,
                    PublishedDate = new DateTime(2022, 2, 12),
                    Category = "Maecenas",
                    Tags = "fames, ac, ante, ipsum"
                },
                new Article
                {
                    Id = 2,
                    Author = "Jason Figueroa",
                    Title = "Duis maximus pretium feugiat",
                    Description = "Suspendisse finibus vel nulla id tempor. Nullam consequat ligula quis tellus " +
                    "placerat cursus. Morbi vehicula quam sed sollicitudin molestie. Morbi id elit ac justo ullamcorper " +
                    "sodales.",
                    Body = "<p>Vivamus tincidunt nisl id neque auctor tempus at at quam. Praesent non magna congue, " +
                    "dapibus odio a, dapibus neque. Vivamus at enim semper, sollicitudin est sit amet, lacinia felis. " +
                    "Etiam lacinia neque ac lacinia tristique. Mauris non porttitor nibh. Curabitur a blandit dui. Nunc " +
                    "imperdiet lorem purus.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur sapien " +
                    "sapien, lacinia nec est vel, mollis convallis sapien. Sed vel sollicitudin arcu. Praesent purus massa, " +
                    "interdum eu efficitur a, vulputate eget nunc. Sed cursus dolor ultrices scelerisque commodo. In sed lacus " +
                    "at nunc rhoncus auctor. In et convallis sem. Phasellus non lectus convallis, fermentum dui vitae, placerat " +
                    "ipsum. Phasellus tortor lectus, posuere et magna mollis, molestie porta dui.</p><p>Praesent arcu arcu, " +
                    "tristique sed rutrum eget, lacinia vel dui. Nunc pharetra leo quis tellus iaculis, ac lacinia risus rhoncus. " +
                    "Aliquam erat volutpat. Aliquam mollis iaculis dui, a semper enim.</p>",
                    IsPublished = true,
                    PublishedDate = new DateTime(2022, 5, 7),
                    Category = "Mattis",
                    Tags = "lobortis, in"
                },
                new Article
                {
                    Id = 3,
                    Author = "Jason Figueroa",
                    Title = "Proin facilisis sapien odio",
                    Description = "Donec eu justo vel dui congue varius ac lacinia leo.",
                    Body = "<p>Curabitur pellentesque velit quam, quis fermentum tellus luctus ut. " +
                    "Quisque eget ex volutpat, tincidunt lorem et, sodales ex. Fusce semper scelerisque " +
                    "nunc, id ultrices mi semper at. Suspendisse nec ipsum ut metus consectetur " +
                    "consectetur eget ac ipsum. In lobortis ligula vitae leo dictum imperdiet. " +
                    "Curabitur dignissim risus eget elit congue convallis.</p><p>Phasellus elit elit, " +
                    "commodo et ex eget, dignissim sodales neque. Sed blandit libero odio, et sagittis " +
                    "dui dictum vel. Pellentesque ullamcorper purus et pulvinar tempor. Sed iaculis rhoncus " +
                    "sem sit amet sodales. Curabitur in urna fringilla, posuere est in, vulputate neque. " +
                    "Suspendisse laoreet nisl tempus laoreet facilisis. Mauris id massa euismod, vehicula " +
                    "erat eget, bibendum nunc.</p>",
                    IsPublished = false,
                    PublishedDate = new DateTime(2023, 1, 21),
                    Category = "Maecenas",
                    Tags = "quis"
                }
            };
        }

        public Article GetById(int id)
        {
            return _articles.FirstOrDefault(a => a.Id == id && a.IsPublished == true);
        }

        public List<Article> GetAll()
        {
            return _articles.Where(a => a.IsPublished == true).ToList();
        }
    }
}
