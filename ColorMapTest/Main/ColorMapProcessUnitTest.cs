namespace ColorMapTest.Main
{
    using BasicTest.Main;
    using NUnit.Framework;
    using TestDataStructure.Main;

    public class ColorMapProcessUnitTest : ColorMapProcessBase
    {
        [Test]
        [TestCaseSource("ColorMapProcessData")]
        public void ColorMapProcess(ColorMapProcessData input)
        {
            // Arrange 
            MainProcess.SetConfiguration(input.Configuration);

            // Act
            var output = MainProcess.Start(input.FileName);

            // Assert
            foreach (var expectedItem in input.Expected)
            {
                var outputValue = output.GetData().ListOfLettersAndCorespondingColors[expectedItem.Key];

                Assert.AreEqual(expectedItem.Value, outputValue);
            }
        }
    }
}
