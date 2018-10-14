using FakeItEasy;
using FakerDotNet.Fakers;
using NUnit.Framework;

namespace FakerDotNet.Tests.Fakers
{
    [TestFixture]
    [Parallelizable]
    public class AvatarFakerTests
    {
        [SetUp]
        public void SetUp()
        {
            _fakerContainer = A.Fake<IFakerContainer>();
            _avatarFaker = new AvatarFaker(_fakerContainer);
        }

        private IFakerContainer _fakerContainer;
        private IAvatarFaker _avatarFaker;

        [Test]
        public void Image_returns_a_url()
        {
            Assert.Fail();
        }

        [Test]
        public void Image_returns_a_url_with_specified_slug()
        {
            Assert.Fail();
        }

        [Test]
        public void Image_returns_a_url_with_specified_size()
        {
            Assert.Fail();
        }

        [Test]
        public void Image_returns_a_url_with_specified_format()
        {
            Assert.Fail();
        }

        [Test]
        public void Image_returns_a_url_with_specified_set()
        {
            Assert.Fail();
        }

        [Test]
        public void Image_returns_a_url_with_specified_bgset()
        {
            Assert.Fail();
        }

        [Test]
        [TestCase("100")]
        [TestCase("abc")]
        [TestCase("2x2x2")]
        public void Image_throws_ArgumentException_if_size_is_not_a_valid_format(string invalidSize)
        {
            Assert.Fail();
        }

        [Test]
        [TestCase("gif")]
        [TestCase("mov")]
        [TestCase("2x2x2")]
        public void Image_throws_ArgumentException_if_format_is_not_supported(string invalidFormat)
        {
            Assert.Fail();
        }
    }
}
