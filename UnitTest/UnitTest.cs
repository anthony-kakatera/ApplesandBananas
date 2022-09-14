namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //running test
            var result = ApplesBananas.ApplesandBananas.substituteWithVowel("I eat eat mangoes and pineapples", "i");
            //performing test
            Assert.That(result, Is.EqualTo("I eat eat mingiis and piniipplis"));
        }

        [Test]
        public void Test2()
        {
            //running test
            var result = ApplesBananas.ApplesandBananas.substituteWithVowel("I eat eat mangoes and BANANAS", "i");
            //performing test
            Assert.That(result, Is.EqualTo("I eat eat mingiis and BININIS"));
        }

        [Test]
        public void Test3()
        {
            //running test
            var result = ApplesBananas.ApplesandBananas.substituteWithVowel("I eat eat APPLES and BANANAS", "O");
            //performing test
            Assert.That(result, Is.EqualTo("I eat eat OPPLOS and BONONOS"));
        }
    }
}