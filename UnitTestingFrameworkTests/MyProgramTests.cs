using Microsoft.VisualStudio.TestPlatform.TestHost;
using UnitTestingFramework;

namespace UnitTestingFrameworkTests
{
    public class MyProgramTests
    {
        [Test]
        public void Task1Tests()
        {
            // ARRANGE
            string str = "Marcis";
            int count = 6;
            string str1 = "Marrcis";
            int count1 = 4;
            string str2 = "Marrccis";
            int count2 = 3;

            // ACT
            int countTest = MyProgram.CountMaxNumberOfUnequalConsecutiveCharacters(str);
            int countTest1 = MyProgram.CountMaxNumberOfUnequalConsecutiveCharacters(str1);
            int countTest2 = MyProgram.CountMaxNumberOfUnequalConsecutiveCharacters(str2);

            // ASSERT
            Assert.That(countTest, Is.EqualTo(count));
            Assert.That(countTest1, Is.EqualTo(count1));
            Assert.That(countTest2, Is.EqualTo(count2));
        }
    }
}