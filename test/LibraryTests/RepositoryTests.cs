using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
    [TestFixture]
    public class RepositoryTests
    {
        private Repository<string> repository;

        [SetUp]
        public void SetUp()
        {
            this.repository = new Repository<string>();
        }

        [Test]
        public void Add_ValidItem_ItemIsFound()
        {
            this.repository.Add("hello");

            string found = this.repository.Find(s => s == "hello");
            Assert.That(found, Is.EqualTo("hello"));
        }

        [Test]
        public void Remove_ExistingItem_ItemIsNoLongerFound()
        {
            this.repository.Add("hello");

            this.repository.Remove("hello");

            string found = this.repository.Find(s => s == "hello");
            Assert.That(found, Is.Null);
        }

        [Test]
        public void Find_NoMatchingCriteria_ReturnsNull()
        {
            this.repository.Add("hello");

            string found = this.repository.Find(s => s == "bye");

            Assert.That(found, Is.Null);
        }

        [Test]
        public void Find_EmptyRepository_ReturnsNull()
        {
            string found = this.repository.Find(s => true);

            Assert.That(found, Is.Null);
        }
    }
}