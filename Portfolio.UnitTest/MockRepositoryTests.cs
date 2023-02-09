using Portfolio.Services;

namespace Portfolio.UnitTest
{
    public class MockRepositoryTests
    {
        private IMockArticleRepository _articleRepository;

        [SetUp]
        public void Setup()
        {
            _articleRepository = new MockArticleRepository();
        }

        [Test]
        public void GetByIdNotNullTest()
        {
            int id = 1;

            var article = _articleRepository.GetById(id);

            Assert.That(article, Is.Not.Null);
        }

        [Test]
        public void GetByIdNullTest()
        {
            int id = 99;

            var article = _articleRepository.GetById(id);

            Assert.That(article, Is.Null);
        }

        [Test]
        public void GetAllTest()
        {
            var articles = _articleRepository.GetAll();
            
            Assert.That(articles.Count, Is.GreaterThan(1));
        }
    }
}