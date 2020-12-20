using NUnit.Framework;
using AXAdotnet.API;

namespace AXAdotnet.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FilmCountOK()
        {
            var z = GetFilmsController.GetFilms();

            Assert.AreEqual(z.count, 6);
        }
        [Test]
        public void APIResponseNotNull()
        {
            var z = GetFilmsController.GetFilms();

            Assert.IsNotNull(z);
        }
    }
}