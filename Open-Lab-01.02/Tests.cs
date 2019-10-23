using NUnit.Framework;

namespace Open_Lab_01._02
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Sum([Range(-10, 10)] int a, [Range(-10, 10)] int b)
        {
            var exercise = new Exercise();
            Assert.That(exercise.Sum(a, b), Is.EqualTo(a + b));
        }
    }
}