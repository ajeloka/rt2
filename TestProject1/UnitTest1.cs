using Projects.

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void program_none()
        {
            //setup
            int test = null;

            //mock

            //assert
            Assert.That(ConsoleApp2.Program.divisor_result(test));
        }

        [Test]
        public void program_valid()
        {
            //setup

            //mock

            //assert
            ConsoleApp2.Program.divisor_result(10);

            Assert.Pass();
        }

        [Test]
        public void program_negative()
        {
            //setup

            //mock

            //assert
            ConsoleApp2.Program.divisor_result(-1);

            Assert.Pass();
        }
    }
}